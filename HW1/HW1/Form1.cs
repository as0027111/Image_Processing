using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HW1
{

    public partial class Form1 : Form
    {
        static Color[] colors = { Color.Red, Color.Green, Color.Blue, Color.Orange, Color.Yellow, Color.LightBlue };
        string img_path;
        OpenFileDialog open_file_dialog = new OpenFileDialog();
        Bitmap[] img_history = new Bitmap[10];
        int step_counter = 0;
        int step_now;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            img_history[step_counter + 1] = new Bitmap(img_history[step_counter]);

            for (int y=0; y < img_history[step_counter].Height; y++)
            {
                for(int x=0; x < img_history[step_counter].Width; x++)
                {
                    Color RGB = img_history[step_counter].GetPixel(x, y); // 讀 (x,y) 的 RGB 
                    int gray = Convert.ToInt32(RGB.R * 0.299 + RGB.G * 0.587 + RGB.B * 0.114);

                    img_history[step_counter + 1].SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }
            this.pictureBox2.Image = null;
            this.pictureBox2.Image = img_history[step_counter + 1];
            step_counter++;
            Console.WriteLine(step_counter);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            img_history[step_counter + 1] = new Bitmap(img_history[step_counter]);
            for (int y = 0; y < img_history[step_counter].Height; y++)
            {
                for (int x = 0; x < img_history[step_counter].Width; x++)
                {
                    int R_gray = Convert.ToInt32(img_history[step_counter].GetPixel(x, y).R); // 讀 (x,y) 的 RGB 
                    img_history[step_counter +1 ].SetPixel(x, y, Color.FromArgb(R_gray, R_gray, R_gray));
                }
            }
            step_counter++;
            this.pictureBox2.Image = null;
            this.pictureBox2.Image = img_history[step_counter];
            Console.WriteLine(step_counter);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            img_history[step_counter + 1] = new Bitmap(img_history[step_counter]);
            for (int y = 0; y < img_history[step_counter].Height; y++)
            {
                for (int x = 0; x < img_history[step_counter].Width; x++)
                {
                    int G_gray = Convert.ToInt32(img_history[step_counter].GetPixel(x, y).G);
                    img_history[step_counter + 1].SetPixel(x, y, Color.FromArgb(G_gray, G_gray, G_gray));
                }
            }
            step_counter++;
            this.pictureBox2.Image = null;
            this.pictureBox2.Image = img_history[step_counter];
        }
        private void button4_Click(object sender, EventArgs e)
        {
            img_history[step_counter + 1] = new Bitmap(img_history[step_counter]);
            for (int y = 0; y < img_history[step_counter].Height; y++)
            {
                for (int x = 0; x < img_history[step_counter].Width; x++)
                {
                    int B_gray = Convert.ToInt32(img_history[step_counter].GetPixel(x, y).B);
                    img_history[step_counter + 1].SetPixel(x, y, Color.FromArgb(B_gray, B_gray, B_gray));
                }
            }
            step_counter++;
            this.pictureBox2.Image = null;
            this.pictureBox2.Image = img_history[step_counter];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            float sum = 0;
            Color each_pixel_value;
            img_history[step_counter + 1] = new Bitmap(img_history[step_counter]);
            for (int y = 1; y < img_history[step_counter].Height-1; y++)
            {
                for (int x = 1; x < img_history[step_counter].Width-1; x++)
                {
                    // 3x3 filter
                    for(int i = x-1; i <= x + 1; i++)
                    {
                        for(int j = y-1; j <= y + 1; j++)
                        {
                            each_pixel_value = img_history[step_counter].GetPixel(i, j);
                            sum += each_pixel_value.R;
                        }
                    }
                    int color = (int)Math.Round(sum / 9, 10);
                    img_history[step_counter + 1].SetPixel(x+1, y+1, Color.FromArgb(color, color, color));
                    sum = 0;
                }
            }
            step_counter++;
            this.pictureBox2.Image = null;
            this.pictureBox2.Image = img_history[step_counter];

        }
        private void button6_Click(object sender, EventArgs e)
        {
            int[] neighbor = new int [9];
            int neighbor_counter = 0;
            Color each_pixel_value;
            img_history[step_counter + 1] = new Bitmap(img_history[step_counter]);

            for (int y = 1; y < img_history[step_counter].Height - 1; y++)
            {
                for (int x = 1; x < img_history[step_counter].Width - 1; x++)
                {
                    // 3x3 filter
                    for (int i = x-1; i <= x + 1; i++)
                    {
                        for (int j = y-1; j <= y + 1; j++)
                        {
                            each_pixel_value = img_history[step_counter].GetPixel(i, j);
                            neighbor[neighbor_counter] = each_pixel_value.R;
                            neighbor_counter += 1;
                        }
                    }
                    Array.Sort(neighbor);
                    int color = neighbor[4];
                    img_history[step_counter + 1].SetPixel(x, y, Color.FromArgb(color, color, color));
                    neighbor_counter = 0;
                }
            }
            step_counter++;
            this.pictureBox2.Image = null;
            this.pictureBox2.Image = img_history[step_counter];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            img_history[step_counter + 1] = new Bitmap(img_history[step_counter]); // 要確定有做 grayscale
            double[] statistics_original = getGrayHistogram(img_history[step_counter + 1]);
            img_history[step_counter + 1] = Equalization(img_history[step_counter + 1], statistics_original);
            double[] statistics_after = getGrayHistogram(img_history[step_counter + 1]);
            
           
            step_counter++;
            this.pictureBox2.Image = null;
            this.pictureBox2.Image = img_history[step_counter];

            // Histogram
            chart1.Visible = true;
            chart2.Visible = true;
            chart1.Series.Clear();
            chart2.Series.Clear();
            Series series_1 = new Series();
            series_1.ChartType = SeriesChartType.Column;
            series_1.Name = "Before";
            chart1.Series.Add(series_1);
            
            Series series_2 = new Series();
            series_2.ChartType = SeriesChartType.Column;
            series_2.Name = "After";
            chart2.Series.Add(series_2);
            
            for (int i=0; i < 256; i++)
            {
                chart1.Series["Before"].Points.AddXY(i, statistics_original[i]);
                chart2.Series["After"].Points.AddXY(i, statistics_after[i]);
            }
        }

        private double[] getGrayHistogram(Bitmap grayImage)
        {
            double[] statistics = new double[256];
            //int[] statistics = new int[256]; //應該會歸零吧? 
            for (int y = 0; y < grayImage.Height; y++)
            {
                for (int x = 0; x < grayImage.Width; x++)
                {
                    int pixel_value = grayImage.GetPixel(x, y).R;
                    statistics[pixel_value]++;
                }
            }

            return statistics;
        }

        private Bitmap Equalization(Bitmap grayImage, double[] statistics)
        {
            double total_pixel_num = grayImage.Height * grayImage.Width;
            double[] density = new double[256];
            for (int k = 0; k < 256; k++)
            {
                density[k] = statistics[k] / total_pixel_num;
            }
            for (int y = 0; y < grayImage.Height; y++)
            {
                for (int x = 0; x < grayImage.Width; x++)
                {
                    double densitySum = 0;
                    Color value = grayImage.GetPixel(x, y);
                    for (int k = 0; k <= value.R; k++)
                    {    //累積機率
                        densitySum += density[k];
                    }
                    byte s = (byte)Math.Round(255 * densitySum);
                    Color newValue = Color.FromArgb(s, s, s);
                    grayImage.SetPixel(x, y, newValue);

                }
            }
            return grayImage;


        }



        private void button8_Click(object sender, EventArgs e)
        {
            // 還要寫防止小於 0 的
            if (step_counter == 0) return;
            step_counter--;
            Console.WriteLine(step_counter);

            this.pictureBox2.Image = img_history[step_counter];

        }




        private void button9_Click(object sender, EventArgs e)
        {
            chart1.Visible = false;
            chart2.Visible = false;
            this.registration_label.Visible = false;
            open_file_dialog.InitialDirectory = ".";
            open_file_dialog.Filter = "All Files|*.*|Bitmap Files (.bmp)|*.bmp|Jpeg File(.jpg)|*.jpg";
            open_file_dialog.ShowDialog();
            if (open_file_dialog.FileName != String.Empty)
            {
                //Console.WriteLine(open_file_dialog.FileName);
                img_path = open_file_dialog.FileName;
                img_history[0] = new Bitmap(open_file_dialog.FileName);
                step_counter = 0; // 一定要記得做
                this.pictureBox1.Image = img_history[step_counter];
            }
        }
        
        private void button10_Click(object sender, EventArgs e)
        {
            int threshold = Convert.ToInt32(this.textBox2.Text);
            Console.WriteLine(threshold);
            img_history[step_counter + 1] = new Bitmap(img_history[step_counter]);
            for (int y = 0; y < img_history[step_counter].Height; y++)
            {
                for (int x = 0; x < img_history[step_counter].Width; x++)
                {
                    int gray_value = img_history[step_counter].GetPixel(x, y).R; 
                    if(img_history[step_counter].GetPixel(x, y).R > threshold)
                    {
                        img_history[step_counter + 1].SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                    else
                    {
                        img_history[step_counter + 1].SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                }
            }
            step_counter++;
            this.pictureBox2.Image = null;
            this.pictureBox2.Image = img_history[step_counter];

        }

        private void Sobel_X_BTN_Click(object sender, EventArgs e)
        {
            img_history[step_counter + 1] = new Bitmap(img_history[step_counter]);
            for (int y = 1; y < img_history[step_counter].Height-1; y++)
            {
                for (int x = 1; x < img_history[step_counter].Width-1; x++)
                {
                    int[] mask = new int[9];
                    int current = x + (y * img_history[step_counter].Width);

                    // 3x3 filter
                    int counter = 0;
                    for (int i = x-1; i <= x+1; i++)
                    {
                        for (int j = y-1; j <= y+1; j++)
                        {
                            mask[counter++] = img_history[step_counter].GetPixel(i, j).R;
                        }
                    }

                    int gray_value = Convolution(mask, 1);
                    img_history[step_counter + 1].SetPixel(x, y, Color.FromArgb(gray_value, gray_value, gray_value));
                }
            }
            step_counter++;
            this.pictureBox2.Image = null;
            this.pictureBox2.Image = img_history[step_counter];
        }

        private int Convolution(int[] conv_array, int case_number) // case_number 1:x, 2:y, 0:both
        {
            int[] mask_x ={
                    -1,0,1,
                    -2,0,2,
                    -1,0,1
            };

            int[] mask_y ={
                -1,-2,-1,
                0,0,0,
                1,2,1
            };
            int gray_x = 0, gray_y = 0;
            for(int i = 0; i < conv_array.Length; i++)
            {
                gray_x += (conv_array[i] * mask_x[i]);
                gray_y += (conv_array[i] * mask_y[i]);
            }
            if (case_number == 1)
            {
                return gray_x = (byte)((gray_x < 0) ? 0 : gray_x);  // 回傳 byte ??
            }
            else if (case_number == 2)
            {
                return gray_y = (byte)((gray_y < 0) ? 0 : gray_y);
            }
            else
            {
                int value = (int)Math.Pow((gray_x * gray_x + gray_y * gray_y), 0.5);
                value = (byte)((value < 0) ? 0 : value);
                return (byte)((value > 255) ? 255 : value);
            }
        }

        private void Sobel_Y_BTN_Click(object sender, EventArgs e)
        {
            img_history[step_counter + 1] = new Bitmap(img_history[step_counter]);
            for (int y = 1; y < img_history[step_counter].Height - 1; y++)
            {
                for (int x = 1; x < img_history[step_counter].Width - 1; x++)
                {
                    int[] mask = new int[9];
                    int current = x + (y * img_history[step_counter].Width);

                    // 3x3 filter
                    int counter = 0;
                    for (int i = x - 1; i <= x + 1; i++)
                    {
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            mask[counter++] = img_history[step_counter].GetPixel(i, j).R;
                        }
                    }

                    int gray_value = Convolution(mask, 2);
                    img_history[step_counter + 1].SetPixel(x, y, Color.FromArgb(gray_value, gray_value, gray_value));
                }
            }
            step_counter++;
            this.pictureBox2.Image = null;
            this.pictureBox2.Image = img_history[step_counter];

        }

        private void Sobel_BTN_Click(object sender, EventArgs e)
        {
            img_history[step_counter + 1] = new Bitmap(img_history[step_counter]);
            for (int y = 1; y < img_history[step_counter].Height - 1; y++)
            {
                for (int x = 1; x < img_history[step_counter].Width - 1; x++)
                {
                    int[] mask = new int[9];
                    int current = x + (y * img_history[step_counter].Width);

                    // 3x3 filter
                    int counter = 0;
                    for (int i = x - 1; i <= x + 1; i++)
                    {
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            mask[counter++] = img_history[step_counter].GetPixel(i, j).R;
                        }
                    }

                    int gray_value = Convolution(mask, 0);
                    img_history[step_counter + 1].SetPixel(x, y, Color.FromArgb(gray_value, gray_value, gray_value));
                }
            }
            step_counter++;
            this.pictureBox2.Image = null;
            this.pictureBox2.Image = img_history[step_counter];

        }

        private void Overlap_Btn_Click(object sender, EventArgs e)
        {
            int threshold = Convert.ToInt32(this.textBox3.Text);
            img_history[step_counter + 1] = new Bitmap(img_history[step_counter]);
            for (int y = 0; y < img_history[step_counter].Height; y++)
            {
                for (int x = 0; x < img_history[step_counter].Width; x++)
                {
                    Color RGB_value = img_history[1].GetPixel(x, y);
                    if (img_history[step_counter].GetPixel(x, y).R > threshold)
                    {
                        img_history[step_counter + 1].SetPixel(x, y, Color.FromArgb(0, 255, 0));
                    }
                    else
                    {
                        img_history[step_counter + 1].SetPixel(x, y, RGB_value);
                    }
                }
            }
            step_counter++;
            this.pictureBox2.Image = null;
            this.pictureBox2.Image = img_history[step_counter];

        }

        private int[,] ConvertBitmapTo2DArray(Bitmap bitmap)
        {
            int[,] imgary = new int[bitmap.Width, bitmap.Height];
            int x, y;
            for (x = 0; x < bitmap.Width; x++)
            {
                for (y = 0; y < bitmap.Height; y++)
                {
                    // 有可能不是 0 or 255?  0 -> 1, 255 -> 0
                    imgary[x, y] = ((bitmap.GetPixel(x, y).R == 255) ? 0 : 1); 
                }
            }
            return imgary;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            img_history[step_counter + 1] = new Bitmap(img_history[step_counter]);
            int[,] graph = ConvertBitmapTo2DArray(img_history[step_counter + 1]);

            // DFS 的設定
            int row_count = img_history[step_counter + 1].Width;
            int col_count = img_history[step_counter + 1].Height; // 要記得設定
            int[] dx = {+1, 0, -1, 0, +1, -1, -1, +1};
            int[] dy = {0, +1, 0, -1, +1, +1, -1, -1};
            int[,] label = new int[row_count, col_count];
            int component = 0;

            for (int y = 0; y < img_history[step_counter].Height; y++)
            {
                for (int x = 0; x < img_history[step_counter].Width; x++)
                {
                    if (label[x, y]==0 & graph[x, y]==1) dfs(x, y, ++component); // component: 1~N
                }
            }
            Console.WriteLine(component);
            Color[] component_color_ary = GetRandomColor(component+1);
            for (int y = 0; y < img_history[step_counter].Height; y++)
            {
                for (int x = 0; x < img_history[step_counter].Width; x++)
                {
                    //Console.WriteLine(label[x, y]);
                    img_history[step_counter + 1].SetPixel(x, y, component_color_ary[label[x,y]]);
                }
            }
            step_counter++;
            this.pictureBox2.Image = null;
            this.pictureBox2.Image = img_history[step_counter];
            this.registration_label.Visible = true;
            this.registration_label.Text = "Num of components: " + component.ToString("0.##");

            void dfs(int x, int y, int current_label)
            {
                if (x < 0 || x == row_count) return; // out of bounds
                if (y < 0 || y == col_count) return; // out of bounds
                if (label[x, y]!=0 || graph[x, y]==0 ) return; // already labeled or not marked with 1 in graph

                label[x, y] = current_label; // mark the current cell

                for (int direction=0; direction<8; direction++)
                {
                    dfs(x + dx[direction], y + dy[direction], current_label);
                }
            }

            Color[] GetRandomColor(int num_component)
            {
                Color[] component_ary = new Color[num_component];
                var random = new Random();
                component_ary[0] = Color.White;
                for (int i = 1; i < num_component; i++)
                    component_ary[i] = colors[random.Next(colors.Length)];
                return component_ary;
            }

        }

        Point[] original = new Point[4];
        Point[] transform = new Point[4];

        private void origin_Btn_Click(object sender, EventArgs e)
        {
            chart1.Visible = false;
            chart2.Visible = false;

            open_file_dialog.InitialDirectory = ".";
            open_file_dialog.Filter = "All Files|*.*|Bitmap Files (.bmp)|*.bmp|Jpeg File(.jpg)|*.jpg";
            open_file_dialog.ShowDialog();
            if (open_file_dialog.FileName != String.Empty)
            {
                //Console.WriteLine(open_file_dialog.FileName);
                img_path = open_file_dialog.FileName;
                img_history[0] = new Bitmap(open_file_dialog.FileName);
                step_counter = 0; // 一定要記得做
                this.pictureBox1.Image = img_history[step_counter];
            }
            for (int i = 0; i < original.Length; i++) original[i] = Point.Empty;
            registration_o = 0;
        }

        private void transformed_Btn_Click(object sender, EventArgs e)
        {
            chart1.Visible = false;
            chart2.Visible = false;

            open_file_dialog.InitialDirectory = ".";
            open_file_dialog.Filter = "All Files|*.*|Bitmap Files (.bmp)|*.bmp|Jpeg File(.jpg)|*.jpg";
            open_file_dialog.ShowDialog();
            if (open_file_dialog.FileName != String.Empty)
            {
                //Console.WriteLine(open_file_dialog.FileName);
                img_path = open_file_dialog.FileName;
                img_history[1] = new Bitmap(open_file_dialog.FileName);  // 這樣必須是先打開原檔
                step_counter = 1; // 一定要記得做
                this.pictureBox2.Image = img_history[1];
            }
            for (int i = 0; i < transform.Length; i++) transform[i] = Point.Empty; // 每次初始化
            registration_t = 0;
        }

        int registration_o = 0, registration_t = 0;  // draw red point restrict

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinate_1 = me.Location;
            //Console.WriteLine(coordinate_1);
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            original[registration_o] = coordinate_1;
            Draw_red_point(bmp, coordinate_1, registration_o++);
            pictureBox1.Image = bmp;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinate_2 = me.Location;
            //Console.WriteLine(coordinate_2);
            Bitmap bmp_2 = new Bitmap(pictureBox2.Image);
            transform[registration_t] = coordinate_2;
            Draw_red_point(bmp_2, coordinate_2, registration_t++);
            pictureBox2.Image = bmp_2;
        }

        private void Draw_red_point(Bitmap picture, Point coordinate, int restriction_flag)
        {
            int point_size = 3;
            if (restriction_flag >= 4) return;
            //restriction_flag++;
            for (int x =-point_size; x< point_size+1; x++)
            {
                for (int y= -point_size; y< point_size+1; y++)
                {
                    if(coordinate.X + x > -1 && coordinate.Y + y > -1 && coordinate.X + x < picture.Width && coordinate.Y + y < picture.Height)                   
                        picture.SetPixel(coordinate.X + x, coordinate.Y + y, Color.FromArgb(255, 0, 0));                        
                }
            }
        }

        private void registration_Btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine(step_counter);

            double angle = GetAngleFromPoint(transform[0], transform[1]);
            double theta = Math.PI * angle / 180.0;
            Console.WriteLine(angle);
            double[] scaling = GetScaling(original, transform, angle);
            Console.WriteLine(scaling[0]);
            Console.WriteLine(scaling[1]);
            //img_history[step_counter + 1] = new Bitmap(img_history[0]);
            img_history[step_counter + 1] = utilize.registration(img_history[0], img_history[step_counter], theta, scaling[0]);
            double difference = utilize.Difference(img_history[step_counter + 1], img_history[step_counter]);

            Console.WriteLine(difference);
            this.registration_label.Visible = true;
            this.registration_label.Text = "Scaling: " + (scaling[0]).ToString("0.##") + "\n" 
                                         + "Angle:  " + angle.ToString("0.##") + "\n"
                                         + "Difference: " + difference.ToString("0.##");
            this.pictureBox2.Image = null;
            this.pictureBox2.Image = img_history[step_counter + 1];
            step_counter++;
            Console.WriteLine(step_counter);
        }

        private double GetAngleFromPoint(Point point_1, Point point_2)
        {
            double dy = (point_1.Y - point_2.Y);
            double dx = (point_1.X - point_2.X);
            double theta = Math.Atan2(dy, dx);

            double angle = 180 + ((theta * 180) / Math.PI);
            return angle;
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog sfd = new SaveFileDialog();
            if(sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                img_history[step_counter].Save(sfd.FileName);
            }

        }

        private double[] GetScaling(Point[] ori, Point[] trans, double angle)
        {
            double[] scaling = new double[2]; // scaling[0]: scaling along x, scaling[1]: scaling along y
            double transformed_w = Math.Abs(trans[1].Y - trans[0].Y) / Math.Abs(Math.Sin(Math.PI * angle / 180.0)); 
            double transformed_h = Math.Abs(trans[2].X - trans[0].X) / Math.Abs(Math.Sin(Math.PI * angle / 180.0));

            scaling[0] = transformed_w / Math.Abs(ori[0].X - ori[1].X);
            scaling[1] = transformed_h / Math.Abs(ori[0].Y - ori[2].Y);
            return scaling;
        }
        
     }
}
