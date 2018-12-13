using System;
using System.Threading.Tasks;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using System.IO;
using System.Collections.Generic;

namespace Bot_Application1.Dialogs
{
    [Serializable]
    public class RootDialog : IDialog<object>
        
    {
        public Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);
            return Task.CompletedTask;
        }

        List<int> kList = new List<int>();
        List<int> a10 = new List<int>();
        List<int> a20 = new List<int>();
        List<int> a30 = new List<int>();
        List<int> a40 = new List<int>();
        List<int> a50 = new List<int>();
        List<int> a60 = new List<int>();
        List<int> a70 = new List<int>();
        List<int> a80 = new List<int>();
        List<int> a90 = new List<int>();
        
        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<object> result)
        {
            var activity = await result as Activity;
            int k = 4;
            
            Console.WriteLine("\nCapacity: {0}", kList.Capacity);
            kList.Add(0);
            k = kList[0];

            string a00 = "|_a1_|_a2_|_a3_|\n", a1001 = "|_b1_|_b2_|_b3_|\n", a2001 = "|_c1_|_c2_|_c3_|\n", f3 = "Привет, это бот крестики-нолики. Ты можешь сразиться со мной, но ты навряд ли сможешь меня обыграть, т.к. я использую новейшие технологии и предугадываю твои шаги заранее.\n", f4 = "Правила:\n", f5 = "1)у вас есть доска 3 на 3\n", f6 = "2)Ввод производится как в морском бое или как в шахмотах. Клетки пронумерованны в строку:a,b,c. И в столбцах: 1,2,3\n", f7 = "3)Пример того, если вы хотите поставить крестик на первую клетку, то вводите боту следующее: a1\n ", f8 = "4)Чтобы закончить, напишите 'заново' или 'new'";
            
            if (k == 0)
            {
                await context.PostAsync($"{f3}\n{f4}\n{f5}\n{f6}\n{f7}\n{f8}\n");
                await context.PostAsync($"{a00}\n {a1001}\n {a2001}\nВведите номер клетки");
                    
                k = 1;
                kList[0] = 1;
                
            }
            else if (k == 1)
            {
                //a1...с3 это из файлов
                //а01...а09 это из ввода
                int a1 = 3, a2 = 3, a3 = 3, b1 = 3, b2 = 3, b3 = 3, c1 = 3, c2 = 3, c3 = 3;
                int a01 = 3, a02 = 3, a03 = 3, a04 = 3, a05 = 3, a06 = 3, a07 = 3, a08 = 3, a09 = 3;
                List<int> desk = new List<int>();
                Console.WriteLine("\nCapacity: {0}", desk.Capacity);

                a10.Add(0);
                a20.Add(0);
                a30.Add(0);
                a40.Add(0);
                a50.Add(0);
                a60.Add(0);
                a70.Add(0);
                a80.Add(0);
                a90.Add(0);

                a1 = a10[0];
                a2 = a20[0];
                a3 = a30[0];
                b1 = a40[0];
                b2 = a50[0];
                b3 = a60[0];
                c1 = a70[0];
                c2 = a80[0];
                c3 = a90[0];

               
                //r - это определяет не занята ли клетка
                //считываем из введенного
                int r = 0;
                r = 0;
                if (activity.Text.ToLower() == "a1" || activity.Text.ToLower() == "а1")
                {
                    a01 = 1;
                    if (a1 != 0)
                    {
                        await context.PostAsync($"Вы не можете поставить крестик на занятую клетку");
                    }
                    else
                    {
                        r = 1;
                        a1 = 1;
                    }
                }
                
                else if(activity.Text.ToLower() == "заново" || activity.Text.ToLower() == "new")
                {
                    await context.PostAsync($"При следующем вводе сообщения вам будет предложенно сыграть в игру с начала");
                    kList[0] = 0;
                    a10[0] = 0;
                    a20[0] = 0;
                    a30[0] = 0;
                    a40[0] = 0;
                    a50[0] = 0;
                    a60[0] = 0;
                    a70[0] = 0;
                    a80[0] = 0;
                    a90[0] = 0;

                }
                    
                else if (activity.Text.ToLower() == "a2" || activity.Text.ToLower() == "а2")
                {
                    a02 = 1;
                    if (a2 != 0)
                    {
                        await context.PostAsync($"Вы не можете поставить крестик на занятую клетку");
                    }
                    else
                    {
                        r = 1;
                        a2 = 1;
                    }
                }
                else if (activity.Text.ToLower() == "a3" || activity.Text.ToLower() == "а3")
                {
                    a03 = 1;
                    if (a3 != 0)
                    {
                        await context.PostAsync($"Вы не можете поставить крестик на занятую клетку");
                    }
                    else
                    {
                        r = 1;
                        a3 = 1;
                    }
                }
                else if (activity.Text.ToLower() == "b1" || activity.Text.ToLower() == "в1" || activity.Text.ToLower() == "б1")
                {
                    a04 = 1;
                    if (b1 != 0)
                    {
                        await context.PostAsync($"Вы не можете поставить крестик на занятую клетку");
                    }
                    else
                    {
                        r = 1;
                        b1 = 1;
                    }
                }
                else if (activity.Text.ToLower() == "b2" || activity.Text.ToLower() == "в2" || activity.Text.ToLower() == "б2")
                {
                    a05 = 1;
                    if (b2 != 0)
                    {
                        await context.PostAsync($"Вы не можете поставить крестик на занятую клетку");
                    }
                    else
                    {
                        r = 1;
                        b2 = 1;
                    }
                }
                else if (activity.Text.ToLower() == "b3" || activity.Text.ToLower() == "в3" || activity.Text.ToLower() == "б3")
                {
                    a06 = 1;
                    if (b3 != 0)
                    {
                        await context.PostAsync($"Вы не можете поставить крестик на занятую клетку");
                    }
                    else
                    {
                        r = 1;
                        b3 = 1;
                    }
                }
                else if (activity.Text.ToLower() == "c1" || activity.Text.ToLower() == "с1")
                {
                    a07 = 1;
                    if (c1 != 0)
                    {
                        await context.PostAsync($"Вы не можете поставить крестик на занятую клетку");
                    }
                    else
                    {
                        r = 1;
                        c1 = 1;
                    }
                }
                else if (activity.Text.ToLower() == "c2" || activity.Text.ToLower() == "с2")
                {
                    a08 = 1;
                    if (c2 != 0)
                    {
                        await context.PostAsync($"Вы не можете поставить крестик на занятую клетку");
                    }
                    else
                    {
                        r = 1;
                        c2 = 1;
                    }
                }
                else if (activity.Text.ToLower() == "c3" || activity.Text.ToLower() == "с3")
                {
                    a09 = 1;
                    if (c3 != 0)
                    {
                        await context.PostAsync($"Вы не можете поставить крестик на занятую клетку");
                    }
                    else
                    {
                        r = 1;
                        c3 = 1;
                    }
                }
                else
                {
                    await context.PostAsync($"Я не могу тебя понять");
                    r = 0;
                }
                if (r == 1)
                {
                    int bot = -1;
                   
                    //если user ходит в угол
                    if (a1 == 1 || a3 == 1 || c1 == 1 || c3 == 1)
                    {
                        if (a1 == 1 && a3 == 1 && a2 == 0)
                        {
                            a2 = 2;
                            bot = 2;
                        }
                        else if (a1 == 1 && c1 == 1 && b1 == 0)
                        {
                            b1 = 0;
                            bot = 4;
                        }
                        else if (c3 == 1 && c1 == 1 && c2 == 0)
                        {
                            c2 = 0;
                            bot = 8;
                        }
                        else if (a3 == 1 && c3 == 1 && b3 == 0)
                        {
                            b3 = 2;
                            bot = 6;
                        }
                        else
                        {
                            if (b2 == 0)
                            {
                                b2 = 2;
                                bot = 5;
                            }
                            else if ((b2 == 2 && a1 == 1 && c3 == 1 && c2 == 0) || (a3 == 1 && b2 == 2 && c1 == 1 && c2 == 0))
                            {
                                c2 = 2;
                                bot = 8;
                            }
                            else if (((a3 == 1 && a2 == 1) || (c1 == 1 && b1 == 1)) && a1 == 0)
                            {
                                a1 = 2;
                                bot = 1;
                            }
                            else if (((a1 == 1 && a2 == 1) || (c3 == 1 && b3 == 1)) && a3 == 0)
                            {
                                a3 = 2;
                                bot = 3;
                            }
                            else if (((c3 == 1 && c2 == 1) || (a1 == 1 && b1 == 1)) && c1 == 0)
                            {
                                c1 = 2;
                                bot = 7;
                            }
                            else if (((c1 == 1 && c2 == 1) || (a3 == 1 && b3 == 1)) && c3 == 0)
                            {
                                c3 = 2;
                                bot = 9;
                            }
                            else if (c2 == 2 && a2 == 1 && a1 == 0)
                            {
                                a1 = 2;
                                bot = 1;
                            }
                            else if (c2 == 2 && a2 == 1 && c1 == 0)
                            {
                                c1 = 2;
                                bot = 7;
                            }
                            else if (a3 == 1 && c3 == 1 && b3 == 0)
                            {
                                b3 = 2;
                                bot = 6;
                            }
                            else if (a1 == 1 && c1 == 1 && b1 == 0)
                            {
                                b1 = 2;
                                bot = 4;
                            }
                            else if (a1 == 1 && a3 == 1 && a2 == 0)
                            {
                                a2 = 2;
                                bot = 2;
                            }

                            else if (c1 == 1 && c3 == 1 && c2 == 0)
                            {
                                c2 = 2;
                                bot = 8;
                            }
                            //победа
                            else if (c2 == 2 && b2 == 2 && a2 == 0)
                            {
                                a2 = 2;
                                bot = 2;
                            }
                            else if (c1 == 2 && a3 == 0)
                            {
                                a3 = 2;
                                bot = 3;
                            }
                            //победа
                            else if (a1 == 2 && c3 == 0)
                            {
                                c3 = 2;
                                bot = 9;
                            }
                            //победа
                            else if (a3 == 2 && c1 == 0)
                            {
                                c1 = 2;
                                bot = 7;
                            }
                            
                            else
                            {
                                int i = 0;
                                while (i == 0)
                                {
                                    bot = Rand.rand.Next(1, 10);
                                    if ((bot == 1 && (a1 != 0 || a01 != 0)) || (bot == 2 && (a2 != 0 || a02 != 0)) || (bot == 3 && (a3 != 0 || a03 != 0)) || (bot == 4 && (b1 != 0 || a04 != 0)) || (bot == 5 && (b2 != 0 || a05 != 0)) || (bot == 6 && (b3 != 0 || a06 != 0)) || (bot == 7 && (c1 != 0 || a07 != 0)) || (bot == 8 && (c2 != 0 || a08 != 0)) || (bot == 9 && (c3 != 0 || a09 != 0)))
                                    {
                                        i = 0;
                                    }
                                    else
                                    {
                                        i = 1;
                                    }
                                }
                            }
                            
                        }
                    }

                    //если user ходит в b2
                    else if (b2 == 1)
                    {
                        if (a1 == 2 && c1 == 2 && b1 == 0)
                        {
                            b1 = 2;
                            bot = 4;
                        }

                        else if (a1 == 2 && a3 == 2 && a2 == 0)
                        {
                            a2 = 2;
                            bot = 2;
                        }
                        else if (a3 == 2 && c3 == 2 && b3 == 0)
                        {
                            b3 = 2;
                            bot = 6;
                        }
                        else if (c1 == 2 && c3 == 2 && c2 == 0)
                        {
                            c2 = 2;
                            bot = 8;
                        }
                        else if (a3 == 1 && b2 == 1 && c1 == 0)
                        {
                            c1 = 2;
                            bot = 7;
                        }
                        else if (a2 == 1 && a2 == 1 && c2 == 0)
                        {
                            c2 = 2;
                            bot = 8;
                        }
                        else if (b1 == 1 && b2 == 1 && b3 == 0)
                        {
                            b3 = 2;
                            bot = 6;
                        }
                        else if (c1 == 1 && b2 == 1 && a3 == 0)
                        {
                            a3 = 2;
                            bot = 3;
                        }
                        else if (b2 == 1 && b3 == 1 && b1 == 0)
                        {
                            b1 = 2;
                            bot = 4;
                        }
                        else if (a3 == 1 && c3 == 1 && b3 == 0)
                        {
                            b3 = 2;
                            bot = 6;
                        }
                        else if (c1 == 1 && c3 == 1 && c2 == 0)
                        {
                            c3 = 2;
                            bot = 9;
                        }
                        else if (c1 == 1 && c2 == 1 && c3 == 0)
                        {
                            c3 = 2;
                            bot = 9;
                        }
                        else if (c3 == 1 && c2 == 1 && c1 == 0)
                        {
                            c1 = 2;
                            bot = 7;
                        }
                        else if (a3 == 1 && b3 == 1 && c3 == 0)
                        {
                            c3 = 2;
                            bot = 9;
                        }
                        else if (c3 == 1 && b3 == 1 && a3 == 0)
                        {
                            a3 = 2;
                            bot = 3;
                        }
                        else {
                            if (a1 == 0)
                            {
                                a1 = 2;
                                bot = 1;
                            }
                            else if (a1 == 2 && a2 == 0 && c2 == 0 && b1 == 0 && b3 == 0 && a3 == 1 && c1 == 0)
                            {
                                c1 = 2;
                                bot = 7;
                            }
                            else if (a1 == 2 && a2 == 0 && c2 == 0 && b1 == 0 && b3 == 0 && c1 == 1 && a3 == 0)
                            {
                                a3 = 2;
                                bot = 3;
                            }
                            else if (a1 == 2 && a2 == 0 && c2 == 0 && b1 == 0 && b3 == 0 && c3 == 1 && a3 == 0)
                            {
                                a3 = 2;
                                bot = 3;
                            }
                            //победа
                            else if (a1 == 2 && a2 == 0 && c2 == 0 && b1 == 0 && b3 == 0 && c3 == 1 && a3 == 2 && a2 == 0)
                            {
                                a2 = 0;
                                bot = 2;
                            }
                            else if (a1 == 2 && a2 == 0 && c2 == 0 && b1 == 0 && b3 == 0 && c3 == 1 && a3 == 2 && a2 == 1 && c2 == 0)
                            {
                                c2 = 2;
                                bot = 8;
                            }
                            
                            else
                            {
                                int i = 0;
                                while (i == 0)
                                {
                                    bot = Rand.rand.Next(1, 10);
                                    if ((bot == 1 && (a1 != 0 || a01 != 0)) || (bot == 2 && (a2 != 0 || a02 != 0)) || (bot == 3 && (a3 != 0 || a03 != 0)) || (bot == 4 && (b1 != 0 || a04 != 0)) || (bot == 5 && (b2 != 0 || a05 != 0)) || (bot == 6 && (b3 != 0 || a06 != 0)) || (bot == 7 && (c1 != 0 || a07 != 0)) || (bot == 8 && (c2 != 0 || a08 != 0)) || (bot == 9 && (c3 != 0 || a09 != 0)))
                                    {
                                        i = 0;
                                    }
                                    else
                                    {
                                        i = 1;
                                    }
                                }
                                
                            }
                        
                        }
                    }

                    //если в бок
                    else if(a2 == 1 || b3 == 1 || c2 == 1 || b1 == 1)
                    {
                        if (a1 == 2 && c1 == 2 && b1 == 0)
                        {
                            b1 = 2;
                            bot = 4;
                        }

                        else if (a1 == 2 && a3 == 2 && a2 == 0)
                        {
                            a2 = 2;
                            bot = 2;
                        }
                        else if (a3 == 2 && c3 == 2 && b3 == 0)
                        {
                            b3 = 2;
                            bot = 6;
                        }
                        else if (c1 == 2 && c3 == 2 && c2 == 0)
                        {
                            c2 = 2;
                            bot = 8;
                        }
                        else if (a3 == 1 && b2 == 1 && c1 == 0)
                        {
                            c1 = 2;
                            bot = 7;
                        }
                        else if (a2 == 1 && a2 == 1 && c2 == 0)
                        {
                            c2 = 2;
                            bot = 8;
                        }
                        else if (b1 == 1 && b2 == 1 && b3 == 0)
                        {
                            b3 = 2;
                            bot = 6;
                        }
                        else if (c1 == 1 && b2 == 1 && a3 == 0)
                        {
                            a3 = 2;
                            bot = 3;
                        }
                        else if (b2 == 1 && b3 == 1 && b1 == 0)
                        {
                            b1 = 2;
                            bot = 4;
                        }
                        else if (a3 == 1 && c3 == 1 && b3 == 0)
                        {
                            b3 = 2;
                            bot = 6;
                        }
                        else if (c1 == 1 && c3 == 1 && c2 == 0)
                        {
                            c3 = 2;
                            bot = 9;
                        }
                        else if (c1 == 1 && c2 == 1 && c3 == 0)
                        {
                            c3 = 2;
                            bot = 9;
                        }
                        else if (c3 == 1 && c2 == 1 && c1 == 0)
                        {
                            c1 = 2;
                            bot = 7;
                        }
                        else if (a3 == 1 && b3 == 1 && c3 == 0)
                        {
                            c3 = 2;
                            bot = 9;
                        }
                        else if (c3 == 1 && b3 == 1 && a3 == 0)
                        {
                            a3 = 2;
                            bot = 3;
                        }
                        else
                        {
                            if (b2 == 0)
                            {
                                b2 = 2;
                                bot = 5;
                            }
                            else if (b2 == 2 && a2 == 0 && c2 != 1)
                            {
                                a2 = 2;
                                bot = 2;
                            }
                            else if (b2 == 2 && b1 == 0 && b3 != 1)
                            {
                                b1 = 2;
                                bot = 4;
                            }
                            else if (a1 == 0 && b2 == 2 && c3 != 1)
                            {
                                a1 = 2;
                                bot = 1;
                            }
                            else if (a3 == 0 && b2 == 2 && c1 != 1)
                            {
                                a3 = 2;
                                bot = 3;
                            }
                            else
                            {
                                int i = 0;
                                while (i == 0)
                                {
                                    bot = Rand.rand.Next(1, 10);
                                    if ((bot == 1 && (a1 != 0 || a01 != 0)) || (bot == 2 && (a2 != 0 || a02 != 0)) || (bot == 3 && (a3 != 0 || a03 != 0)) || (bot == 4 && (b1 != 0 || a04 != 0)) || (bot == 5 && (b2 != 0 || a05 != 0)) || (bot == 6 && (b3 != 0 || a06 != 0)) || (bot == 7 && (c1 != 0 || a07 != 0)) || (bot == 8 && (c2 != 0 || a08 != 0)) || (bot == 9 && (c3 != 0 || a09 != 0)))
                                    {
                                        i = 0;
                                    }
                                    else
                                    {
                                        i = 1;
                                    }
                                }
                            }
                            
                        }
                    }
                    /*
                    if(bot != 1 || bot != 2 || bot != 3 || bot != 4 || bot != 5 || bot != 6 || bot != 7 || bot != 8 || bot != 9 )
                    {
                        int i = 0;
                        while (i == 0)
                        {
                            bot = Rand.rand.Next(1, 10);
                            if ((bot == 1 && (a1 != 0 || a01 != 0)) || (bot == 2 && (a2 != 0 || a02 != 0)) || (bot == 3 && (a3 != 0 || a03 != 0)) || (bot == 4 && (b1 != 0 || a04 != 0)) || (bot == 5 && (b2 != 0 || a05 != 0)) || (bot == 6 && (b3 != 0 || a06 != 0)) || (bot == 7 && (c1 != 0 || a07 != 0)) || (bot == 8 && (c2 != 0 || a08 != 0)) || (bot == 9 && (c3 != 0 || a09 != 0)))
                            {
                                i = 0;
                            }
                            else
                            {
                                i = 1;
                            }
                        }
                    }
                    */
                    string y = " ", y1 = " ", y2 = " ", y3 = "-1-2-3-\n", y4 = " ", y5 = " ", y6 = " ", y7 = " ", y8 = " ", y9 = " ";
                    
                    //тут вывод по каждой клетке
                    if (a1 == 1 || a01 == 1)
                    {
                        y += "|x";

                        a10[0] = 1;

                    }
                    else if (bot == 1 || a1 == 2)
                    {
                        
                        y += "|o";
                        
                        a10[0] = 2;
                    }
                    else
                    {
                        
                        y += "|a";
                    }


                    if (a2 == 1 || a02 == 1)
                    {
                        y += "|x|";
                        a20[0] = 1;
                    }
                    else if (bot == 2 || a2 == 2)
                    {
                        y += "|o|";
                        a20[0] = 2;
                    }
                    else
                    {
                        y += "|a|";
                    }



                    if (a3 == 1 || a03 == 1)
                    {
                        
                        y += "x|\n";
                        a30[0] = 1;
                    }
                    else if (bot == 3 || a3 == 2)
                    {
                        
                        y += "o|\n";
                        a30[0] = 2;
                    }
                    else
                    {
                        
                        y += "a|\n";
                    }


                    if (b1 == 1 || a04 == 1)
                    {
                        
                        y1 += "|x";
                        a40[0] = 1;
                    }
                    else if (bot == 4||b1 == 2)
                    {
                        
                        y1 += "|o";
                        a40[0] = 2;
                    }
                    else
                    {
                        
                        y1 += "|b";
                    }


                    if (b2 == 1 || a05 == 1)
                    {
                        
                        y1 += "|x|";
                        a50[0] = 1;
                    }
                    else if (bot == 5||b2 == 2)
                    {
                        
                        y1 += "|o|";
                        a50[0] = 2;
                    }
                    else
                    {
                        
                        y1 += "|b|";
                    }



                    if (b3 == 1 || a06 == 1)
                    {
                       
                        y1 += "x|\n";
                        a60[0] = 1;
                    }
                    else if (bot == 6||b3 == 2)
                    {
                        
                        y1 += "o|\n";
                        a60[0] = 2;
                    }
                    else
                    {
                       
                        y1 += "b|\n";
                    }


                    if (c1 == 1 || a07 == 1)
                    {
                        
                        y2 += "|x";
                        a70[0] = 1;
                    }
                    else if (bot == 7||c1 == 2)
                    {
                        
                        y2 += "|o";
                        a70[0] = 2;
                    }
                    else
                    {
                        
                        y2 += "|c";
                    }


                    if (c2 == 1 || a08 == 1)
                    {
                        
                        y2 += "|x|";
                        a80[0] = 1;
                    }
                    else if (bot == 8||c2 == 2)
                    {
                        
                        y2 += "|o|";
                        a80[0] = 2;
                    }
                    else
                    {
                        
                        y2 += "|c|";
                    }


                    if (c3 == 1 || a09 == 1)
                    {
                        
                        y2 += "x|\n";
                        a90[0] = 1;
                    }
                    else if (bot == 9||c3 == 2)
                    {
                        
                        y2 += "o|\n";
                        a90[0] = 2;
                    }
                    else
                    {
                        
                        y2 += "c|\n";
                    }
                    await context.PostAsync($"{y3}\n{y}\n{y1}\n{y2}\n");
                    

                    //победа или ничья
                    if ((a1 == 1 && b2 == 1 && c3 == 1) || (a3 == 1 && b2 == 1 && c1 == 1) || (a2 == 1 && b2 == 1 && c2 == 1) || (a1 == 1 && a2 == 1 && a3 == 1) || (a1 == 1 && b1 == 1 && c1 == 1) || (a3 == 1 && b3 == 1 && c3 == 1) || (b1 == 1 && b2 == 1 && b3 == 1) || (c1 == 1 && c2 == 1 && c3 == 1))
                    {
                        kList[0] = 0;
                        a10[0] = 0;
                        a20[0] = 0;
                        a30[0] = 0;
                        a40[0] = 0;
                        a50[0] = 0;
                        a60[0] = 0;
                        a70[0] = 0;
                        a80[0] = 0;
                        a90[0] = 0;
                        await context.PostAsync($"Поздравляю, ты выиграл, я до глубины своих процессоров поражен");
                    }
                    else if((a1 == 2 && b2 == 2 && c3 == 2) || (a3 == 2 && b2 == 2 && c1 == 2) || (a2 == 2 && b2 == 2 && c2 == 2) || (a1 == 2 && a2 == 2 && a3 == 2) || (a1 == 2 && b1 == 2 && c1 == 2) || (a3 == 2 && b3 == 2 && c3 == 2) || (b1 == 2 && b2 == 2 && b3 == 2) || (c1 == 2 && c2 == 2 && c3 == 2))
                    {
                        kList[0] = 0;
                        a10[0] = 0;
                        a20[0] = 0;
                        a30[0] = 0;
                        a40[0] = 0;
                        a50[0] = 0;
                        a60[0] = 0;
                        a70[0] = 0;
                        a80[0] = 0;
                        a90[0] = 0;
                        await context.PostAsync($"Бот победил, хехехе, как я и говорил");
                    }
                    else if (a1 != 0 && a2 != 0 && a3 != 0 && b1!= 0 && b2 != 0 && b3 !=0 && c1 != 0 && c2 != 0 && c3 != 0)
                    {
                        kList[0] = 0;
                        a10[0] = 0;
                        a20[0] = 0;
                        a30[0] = 0;
                        a40[0] = 0;
                        a50[0] = 0;
                        a60[0] = 0;
                        a70[0] = 0;
                        a80[0] = 0;
                        a90[0] = 0;
                        await context.PostAsync($"Ничья");
                    }
                }
               
                context.Wait(MessageReceivedAsync);
            }
        }
    }
}