using System;

namespace MamdaniEducation
{
    class Program
    {
        public static double Completion, Reading, Participation, Assesment;
        public static double MCompletion, MReading, MParticipation, MAssesment;
        public static double Delta, Centroid;
        public static double C1, C2, R1, R2, R3, P1, P2, P3, A1, A2, O1, O2;
        public static double M1, M2;
        public static double Result, Value, r1, r2;
        public static string Output;

        public static void CompletionCalc()
        {
            if(Completion>=0 && Completion<=45)
            {                
                Centroid = 0;
                Delta =18.5;

                MCompletion = Math.Pow(Math.E, (-Math.Pow((Completion-Centroid), 2) / (2 * Math.Pow(Delta, 2))));
                //MCompletion = (45 - Completion) / 45;
                C1 = MCompletion;
                C2 = 0;
            }
            if (Completion >45  && Completion <= 100)
            {                
                Centroid = 100;
                Delta = 18.5;

                MCompletion = Math.Pow(Math.E, (-Math.Pow((Completion - Centroid), 2) / (2 * Math.Pow(Delta, 2))));
                //MCompletion = (Completion - 45) / 55;
                C2 = MCompletion;
                C1 = 0;
            }
        }

        public static void ReadingCalc()
        {
            if (Reading >= 0 && Reading <= 30)
            {
                Centroid = 0;
                Delta = 13.93;

                MReading = Math.Pow(Math.E, (-Math.Pow((Reading - Centroid), 2) / (2 * Math.Pow(Delta, 2))));
                //MReading = (30 - Reading) / 30;
                R1 = MReading;
                R2 = 0;
                R3 = 0;
            }
            if (Reading > 30 && Reading <= 70)
            {
                Centroid = 50;
                Delta = 13.93;

                MReading = Math.Pow(Math.E, (-Math.Pow((Reading - Centroid), 2) / (2 * Math.Pow(Delta, 2))));
                /*
                if (Reading <= 50)
                {
                    MReading = (Reading - 30) / 20;
                }
                else if(Reading>50)
                {
                    MReading = (70 - Reading) / 20;
                }
                */
                R1 = 0;
                R2 = MReading;
                R3 = 0;
            }
            if (Reading > 70 && Reading <= 100)
            {
                Centroid = 100;
                Delta = 13.93;

                MReading = Math.Pow(Math.E, (-Math.Pow((Reading - Centroid), 2) / (2 * Math.Pow(Delta, 2))));
                //MReading = (Reading - 70) / 30;
                R1 = 0;
                R2 = 0;
                R3 = MReading;
            }
        }

        public static void ParticipationCalc()
        {
            if (Participation >= 0 && Participation <= 30)
            {
                Centroid = 0;
                Delta = 13.93;

                MParticipation = Math.Pow(Math.E, (-Math.Pow((Participation - Centroid), 2) / (2 * Math.Pow(Delta, 2))));
                //MParticipation = (30 - Participation) / 30;
                P1 = MParticipation;
                P2 = 0;
                P3 = 0;
            }
            if (Participation > 30 && Participation <= 70)
            {
                Centroid = 50;
                Delta = 13.93;

                MParticipation = Math.Pow(Math.E, (-Math.Pow((Participation - Centroid), 2) / (2 * Math.Pow(Delta, 2))));
                /*
                if (Participation <= 50)
                {
                    MParticipation = (Participation - 30) / 20;
                }
                else if (Participation > 50)
                {
                    MParticipation = (70 - Participation) / 20;
                }
                */
                P1 = 0;
                P2 = MParticipation;
                P3 = 0;
            }
            if (Participation > 70 && Participation <= 100)
            {
                Centroid = 100;
                Delta = 13.93;

                MParticipation = Math.Pow(Math.E, (-Math.Pow((Participation - Centroid), 2) / (2 * Math.Pow(Delta, 2))));
                //MParticipation = (Participation - 70) / 30;
                P1 = 0;
                P2 = 0;
                P3 = MParticipation;
            }
        }

        public static void AssesmentCalc()
        {
            if (Assesment >= 0 && Assesment <= 45)
            {
                Centroid = 0;
                Delta = 18.5;

                MAssesment = Math.Pow(Math.E, (-Math.Pow((Assesment - Centroid), 2) / (2 * Math.Pow(Delta, 2))));
                //MAssesment = (45 - Assesment) / 45;
                A1 = MAssesment;
                A2 = 0;
            }
            if (Assesment > 45 && Assesment <= 100)
            {
                Centroid = 100;
                Delta = 18.5;

                MAssesment = Math.Pow(Math.E, (-Math.Pow((Assesment - Centroid), 2) / (2 * Math.Pow(Delta, 2))));
                //MAssesment = (Assesment - 45) / 55;
                A1 = 0;
                A2 = MAssesment;
            }
        }

        public static void ResultCalc()
        {
            //0 0 0 0
            if(Completion<=45 && Reading<=45 && Participation<=45 && Assesment<=45)
            {
                O1 = Math.Max(Math.Min(MCompletion, MReading), Math.Min(MParticipation, MAssesment));
                O2 = 0;
            }

            //0 0 0 1
            if (Completion <= 45 && Reading <= 45 && Participation <= 45 && Assesment > 45)
            {
                M1 = Math.Min(Math.Min(MCompletion, MReading), MParticipation);
                M2 = MAssesment;
                ///*
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
                //*/
                /*
                if (M2 > M1)
                {
                    O1 = M2;
                    O2 = 0;
                }
                else
                {
                    O1 = 0;
                    O2 = M1;
                }
                */
            }

            //0 0 1 0
            if (Completion <= 45 && Reading <= 45 && Participation > 45 && Assesment <= 45)
            {
                M1 = Math.Min(Math.Min(MCompletion, MReading), MAssesment);
                M2 = MParticipation;
                ///*
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
                //*/
                /*
                if (M2 > M1)
                {
                    O1 = M2;
                    O2 = 0;
                }
                else
                {
                    O1 = 0;
                    O2 = M1;
                }
                */
            }

            //0 0 1 1
            if (Completion <= 45 && Reading <= 45 && Participation > 45 && Assesment > 45)
            {
                M1 = Math.Min(MCompletion, MReading);
                M2 = Math.Min(MParticipation, MAssesment);
                ///*
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
                //*/
                /*
                if (M2 > M1)
                {
                    O1 = M2;
                    O2 = 0;
                }
                else
                {
                    O1 = 0;
                    O2 = M1;
                }
                */
            }

            //0 1 0 0
            if (Completion <= 45 && Reading > 45 && Participation <= 45 && Assesment <= 45)
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
            if (Completion <= 45 && Reading > 45 && Participation <= 45 && Assesment > 45)
            {
                M1 = Math.Min(MCompletion, MParticipation);
                M2 = Math.Min(MReading, MAssesment);
                ///*
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
                //*/
                /*
                if (M2 > M1)
                {
                    O1 = M2;
                    O2 = 0;
                }
                else
                {
                    O1 = 0;
                    O2 = M1;
                }
                */
            }

            //0 1 1 0
            if (Completion <= 45 && Reading > 45 && Participation > 45 && Assesment <= 45)
            {
                M1 = Math.Min(MCompletion, MAssesment);
                M2 = Math.Min(MReading, MParticipation);
                ///*
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
                //*/
                /*
                if (M2 > M1)
                {
                    O1 = M2;
                    O2 = 0;
                }
                else
                {
                    O1 = 0;
                    O2 = M1;
                }
                */
            }

            //0 1 1 1
            if (Completion <= 45 && Reading > 45 && Participation > 45 && Assesment > 45)
            {
                M1 = MCompletion;
                M2 = Math.Min(Math.Min(MReading, MParticipation), MAssesment);
                ///*
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
                //*/
                /*
                if (M2 > M1)
                {
                    O1 = M2;
                    O2 = 0;
                }
                else
                {
                    O1 = 0;
                    O2 = M1;
                }
                */
            }

            //1 0 0 0
            if (Completion > 45 && Reading <= 45 && Participation <= 45 && Assesment <= 45)
            {
                M1 = Math.Min(Math.Min(MReading, MParticipation), MAssesment);
                M2 = MCompletion;
                ///*
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
                //*/
                /*
                if (M2 > M1)
                {
                    O1 = M2;
                    O2 = 0;
                }
                else
                {
                    O1 = 0;
                    O2 = M1;
                }
                */
            }

            //1 0 0 1
            if (Completion > 45 && Reading <= 45 && Participation <= 45 && Assesment > 45)
            {
                M1 = Math.Min(MReading,MParticipation);
                M2 = Math.Min(MCompletion, MAssesment);
                ///*
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
                //*/
                /*
                if (M2 > M1)
                {
                    O1 = M2;
                    O2 = 0;
                }
                else
                {
                    O1 = 0;
                    O2 = M1;
                }
                */
            }

            //1 0 1 0
            if (Completion > 45 && Reading <= 45 && Participation > 45 && Assesment <= 45)
            {
                M1 = Math.Min(MReading, MAssesment);
                M2 = Math.Min(MCompletion, MParticipation);
                ///*
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
                //*/
                /*
                if (M2 > M1)
                {
                    O1 = M2;
                    O2 = 0;
                }
                else
                {
                    O1 = 0;
                    O2 = M1;
                }
                */
            }

            //1 0 1 1
            if (Completion > 45 && Reading <= 45 && Participation > 45 && Assesment > 45)
            {
                M1 = MReading;
                M2 = Math.Min(Math.Min(MCompletion, MParticipation), MAssesment);
                ///*
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
                //*/
                /*
                if (M2 > M1)
                {
                    O1 = M2;
                    O2 = 0;
                }
                else
                {
                    O1 = 0;
                    O2 = M1;
                }
                */
            }

            //1 1 0 0
            if (Completion > 45 && Reading > 45 && Participation <= 45 && Assesment <= 45)
            {
                M1 = Math.Min(MParticipation, MAssesment);
                M2 = Math.Min(MCompletion, MReading);
                ///*
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
                //*/
                /*
                if (M2 > M1)
                {
                    O1 = M2;
                    O2 = 0;
                }
                else
                {
                    O1 = 0;
                    O2 = M1;
                }
                */
            }

            //1 1 0 1
            if (Completion > 45 && Reading > 45 && Participation <= 45 && Assesment > 45)
            {
                M1 = MParticipation;
                M2 = Math.Min(Math.Min(MCompletion, MReading),MAssesment);
                ///*
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
                //*/
                /*
                if (M2 > M1)
                {
                    O1 = M2;
                    O2 = 0;
                }
                else
                {
                    O1 = 0;
                    O2 = M1;
                }
                */
            }

            //1 1 1 0
            if (Completion > 45 && Reading > 45 && Participation > 45 && Assesment <= 45)
            {
                M1 = MAssesment;
                M2 = Math.Min(Math.Min(MCompletion, MReading), MParticipation);
                ///*
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
                //*/
                /*
                if (M2 > M1)
                {
                    O1 = M2;
                    O2 = 0;
                }
                else
                {
                    O1 = 0;
                    O2 = M1;
                }
                */
            }

            //1 1 1 1
            if (Completion > 45 && Reading > 45 && Participation > 45 && Assesment > 45)
            {
                O1 = 0;
                O2 = Math.Max(Math.Min(MCompletion, MReading), Math.Min(MParticipation, MAssesment));
                //O2 = (Math.Min(MCompletion, MReading)+ Math.Min(MParticipation, MAssesment))/2;
                //O2 = (MCompletion + MReading + MParticipation + MAssesment) / 4;
            }

            if (O1>0)
            {                
                Centroid = 0;
                //Centroid = 22.5;
                Delta = 18.5;
                Value = Centroid + Math.Sqrt(-2*Math.Pow(Delta,2)*Math.Log(O1));
                //Console.WriteLine(String.Format("Final Result: {0:F2}", Value));
                //Console.WriteLine(String.Format("Overal M: {0:F2}", O1));
                //double a, b;
                //a = Value;
                //b = 45;
                //// Declare the function we want to integrate
                //Func<double, double> f = (x) => Math.Pow(Math.E, (-Math.Pow((x - Centroid), 2) / (2 * Math.Pow(Delta, 2))));
                //Result = (100 - Value) * O1 + RombergMethod.Integrate(f, a, b);                                                       

                //COG
                //Value = 45 - (45 * O1);//y=ax+b => y=(45-x)/45
                Result = (O1 * Value) / O1;                
            }            
            else if(O2>0)
            {
                Delta = 18.5;
                if ((Completion+Reading+Participation+Assesment)>=260)
                {
                    Centroid = 100;
                    Value = Centroid - Math.Sqrt(-2 * Math.Pow(Delta, 2) * Math.Log(O2));
                }
                else
                {
                    Centroid = 20;
                    Value = Centroid + Math.Sqrt(-2 * Math.Pow(Delta, 2) * Math.Log(O2));
                }
                
                //Console.WriteLine(String.Format("Final Result: {0:F2}", Value));
                //Console.WriteLine(String.Format("Overal M: {0:F2}", O2));
                // double a, b;
                //a = 45;
                //b = Value;
                //// Declare the function we want to integrate
                //Func<double, double> f = (x) => Math.Pow(Math.E, (-Math.Pow((x - Centroid), 2) / (2 * Math.Pow(Delta, 2))));
                //Result = (100-Value) * O2 + RombergMethod.Integrate(f, a, b);                                

                //COG
                //Value = (O2 * 55) + 45;//y=ax+b => y=(x-45)/55
                Result = (O2 * Value) / O2;                                
            }
            else if(O1==0 && O2==0 )
            {
                Result = 45;
            }
        }

        public static void Classification()
        {
            if (Result <= 45)
            {
                Output = "Retake";
            }
            else if (Result > 45)
            {
                Output = "Passed";
            }
        }

        public static void CalcAll()
        {
            CompletionCalc();
            ReadingCalc();
            ParticipationCalc();
            AssesmentCalc();
            ResultCalc();
            Classification();
        }

        public static void ShowResult()
        {
            CalcAll();
            Console.WriteLine("Completion:" + Completion);
            Console.WriteLine("Reading:" + Reading);
            Console.WriteLine("Participation:" + Participation);
            Console.WriteLine("Assesment:" + Assesment);
            Console.WriteLine(String.Format("Result: {0:F2}", Result));
            Console.WriteLine("Decision: "+Output);
        }

        static void Main(string[] args)
        {
            /*
            Completion = 34.3;
            Reading = 58.4;
            Participation = 73;
            Assesment = 2.9;
            */
            /*
            Completion = 29.27;
            Reading = 3;
            Participation = 63.2;
            Assesment = 48;
            */
            ///*
            Completion =49.35;
            Reading = 83.3;
            Participation = 63.2;
            Assesment = 48;
            //*/
            ShowResult();
            Console.ReadKey();
        }
    }
}
