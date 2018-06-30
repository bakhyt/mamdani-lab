using System;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace EducationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double completion, reading, participation, assesment;
        public double MCompletion, MReading, MParticipation, MAssesment;
        public double Delta, Centroid;
        public double O1, O2;
        public double M1, M2;
        public double Result, Value;
        public string output;
        private void Cancel_Click(object sender, EventArgs e)
        {
            Completion.Text = "0";
            Reading.Text = "0";
            Participation.Text = "0";
            Assesment.Text = "0";
            Output.Text = "0";
        }
        private void File_Click(object sender, EventArgs e)
        {            
        }              
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        public void CompletionCalc()
        {
            if (completion >= 0 && completion <= 45)
            {
                Centroid = 0;
                Delta = 18.5;

                MCompletion = Math.Pow(Math.E, (-Math.Pow((completion - Centroid), 2) / (2 * Math.Pow(Delta, 2))));
            }
            else if (completion > 45 && completion <= 100)
            {
                Centroid = 100;
                Delta = 18.5;
                MCompletion = Math.Pow(Math.E, (-Math.Pow((completion - Centroid), 2) / (2 * Math.Pow(Delta, 2))));
            }
        }

        public void ReadingCalc()
        {
            if (reading >= 0 && reading <= 30)
            {
                Centroid = 0;
                Delta = 13.93;

                MReading = Math.Pow(Math.E, (-Math.Pow((reading - Centroid), 2) / (2 * Math.Pow(Delta, 2))));
            }
            else if (reading > 30 && reading <= 70)
            {
                Centroid = 50;
                Delta = 13.93;

                MReading = Math.Pow(Math.E, (-Math.Pow((reading - Centroid), 2) / (2 * Math.Pow(Delta, 2))));                
            }
            else if (reading > 70 && reading <= 100)
            {
                Centroid = 100;
                Delta = 13.93;

                MReading = Math.Pow(Math.E, (-Math.Pow((reading - Centroid), 2) / (2 * Math.Pow(Delta, 2))));
            }
        }

        public void ParticipationCalc()
        {
            if (participation >= 0 && participation <= 30)
            {
                Centroid = 0;
                Delta = 13.93;

                MParticipation = Math.Pow(Math.E, (-Math.Pow((participation - Centroid), 2) / (2 * Math.Pow(Delta, 2))));               
            }
            else if (participation > 30 && participation <= 70)
            {
                Centroid = 50;
                Delta = 13.93;

                MParticipation = Math.Pow(Math.E, (-Math.Pow((participation - Centroid), 2) / (2 * Math.Pow(Delta, 2))));               
            }
            else if (participation > 70 && participation <= 100)
            {
                Centroid = 100;
                Delta = 13.93;

                MParticipation = Math.Pow(Math.E, (-Math.Pow((participation - Centroid), 2) / (2 * Math.Pow(Delta, 2))));                
            }
        }

        public void AssesmentCalc()
        {
            if (assesment >= 0 && assesment <= 45)
            {
                Centroid = 0;
                Delta = 18.5;

                MAssesment = Math.Pow(Math.E, (-Math.Pow((assesment - Centroid), 2) / (2 * Math.Pow(Delta, 2))));               
            }
            else if (assesment > 45 && assesment <= 100)
            {
                Centroid = 100;
                Delta = 18.5;

                MAssesment = Math.Pow(Math.E, (-Math.Pow((assesment - Centroid), 2) / (2 * Math.Pow(Delta, 2))));       
            }
        }

        public void ResultCalc()
        {
            //0 0 0 0
            if (completion <= 45 && reading <= 45 && participation <= 45 && assesment <= 45)
            {
                O1 = Math.Max(Math.Min(MCompletion, MReading), Math.Min(MParticipation, MAssesment));
                O2 = 0;
            }

            //0 0 0 1
            if (completion <= 45 && reading <= 45 && participation <= 45 && assesment > 45)
            {
                M1 = Math.Min(Math.Min(MCompletion, MReading), MParticipation);
                M2 = MAssesment;
                
                if (M2 > M1)
                {
                    O1 = 0;
                    O2 = M2;
                }
                else
                {
                    O1 = M1;
                    O2 = 0;
                }               
            }

            //0 0 1 0
            if (completion <= 45 && reading <= 45 && participation > 45 && assesment <= 45)
            {
                M1 = Math.Min(Math.Min(MCompletion, MReading), MAssesment);
                M2 = MParticipation;
                
                if (M2 > M1)
                {
                    O1 = 0;
                    O2 = M2;
                }
                else
                {
                    O1 = M1;
                    O2 = 0;
                }               
            }

            //0 0 1 1
            if (completion <= 45 && reading <= 45 && participation > 45 && assesment > 45)
            {
                M1 = Math.Min(MCompletion, MReading);
                M2 = Math.Min(MParticipation, MAssesment);
                
                if (M2 > M1)
                {
                    O1 = 0;
                    O2 = M2;
                }
                else
                {
                    O1 = M1;
                    O2 = 0;
                }               
            }

            //0 1 0 0
            if (completion <= 45 && reading > 45 && participation <= 45 && assesment <= 45)
            {
                M1 = Math.Min(Math.Min(MCompletion, MParticipation), MAssesment);
                M2 = MReading;

                if (M2 > M1)
                {
                    O1 = 0;
                    O2 = M2;
                }
                else
                {
                    O1 = M1;
                    O2 = 0;
                }
            }

            //0 1 0 1
            if (completion <= 45 && reading > 45 && participation <= 45 && assesment > 45)
            {
                M1 = Math.Min(MCompletion, MParticipation);
                M2 = Math.Min(MReading, MAssesment);
                
                if (M2 > M1)
                {
                    O1 = 0;
                    O2 = M2;
                }
                else
                {
                    O1 = M1;
                    O2 = 0;
                }               
            }

            //0 1 1 0
            if (completion <= 45 && reading > 45 && participation > 45 && assesment <= 45)
            {
                M1 = Math.Min(MCompletion, MAssesment);
                M2 = Math.Min(MReading, MParticipation);
                if (M2 > M1)
                {
                    O1 = 0;
                    O2 = M2;
                }
                else
                {
                    O1 = M1;
                    O2 = 0;
                }                               
            }

            //0 1 1 1
            if (completion <= 45 && reading > 45 && participation > 45 && assesment > 45)
            {
                M1 = MCompletion;
                M2 = Math.Min(Math.Min(MReading, MParticipation), MAssesment);
                
                if (M2 > M1)
                {
                    O1 = 0;
                    O2 = M2;
                }
                else
                {
                    O1 = M1;
                    O2 = 0;
                }               
            }

            //1 0 0 0
            if (completion > 45 && reading <= 45 && participation <= 45 && assesment <= 45)
            {
                M1 = Math.Min(Math.Min(MReading, MParticipation), MAssesment);
                M2 = MCompletion;
               
                if (M2 > M1)
                {
                    O1 = 0;
                    O2 = M2;
                }
                else
                {
                    O1 = M1;
                    O2 = 0;
                }               
            }

            //1 0 0 1
            if (completion > 45 && reading <= 45 && participation <= 45 && assesment > 45)
            {
                M1 = Math.Min(MReading, MParticipation);
                M2 = Math.Min(MCompletion, MAssesment);
   
                if (M2 > M1)
                {
                    O1 = 0;
                    O2 = M2;
                }
                else
                {
                    O1 = M1;
                    O2 = 0;
                }            
            }

            //1 0 1 0
            if (completion > 45 && reading <= 45 && participation > 45 && assesment <= 45)
            {
                M1 = Math.Min(MReading, MAssesment);
                M2 = Math.Min(MCompletion, MParticipation);

                if (M2 > M1)
                {
                    O1 = 0;
                    O2 = M2;
                }
                else
                {
                    O1 = M1;
                    O2 = 0;
                }              
            }

            //1 0 1 1
            if (completion > 45 && reading <= 45 && participation > 45 && assesment > 45)
            {
                M1 = MReading;
                M2 = Math.Min(Math.Min(MCompletion, MParticipation), MAssesment);

                if (M2 > M1)
                {
                    O1 = 0;
                    O2 = M2;
                }
                else
                {
                    O1 = M1;
                    O2 = 0;
                }               
            }

            //1 1 0 0
            if (completion > 45 && reading > 45 && participation <= 45 && assesment <= 45)
            {
                M1 = Math.Min(MParticipation, MAssesment);
                M2 = Math.Min(MCompletion, MReading);
      
                if (M2 > M1)
                {
                    O1 = 0;
                    O2 = M2;
                }
                else
                {
                    O1 = M1;
                    O2 = 0;
                }             
            }

            //1 1 0 1
            if (completion > 45 && reading > 45 && participation <= 45 && assesment > 45)
            {
                M1 = MParticipation;
                M2 = Math.Min(Math.Min(MCompletion, MReading), MAssesment);
               
                if (M2 > M1)
                {
                    O1 = 0;
                    O2 = M2;
                }
                else
                {
                    O1 = M1;
                    O2 = 0;
                }              
            }

            //1 1 1 0
            if (completion > 45 && reading > 45 && participation > 45 && assesment <= 45)
            {
                M1 = MAssesment;
                M2 = Math.Min(Math.Min(MCompletion, MReading), MParticipation);
                
                if (M2 > M1)
                {
                    O1 = 0;
                    O2 = M2;
                }
                else
                {
                    O1 = M1;
                    O2 = 0;
                }              
            }

            //1 1 1 1
            if (completion > 45 && reading > 45 && participation > 45 && assesment > 45)
            {
                O1 = 0;
                O2 = Math.Max(Math.Min(MCompletion, MReading), Math.Min(MParticipation, MAssesment));              
            }

            //COG
            if (O1 > 0)
            {
                Centroid = 0;
                Delta = 18.5;
                Value = Centroid + Math.Sqrt(-2 * Math.Pow(Delta, 2) * Math.Log(O1));
                Result = (O1 * Value) / O1;                                                      
            }
            else if (O2 > 0)
            {
                Delta = 18.5;
                if ((completion + reading + participation + assesment) > 260)
                {
                    Centroid = 100;
                    Value = Centroid - Math.Sqrt(-2 * Math.Pow(Delta, 2) * Math.Log(O2));
                }
                else
                {
                    Centroid = 20;
                    Value = Centroid + Math.Sqrt(-2 * Math.Pow(Delta, 2) * Math.Log(O2));
                }
                Result = (O2 * Value) / O2;                             
            }
        }

        public void Classification()
        {
            if (Result <= 45)
            {
                output = "Retake";
            }
            else if (Result > 45)
            {
                output = "Passed";
            }
        }

        public void CalcAll()
        {
            CompletionCalc();
            ReadingCalc();
            ParticipationCalc();
            AssesmentCalc();
            ResultCalc();
            Classification();
        }

        public void ShowResult()
        {
            CalcAll();
            Output.Text = output;
        }
        private void Calculate_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(Completion.Text) >= 0 && Convert.ToDouble(Completion.Text) <= 100)
            {
                completion = Convert.ToDouble(Completion.Text);
            }
            else
            {
                Completion.Text = "0";
                completion = 0;
            }
            if (Convert.ToDouble(Reading.Text) >= 0 && Convert.ToDouble(Reading.Text) <= 100)
            {
                reading = Convert.ToDouble(Reading.Text);
            }
            else
            {
                Reading.Text = "0";
                reading = 0;
            }
            if (Convert.ToDouble(Participation.Text) >= 0 && Convert.ToDouble(Participation.Text) <= 100)
            {
                participation = Convert.ToDouble(Participation.Text);
            }
            else
            {
                Participation.Text = "0";
                participation = 0;
            }
            if (Convert.ToDouble(Assesment.Text) >= 0 && Convert.ToDouble(Assesment.Text) <= 100)
            {
                assesment = Convert.ToDouble(Assesment.Text);
            }
            else
            {
                Assesment.Text = "0";
                assesment = 0;
            }
            ShowResult();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double desired;
            completion = 29.3; reading = 3.09; participation = 63.2; assesment = 48.1; desired = 36;
            ShowResult();
            textBox1.Text += completion + ";  " + reading + ";  " + participation+";  "+assesment+";\n";
            textBox2.Text += desired+"\n";
            textBox3.Text += String.Format("{0:F1}",Result)+"\n";
            textBox4.Text += String.Format("{0:F1}",Math.Abs(desired - Result))+"\n";

            completion = 27.9; reading = 33.1; participation = 73.1; assesment = 2.9; desired = 34;
            ShowResult();
            textBox1.Text += completion + ";  " + reading + ";  " + participation + ";  " + assesment + ";\n";
            textBox2.Text += desired+"\n";
            textBox3.Text += String.Format("{0:F1}", Result)+"\n";
            textBox4.Text += String.Format("{0:F1}", Math.Abs(desired - Result))+"\n";

            completion = 41.8; reading = 18.1; participation = 73.2; assesment = 72.9; desired = 51;
            ShowResult();
            textBox1.Text += completion + ";  " + reading + ";  " + participation + ";  " + assesment + ";\n";
            textBox2.Text += desired + "\n";
            textBox3.Text += String.Format("{0:F1}", Result)+"\n";
            textBox4.Text += String.Format("{0:F1}", Math.Abs(desired - Result))+"\n";

            completion = 14.2; reading = 48.1; participation = 2.89; assesment = 2.9; desired = 17;
            ShowResult();
            textBox1.Text += completion + ";  " + reading + ";  " + participation + ";  " + assesment + "; \n";
            textBox2.Text += desired + "\n";
            textBox3.Text += String.Format("{0:F1}", Result) + "\n";
            textBox4.Text += String.Format("{0:F1}", Math.Abs(desired - Result)) + "\n";

            completion = 32.9; reading = 78.1; participation = 2.89; assesment = 48.1; desired = 41.00;
            ShowResult();
            textBox1.Text += completion + ";  " + reading + ";  " + participation + ";  " + assesment + "; \n";
            textBox2.Text += desired + "\n";
            textBox3.Text += String.Format("{0:F1}", Result) + "\n";
            textBox4.Text += String.Format("{0:F1}", Math.Abs(desired - Result)) + "\n";

            completion = 41.8; reading = 53.2; participation = 33.1; assesment = 78.2; desired = 52;
            ShowResult();
            textBox1.Text += completion + ";  " + reading + ";  " + participation + ";  " + assesment + ";\n";
            textBox2.Text += desired + "\n";
            textBox3.Text += String.Format("{0:F1}", Result) + "\n";
            textBox4.Text += String.Format("{0:F1}", Math.Abs(desired - Result)) + "\n";

            completion = 49.4; reading = 83.3; participation = 63.2; assesment = 48.1; desired = 61;
            ShowResult();
            textBox1.Text += completion + ";  " + reading + ";  " + participation + ";  " + assesment + ";\n";
            textBox2.Text += desired + "\n";
            textBox3.Text += String.Format("{0:F1}", Result) + "\n";
            textBox4.Text += String.Format("{0:F1}", Math.Abs(desired - Result)) + "\n";

            completion = 34.3; reading = 58.4; participation = 73.1; assesment = 2.9; desired = 42;
            ShowResult();
            var stopwatch = Stopwatch.StartNew();
            {
                Thread.Sleep(5000);

                //Thread.Sleep(5000);
                textBox1.Text += completion + ";  " + reading + ";  " + participation + ";  " + assesment + ";\n";
                textBox2.Text += desired + "\n";
                textBox3.Text += String.Format("{0:F1}", Result) + "\n";
                textBox4.Text += String.Format("{0:F1}", Math.Abs(desired - Result)) + "\n";
                stopwatch.Stop();
            }
        }
    }
}
