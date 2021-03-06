﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace trpo_lab_1_2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        HashSet<char> setOfSigns = new HashSet<char>() { '+', '-', '/', '*' };
        HashSet<char> setOfDif = new HashSet<char>() { '<', '>'};
        HashSet<string> setOfReservedWords = new HashSet<string> { "if", "else", "then", "and", "or", "while", "repeat", "do", "until" };
        List<string> answer = new List<string>();
       
        private void btnGoAutomat_Click(object sender, EventArgs e)
        {
            runAutomat(txbxExpression.Text);
            txbxAnswer.Text = "";            
            foreach (string item in answer)
            {               
                txbxAnswer.Text += item + Environment.NewLine;
            }
            answer.Clear();
        }
        enum State
        {
            Begin,Integer,Real,Identificate,Arifmetic, Assignment, Comparing,Equals,Space,Any
        }
        string[] name = { "Begin", "Целое число", "Вещественное число", "Идентификатор", "Арифметическая операция", 
                            "Оператор присваивания", "Оператор сравнения", "Равенство","Разделитель", "Неизвестный символ" };
        public int indexChar(char ch)
        {

            if (Char.IsDigit(ch))
                return 0;
            else
                if (Char.IsLetter(ch))
                    return 1;
                else
                    if (ch == '.')
                        return 2;
                    else
                        if (setOfDif.Contains(ch))
                            return 3;
                        else
                            if (setOfSigns.Contains(ch))
                                return 4;
                            else
                                if (ch == ':')
                                    return 5;
                                else
                                    if (ch == '=')
                                        return 6;
                                    else
                                        if (ch == ' ')
                                            return 7;
                                        
                                
           return 8;
        }
        //табличный автомат
        State[,] tableAutomat = new State[,]
        {
            {State.Integer,State.Identificate,State.Any,State.Comparing,State.Arifmetic,State.Any,State.Equals,State.Space,State.Any},//Begin
            {State.Integer,State.Begin,State.Real,State.Begin,State.Begin,State.Begin,State.Begin,State.Space,State.Any},//int
            {State.Real,State.Begin,State.Begin,State.Begin,State.Begin,State.Begin,State.Begin,State.Space,State.Any},//real
            {State.Identificate,State.Identificate,State.Begin,State.Begin,State.Begin,State.Assignment,State.Begin,State.Space,State.Any},//id
            {State.Begin,State.Begin,State.Begin,State.Begin,State.Begin,State.Begin,State.Begin,State.Space,State.Any},//arifm
            {State.Begin,State.Begin,State.Begin,State.Begin,State.Begin,State.Assignment,State.Assignment,State.Space,State.Any},//assignment
            {State.Begin,State.Begin,State.Begin,State.Begin,State.Begin,State.Begin,State.Begin,State.Space,State.Any},//compare
            {State.Begin,State.Begin,State.Begin,State.Begin,State.Begin,State.Begin,State.Begin,State.Space,State.Any},//equals
            {State.Begin,State.Begin,State.Begin,State.Begin,State.Begin,State.Begin,State.Begin,State.Space,State.Any},//space
            {State.Begin,State.Begin,State.Begin,State.Begin,State.Begin,State.Begin,State.Begin,State.Space,State.Any}//any
        };

        void runAutomat(string s)
        {
            State pred= State.Begin;
            State curr = pred;
            int i = 0;
            while (i<s.Length)
            {
                //откуда копировать лексему
                int from = i;
                curr = tableAutomat[(int)pred, indexChar(s[i])];
                do
                {                                
                    pred = curr;
                    i++;
                    if (i == s.Length)                    
                        break;                    
                    curr = tableAutomat[(int)pred, indexChar(s[i])];                                     
                }
                while (curr == pred || curr == State.Real);
                //если служебное слово
                if(pred==State.Identificate && setOfReservedWords.Contains(s.Substring(from,i-from)))                  
                        answer.Add(s.Substring(from, i - from) + "\t служебное слово");
                else
                    if(pred!=State.Space)//пробелы не печатаем
                        answer.Add(s.Substring(from, i - from) + "\t " + name[(int)pred]);
                
                pred = curr;
            }
        }

        private void btnClearExpr_Click(object sender, EventArgs e)
        {
            txbxExpression.Text = "";
            txbxAnswer.Text="";

        }
    }
}
