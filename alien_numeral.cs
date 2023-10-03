using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mail;
using System.Threading.Tasks;

namespace test_neolink_bpo
{
    public class alien_numeral
    {

        public enum AlienNumerals
        {
            A = 1,
            B = 5,
            Z = 10,
            L = 50,
            C = 100,
            D = 500,
            R = 1000
        }
        public static void convert_alien_numeral(string s)
        {
            try
            {
                if (!(s.Contains("AAAA") ||
                s.Contains("ABB")  ||
                s.Contains("ZZZZ") ||
                s.Contains("ZLL")  ||
                s.Contains("CCCC") ||
                s.Contains("CDD")
                ))
                {
                    int enumValueInt = 0;
                    int sum = 0;

                    //เอา input มาแยกใส่ array
                    string[] text = new string['s'];

                    for (int i = 0; i < s.Length; i++)
                    {
                        char Current = s[i];
                        char Next;

                        if (s[i] == 'A')
                        {
                            //หา char ตัวถัดไป
                            Next = s.SkipWhile(x => x != Current).Skip(1).DefaultIfEmpty(s[0]).FirstOrDefault();

                            if (Next == 'B')
                            {
                                enumValueInt = (int)AlienNumerals.B - (int)AlienNumerals.A;
                                i++;

                            }
                            else if (Next == 'Z')
                            {
                                enumValueInt = (int)AlienNumerals.Z - (int)AlienNumerals.A;
                                i++;
                            }
                            //ถ้าซ้ำตัวเองหรือเป็นตัวสุดท้าย
                            else if (Next == 'A' || Next == ' ')
                            {
                                enumValueInt = (int)AlienNumerals.A;
                            }
                            else
                            {
                                throw new Exception("Please input text following conditions of Alien numeral");

                            }

                        }
                        else if (s[i] == 'Z')
                        {
                            Next = s.SkipWhile(x => x != Current).Skip(1).DefaultIfEmpty(s[0]).FirstOrDefault();

                            if (Next == 'L')
                            {
                                enumValueInt = (int)AlienNumerals.L - (int)AlienNumerals.Z;
                                i++;

                            }
                            else if (Next == 'C')
                            {
                                enumValueInt = (int)AlienNumerals.C - (int)AlienNumerals.Z;
                                i++;
                            }
                            //สามารถตามด้วย B,A ได้เพราะ Z มากกว่า B,A
                            else if (Next == 'Z' || Next == ' ' || Next == 'B' || Next == 'A')
                            {
                                enumValueInt = (int)AlienNumerals.Z;
                            }
                            else
                            {
                                throw new Exception("Please input text following conditions of Alien numeral");
                            }
                        }
                        else if (s[i] == 'C')
                        {
                            Next = s.SkipWhile(x => x != Current).Skip(1).DefaultIfEmpty(s[0]).FirstOrDefault();
                            if (Next == 'D')
                            {
                                enumValueInt = (int)AlienNumerals.D - (int)AlienNumerals.C;
                                i++;

                            }
                            else if (Next == 'R')
                            {
                                enumValueInt = (int)AlienNumerals.R - (int)AlienNumerals.C;
                                i++;
                            }

                            else
                            {
                                //C ใหญ่สุด สามารถอยู่หน้าได้ทุกตัว
                                enumValueInt = (int)AlienNumerals.C;
                            }
                        }
                        else
                        {
                            switch (s[i])
                            {

                                case 'B':
                                    enumValueInt = (int)AlienNumerals.B;
                                    break;

                                case 'L':
                                    enumValueInt = (int)AlienNumerals.L;
                                    break;

                                case 'D':
                                    enumValueInt = (int)AlienNumerals.D;
                                    break;
                                case 'R':
                                    enumValueInt = (int)AlienNumerals.R;
                                    break;
                                default:

                                    break;
                            }
                        }

                        sum += enumValueInt;

                    }


                    Console.WriteLine("Output: " + sum);
                }
                else
                {
                    throw new Exception("Please input text following conditions of Alien numeral");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
        }

    }
}