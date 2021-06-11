using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CantStopServer;

namespace PI3
{

    public partial class Form1 : Form
    {
        public int idPartida { get; set; }
        public int idTabuleiro { get; set; }
        public int IdJogador { get; set; }
        public int IdDado { get; set; }
        
        public Form1()
        {
            InitializeComponent();
        }

        public void ExibirHistorico(int id)
        {
           textBox20.Text = Jogo.ExibirHistorico(id);
        }


        public void verificarVeiz()
        {
            string linha2 = listBox1.SelectedItem.ToString();
            //Jogador jog1 = new Jogador();
           // jog1.IdJogador = Convert.ToInt32(textBox6.Text);
            string senhajogador = textBox1.Text;
            int IdJogador = Convert.ToInt32(textBox6.Text);
            if (linha2 == null)
            {

                lblERRO.Text = "Selecione a partida";
            }
            else
            {

                string[] itens = linha2.Split(',');

                int idPartida = Convert.ToInt32(itens[0]);

                string verificar = Jogo.VerificarVez(idPartida);

                if (verificar.Substring(0, 4) == "ERRO")
                {
                    lblERRO.Text = verificar;
                }
                else
                {

                    verificar = verificar.Replace("\r", "");
                    string[] dados = verificar.Split(',');
                    string Dados = dados[1].Replace("\n", "");
                    if (IdJogador.ToString() == Dados)
                    {

                        string rolar = Jogo.RolarDados(IdJogador, senhajogador);

                        if (rolar.Substring(0, 4) == "ERRO")
                        {

                            string result = Jogo.VerificarTrilhas(idPartida);
                            lblERRO.Text = result;
                            result = result.Replace("\r", "");
                            string[] linha8 = result.Split('\n');
                            string v1 = result.Substring(0, 2);
                            string v2 = result.Substring(1, 1);
                            if (v1 == "2,") Jogo.Mover(IdJogador, senhajogador, "1234", "20");
                            if (v1 == "2,") Jogo.Mover(IdJogador, senhajogador, "1324", "20");
                            if (v1 == "2,") Jogo.Mover(IdJogador, senhajogador, "1423", "20");
                            //Jogo.Parar(IdJogador, senhajogador);
                            if (v1 == "3,") Jogo.Mover(IdJogador, senhajogador, "1234", "30");
                            if (v1 == "3,") Jogo.Mover(IdJogador, senhajogador, "1324", "30");
                            if (v1 == "3,") Jogo.Mover(IdJogador, senhajogador, "1423", "30");
                            //Jogo.Parar(IdJogador, senhajogador);
                            if (v1 == "4,") Jogo.Mover(IdJogador, senhajogador, "1234", "40");
                            if (v1 == "4,") Jogo.Mover(IdJogador, senhajogador, "1324", "40");
                            if (v1 == "4,") Jogo.Mover(IdJogador, senhajogador, "1423", "40");
                            //Jogo.Parar(IdJogador, senhajogador);
                            if (v1 == "5,") Jogo.Mover(IdJogador, senhajogador, "1234", "50");
                            if (v1 == "5,") Jogo.Mover(IdJogador, senhajogador, "1324", "50");
                            if (v1 == "5,") Jogo.Mover(IdJogador, senhajogador, "1423", "50");
                            //Jogo.Parar(IdJogador, senhajogador);
                            if (v1 == "6,") Jogo.Mover(IdJogador, senhajogador, "1234", "60");
                            if (v1 == "6,") Jogo.Mover(IdJogador, senhajogador, "1324", "60");
                            if (v1 == "6,") Jogo.Mover(IdJogador, senhajogador, "1423", "60");
                            //Jogo.Parar(IdJogador, senhajogador);
                            if (v1 == "7,") Jogo.Mover(IdJogador, senhajogador, "1234", "70");
                            if (v1 == "7,") Jogo.Mover(IdJogador, senhajogador, "1324", "70");
                            if (v1 == "7,") Jogo.Mover(IdJogador, senhajogador, "1423", "70");
                            //Jogo.Parar(IdJogador, senhajogador);
                            if (v1 == "8,") Jogo.Mover(IdJogador, senhajogador, "1234", "80");
                            if (v1 == "8,") Jogo.Mover(IdJogador, senhajogador, "1324", "80");
                            if (v1 == "8,") Jogo.Mover(IdJogador, senhajogador, "1423", "80");
                            //Jogo.Parar(IdJogador, senhajogador);
                            if (v1 == "9,") Jogo.Mover(IdJogador, senhajogador, "1234", "90");
                            if (v1 == "9,") Jogo.Mover(IdJogador, senhajogador, "1324", "90");
                            if (v1 == "9,") Jogo.Mover(IdJogador, senhajogador, "1423", "90");
                            //Jogo.Parar(IdJogador, senhajogador);
                            if (v1 == "10") Jogo.Mover(IdJogador, senhajogador, "1234", "A0");
                            if (v1 == "10") Jogo.Mover(IdJogador, senhajogador, "1324", "A0");
                            if (v1 == "10") Jogo.Mover(IdJogador, senhajogador, "1423", "A0");
                            //Jogo.Parar(IdJogador, senhajogador);
                            if (v1 == "11") Jogo.Mover(IdJogador, senhajogador, "1234", "B0");
                            if (v1 == "11") Jogo.Mover(IdJogador, senhajogador, "1324", "B0");
                            if (v1 == "11") Jogo.Mover(IdJogador, senhajogador, "1423", "B0");
                            //Jogo.Parar(IdJogador, senhajogador);
                            if (v1 == "12") Jogo.Mover(IdJogador, senhajogador, "1234", "C0");
                            if (v1 == "12") Jogo.Mover(IdJogador, senhajogador, "1324", "C0");
                            if (v1 == "12") Jogo.Mover(IdJogador, senhajogador, "1423", "C0");
                            //Jogo.Parar(IdJogador, senhajogador);

                            if (v2 == "2,") Jogo.Mover(IdJogador, senhajogador, "1234", "20");
                            //Jogo.Parar(IdJogador, senhajogador);
                            if (v2 == "3,") Jogo.Mover(IdJogador, senhajogador, "1234", "30");
                            //Jogo.Parar(IdJogador, senhajogador);
                            if (v2 == "4,") Jogo.Mover(IdJogador, senhajogador, "1234", "40");
                            //Jogo.Parar(IdJogador, senhajogador);
                            if (v2 == "5,") Jogo.Mover(IdJogador, senhajogador, "1234", "50");
                            //Jogo.Parar(IdJogador, senhajogador);
                            if (v2 == "6,") Jogo.Mover(IdJogador, senhajogador, "1234", "60");
                            //Jogo.Parar(IdJogador, senhajogador);
                            if (v2 == "7,") Jogo.Mover(IdJogador, senhajogador, "1234", "70");
                            //Jogo.Parar(IdJogador, senhajogador);
                            if (v2 == "8,") Jogo.Mover(IdJogador, senhajogador, "1234", "80");
                            //Jogo.Parar(IdJogador, senhajogador);
                            if (v2 == "9,") Jogo.Mover(IdJogador, senhajogador, "1234", "90");
                            //Jogo.Parar(IdJogador, senhajogador);
                            if (v2 == "10") Jogo.Mover(IdJogador, senhajogador, "1234", "A0");
                            //Jogo.Parar(IdJogador, senhajogador);
                            if (v2 == "11") Jogo.Mover(IdJogador, senhajogador, "1234", "B0");
                            //Jogo.Parar(IdJogador, senhajogador);
                            if (v2 == "12") Jogo.Mover(IdJogador, senhajogador, "1234", "C0");
                            //Jogo.Parar(IdJogador, senhajogador);
                            //lblERRO.Text = v1.ToString();
                            //int v2 = Convert.ToInt32(linha8[1]);
                            //MessageBox.Show(result);
                            //lblERRO.Text = result;
                            //lblERRO.Text = rolar;

                            return;

                        }

                        rolar = rolar.Replace("\r", "");

                        string[] linha = rolar.Split('\n');

                        Dado dado = new Dado();
                        dado.Dado1 = Convert.ToInt32(linha[0]) - 10;
                        dado.Dado2 = Convert.ToInt32(linha[1]) - 20;
                        dado.Dado3 = Convert.ToInt32(linha[2]) - 30;
                        dado.Dado4 = Convert.ToInt32(linha[3]) - 40;

                        textBox10.Text = dado.Dado1.ToString();
                        textBox11.Text = dado.Dado2.ToString();
                        textBox12.Text = dado.Dado3.ToString();
                        textBox13.Text = dado.Dado4.ToString();

                        DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\source\repos\PI3-master\imagem\");

                        string ordem = "1234";
                        int R1 = dado.Dado1 + dado.Dado2;
                        int R2 = dado.Dado3 + dado.Dado4;
                        int R3 = dado.Dado1 + dado.Dado3;
                        int R4 = dado.Dado2 + dado.Dado4;
                        int R5 = dado.Dado1 + dado.Dado4;
                        int R6 = dado.Dado2 + dado.Dado3;
                        string v3 = R1.ToString();
                        string v4 = R2.ToString();
                        string v5 = R3.ToString();
                        string v6 = R4.ToString();
                        string v7 = R5.ToString();
                        string v8 = R6.ToString();
                        if (R1 == 10) v3 = "A"; if (R1 == 11) v3 = "B"; if (R1 == 12) v3 = "C";
                        if (R2 == 10) v4 = "A"; if (R2 == 11) v4 = "B"; if (R2 == 12) v4 = "C";
                        if (R3 == 10) v5 = "A"; if (R3 == 11) v5 = "B"; if (R3 == 12) v5 = "C";
                        if (R4 == 10) v6 = "A"; if (R4 == 11) v6 = "B"; if (R4 == 12) v6 = "C";
                        if (R5 == 10) v7 = "A"; if (R5 == 11) v7 = "B"; if (R5 == 12) v7 = "C";
                        if (R6 == 10) v8 = "A"; if (R6 == 11) v8 = "B"; if (R6 == 12) v8 = "C";
                        string linha3 = v3 + v4;
                        string linha4 = v5 + v6;
                        string linha5 = v7 + v8;
                        lblERRO.Text = Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        if (lblERRO.Text != "")
                        {
                            lblERRO.Text = Jogo.Mover(IdJogador, senhajogador, "1324", linha4);

                            if (lblERRO.Text != "")
                            {
                                lblERRO.Text = Jogo.Mover(IdJogador, senhajogador, "1423", linha5);
                            }
                        }
                        Jogo.Parar(IdJogador, senhajogador);
                        //goto Fim;

                        if (dado.Dado1 == dado.Dado2 && dado.Dado2 == dado.Dado3 && dado.Dado3 == dado.Dado4)
                        {

                            lblC2.Visible = false;
                            lblC3.Visible = false;
                            picDado1.Visible = false;
                            picDado2.Visible = false;
                            picDado3.Visible = false;
                            picDado4.Visible = false;
                            picDado5.Visible = false;
                            picDado6.Visible = false;
                            pictureBox2.Visible = false;
                            pictureBox3.Visible = false;
                            pictureBox4.Visible = false;
                            pictureBox5.Visible = false;
                            pictureBox6.Visible = false;
                            pictureBox7.Visible = false;
                            pictureBox8.Visible = false;
                            pictureBox9.Visible = false;
                            pictureBox10.Visible = false;
                            pictureBox11.Visible = false;
                            pictureBox12.Visible = false;
                            pictureBox13.Visible = false;
                            pictureBox14.Visible = false;
                            pictureBox15.Visible = false;
                            pictureBox16.Visible = false;
                            pictureBox17.Visible = false;
                            pictureBox18.Visible = false;
                            pictureBox19.Visible = false;
                            pictureBox20.Visible = false;
                            pictureBox21.Visible = false;
                            pictureBox22.Visible = false;
                            pictureBox23.Visible = false;


                            picDado1.Image = null;
                            picDado2.Image = null;
                            picDado3.Image = null;
                            picDado4.Image = null;
                            picDado5.Image = null;
                            picDado6.Image = null;
                            pictureBox2.Image = null;
                            pictureBox3.Image = null;
                            pictureBox4.Image = null;
                            pictureBox5.Image = null;
                            pictureBox6.Image = null;
                            pictureBox7.Image = null;
                            pictureBox8.Image = null;
                            pictureBox9.Image = null;
                            pictureBox10.Image = null;
                            pictureBox11.Image = null;
                            pictureBox12.Image = null;
                            pictureBox13.Image = null;
                            pictureBox14.Image = null;
                            pictureBox15.Image = null;
                            pictureBox16.Image = null;
                            pictureBox17.Image = null;
                            pictureBox18.Image = null;
                            pictureBox19.Image = null;
                            pictureBox20.Image = null;
                            pictureBox21.Image = null;
                            pictureBox22.Image = null;
                            pictureBox23.Image = null;


                            if (dado.Dado1 == 1)
                            {
                                picDado1.ImageLocation = directoryInfo + @"cara-de-morrer(1).png";
                                picDado1.Location = new Point(276, 238);
                                picDado1.Visible = true;
                                pictureBox20.ImageLocation = directoryInfo + @"cara-de-morrer(1) - Copia.png";
                                pictureBox20.Location = new Point(36, 428);
                                pictureBox20.Visible = true;
                            }
                            if (dado.Dado1 == 2)
                            {
                                picDado2.ImageLocation = directoryInfo + @"face2.png";
                                picDado2.Location = new Point(276, 238);
                                picDado2.Visible = true;
                                pictureBox20.ImageLocation = directoryInfo + @"face2 - Copia.png";
                                pictureBox20.Location = new Point(36, 428);
                                pictureBox20.Visible = true;
                            }
                            if (dado.Dado1 == 3)
                            {
                                picDado3.ImageLocation = directoryInfo + @"Pngtreevector_dice_three_icon_4102328.png";
                                picDado3.Location = new Point(276, 238);
                                picDado3.Visible = true;
                                pictureBox20.ImageLocation = directoryInfo + @"Pngtreevector_dice_three_icon_4102328 - Copia.png";
                                pictureBox20.Location = new Point(36, 428);
                                pictureBox20.Visible = true;
                            }
                            if (dado.Dado1 == 4)
                            {
                                picDado4.ImageLocation = directoryInfo + @"Pngtreevector_dice_four_icon_4102329.png";
                                picDado4.Location = new Point(276, 238);
                                picDado4.Visible = true;
                                pictureBox20.ImageLocation = directoryInfo + @"Pngtreevector_dice_four_icon_4102329 - Copia.png";
                                pictureBox20.Location = new Point(36, 428);
                                pictureBox20.Visible = true;
                            }
                            if (dado.Dado1 == 5)
                            {
                                picDado5.ImageLocation = directoryInfo + @"Pngtreevector_dice_five_icon_4102330.png";
                                picDado5.Location = new Point(276, 238);
                                picDado5.Visible = true;
                                pictureBox20.ImageLocation = directoryInfo + @"Pngtreevector_dice_five_icon_4102330 - Copia.png";
                                pictureBox20.Location = new Point(36, 428);
                                pictureBox20.Visible = true;
                            }
                            if (dado.Dado1 == 6)
                            {
                                picDado6.ImageLocation = directoryInfo + @"Pngtreevector_dice_six_icon_4102331.png";
                                picDado6.Location = new Point(276, 238);
                                picDado6.Visible = true;
                                pictureBox20.ImageLocation = directoryInfo + @"Pngtreevector_dice_six_icon_4102331 - Copia.png";
                                pictureBox20.Location = new Point(36, 428);
                                pictureBox20.Visible = true;
                            }


                            if (dado.Dado2 == 1)
                            {

                                pictureBox2.ImageLocation = directoryInfo + @"cara-de-morrer(2) - Copia.png";
                                pictureBox2.Location = new Point(334, 238);
                                pictureBox2.Visible = true;
                                pictureBox21.ImageLocation = directoryInfo + @"cara-de-morrer(3) - Copia.png";
                                pictureBox21.Location = new Point(103, 428);
                                pictureBox21.Visible = true;
                            }
                            if (dado.Dado2 == 2)
                            {
                                pictureBox3.ImageLocation = directoryInfo + @"face2 - Copia (2).png";
                                pictureBox3.Location = new Point(334, 238);
                                pictureBox3.Visible = true;
                                pictureBox21.ImageLocation = directoryInfo + @"face2 - Copia (3).png";
                                pictureBox21.Location = new Point(103, 428);
                                pictureBox21.Visible = true;
                            }
                            if (dado.Dado2 == 3)
                            {
                                pictureBox4.ImageLocation = directoryInfo + @"Pngtreevector_dice_three_icon_4102328 - Copia (2).png";
                                pictureBox4.Location = new Point(334, 238);
                                pictureBox4.Visible = true;
                                pictureBox21.ImageLocation = directoryInfo + @"Pngtreevector_dice_three_icon_4102328 - Copia (3).png";
                                pictureBox21.Location = new Point(103, 428);
                                pictureBox21.Visible = true;
                            }
                            if (dado.Dado2 == 4)
                            {
                                pictureBox7.ImageLocation = directoryInfo + @"Pngtreevector_dice_four_icon_4102329 - Copia (2).png";
                                pictureBox7.Location = new Point(334, 238);
                                pictureBox7.Visible = true;
                                pictureBox21.ImageLocation = directoryInfo + @"Pngtreevector_dice_four_icon_4102329 - Copia (3).png";
                                pictureBox21.Location = new Point(103, 428);
                                pictureBox21.Visible = true;
                            }
                            if (dado.Dado2 == 5)
                            {
                                pictureBox5.ImageLocation = directoryInfo + @"Pngtreevector_dice_five_icon_4102330 - Copia (2).png";
                                pictureBox5.Location = new Point(334, 238);
                                pictureBox5.Visible = true;
                                pictureBox21.ImageLocation = directoryInfo + @"Pngtreevector_dice_five_icon_4102330 - Copia (3).png";
                                pictureBox21.Location = new Point(103, 428);
                                pictureBox21.Visible = true;
                            }
                            if (dado.Dado2 == 6)
                            {
                                pictureBox6.ImageLocation = directoryInfo + @"Pngtreevector_dice_six_icon_4102331 - Copia (2).png";
                                pictureBox6.Location = new Point(334, 238);
                                pictureBox6.Visible = true;
                                pictureBox21.ImageLocation = directoryInfo + @"Pngtreevector_dice_six_icon_4102331 - Copia (3).png";
                                pictureBox21.Location = new Point(103, 428);
                                pictureBox21.Visible = true;
                            }


                            if (dado.Dado3 == 1)
                            {

                                pictureBox8.ImageLocation = directoryInfo + @"cara-de-morrer(4) - Copia.png";
                                pictureBox8.Location = new Point(276, 304);
                                pictureBox8.Visible = true;
                                pictureBox22.ImageLocation = directoryInfo + @"cara-de-morrer(5) - Copia.png";
                                pictureBox22.Location = new Point(195, 428);
                                pictureBox22.Visible = true;
                            }
                            if (dado.Dado3 == 2)
                            {
                                pictureBox9.ImageLocation = directoryInfo + @"face2 - Copia (4).png";
                                pictureBox9.Location = new Point(276, 304);
                                pictureBox9.Visible = true;
                                pictureBox22.ImageLocation = directoryInfo + @"face2 - Copia (5).png";
                                pictureBox22.Location = new Point(195, 428);
                                pictureBox22.Visible = true;
                            }
                            if (dado.Dado3 == 3)
                            {
                                pictureBox10.ImageLocation = directoryInfo + @"Pngtreevector_dice_three_icon_4102328 - Copia (4).png";
                                pictureBox10.Location = new Point(276, 304);
                                pictureBox10.Visible = true;
                                pictureBox22.ImageLocation = directoryInfo + @"Pngtreevector_dice_three_icon_4102328 - Copia (5).png";
                                pictureBox22.Location = new Point(195, 428);
                                pictureBox22.Visible = true;
                            }
                            if (dado.Dado3 == 4)
                            {
                                pictureBox13.ImageLocation = directoryInfo + @"Pngtreevector_dice_four_icon_4102329 - Copia (4).png";
                                pictureBox13.Location = new Point(276, 304);
                                pictureBox13.Visible = true;
                                pictureBox22.ImageLocation = directoryInfo + @"Pngtreevector_dice_four_icon_4102329 - Copia (5).png";
                                pictureBox22.Location = new Point(195, 428);
                                pictureBox22.Visible = true;
                            }
                            if (dado.Dado3 == 5)
                            {
                                pictureBox11.ImageLocation = directoryInfo + @"Pngtreevector_dice_five_icon_4102330 - Copia (4).png";
                                pictureBox11.Location = new Point(276, 304);
                                pictureBox11.Visible = true;
                                pictureBox22.ImageLocation = directoryInfo + @"Pngtreevector_dice_five_icon_4102330 - Copia (5).png";
                                pictureBox22.Location = new Point(195, 428);
                                pictureBox22.Visible = true;
                            }
                            if (dado.Dado3 == 6)
                            {
                                pictureBox12.ImageLocation = directoryInfo + @"Pngtreevector_dice_six_icon_4102331 - Copia (4).png";
                                pictureBox12.Location = new Point(276, 304);
                                pictureBox12.Visible = true;
                                pictureBox22.ImageLocation = directoryInfo + @"Pngtreevector_dice_six_icon_4102331 - Copia (5).png";
                                pictureBox22.Location = new Point(195, 428);
                                pictureBox22.Visible = true;
                            }


                            if (dado.Dado4 == 1)
                            {
                                pictureBox14.ImageLocation = directoryInfo + @"cara-de-morrer(6) - Copia.png";
                                pictureBox14.Location = new Point(334, 304);
                                pictureBox14.Visible = true;
                                pictureBox23.ImageLocation = directoryInfo + @"cara-de-morrer(7) - Copia.png";
                                pictureBox23.Location = new Point(263, 428);
                                pictureBox23.Visible = true;

                            }
                            if (dado.Dado4 == 2)
                            {
                                pictureBox15.ImageLocation = directoryInfo + @"face2 - Copia (6).png";
                                pictureBox15.Location = new Point(334, 304);
                                pictureBox15.Visible = true;
                                pictureBox23.ImageLocation = directoryInfo + @"face2 - Copia (7).png";
                                pictureBox23.Location = new Point(263, 428);
                                pictureBox23.Visible = true;
                            }
                            if (dado.Dado4 == 3)
                            {
                                pictureBox16.ImageLocation = directoryInfo + @"Pngtreevector_dice_three_icon_4102328 - Copia (6).png";
                                pictureBox16.Location = new Point(334, 304);
                                pictureBox16.Visible = true;
                                pictureBox23.ImageLocation = directoryInfo + @"Pngtreevector_dice_three_icon_4102328 - Copia (7).png";
                                pictureBox23.Location = new Point(263, 428);
                                pictureBox23.Visible = true;
                            }
                            if (dado.Dado4 == 4)
                            {
                                pictureBox19.ImageLocation = directoryInfo + @"Pngtreevector_dice_four_icon_4102329 - Copia (6).png";
                                pictureBox19.Location = new Point(334, 304);
                                pictureBox19.Visible = true;
                                pictureBox23.ImageLocation = directoryInfo + @"Pngtreevector_dice_four_icon_4102329 - Copia (7).png";
                                pictureBox23.Location = new Point(263, 428);
                                pictureBox23.Visible = true;
                            }
                            if (dado.Dado4 == 5)
                            {
                                pictureBox17.ImageLocation = directoryInfo + @"Pngtreevector_dice_five_icon_4102330 - Copia (6).png";
                                pictureBox17.Location = new Point(334, 304);
                                pictureBox17.Visible = true;
                                pictureBox23.ImageLocation = directoryInfo + @"Pngtreevector_dice_five_icon_4102330 - Copia (7).png";
                                pictureBox23.Location = new Point(263, 428);
                                pictureBox23.Visible = true;
                            }
                            if (dado.Dado4 == 6)
                            {
                                pictureBox18.ImageLocation = directoryInfo + @"Pngtreevector_dice_six_icon_4102331 - Copia (6).png";
                                pictureBox18.Location = new Point(334, 304);
                                pictureBox18.Visible = true;
                                pictureBox23.ImageLocation = directoryInfo + @"Pngtreevector_dice_six_icon_4102331 - Copia (7).png";
                                pictureBox23.Location = new Point(263, 428);
                                pictureBox23.Visible = true;
                            }
                        }

                        if ((dado.Dado1 == dado.Dado2 && dado.Dado2 == dado.Dado3 && dado.Dado3 != dado.Dado4) || (dado.Dado1 == dado.Dado2 && dado.Dado2 != dado.Dado3 && dado.Dado3 == dado.Dado4) || (dado.Dado1 != dado.Dado2 && dado.Dado2 == dado.Dado3 && dado.Dado3 == dado.Dado4) || (dado.Dado1 != dado.Dado4 && dado.Dado2 == dado.Dado3 && dado.Dado3 == dado.Dado4) || (dado.Dado1 != dado.Dado3 && dado.Dado2 == dado.Dado3 && dado.Dado3 == dado.Dado4) || (dado.Dado2 != dado.Dado4 && dado.Dado2 == dado.Dado3 && dado.Dado3 == dado.Dado4) || (dado.Dado1 == dado.Dado2 && dado.Dado2 != dado.Dado3 && dado.Dado3 != dado.Dado4) || (dado.Dado1 != dado.Dado2 && dado.Dado2 != dado.Dado3 && dado.Dado3 == dado.Dado4) || (dado.Dado1 != dado.Dado2 && dado.Dado2 == dado.Dado3 && dado.Dado3 != dado.Dado4) || (dado.Dado1 == dado.Dado4 && dado.Dado2 != dado.Dado3 && dado.Dado3 != dado.Dado4) || (dado.Dado1 == dado.Dado3 && dado.Dado2 != dado.Dado3 && dado.Dado3 != dado.Dado4) || (dado.Dado2 == dado.Dado4 && dado.Dado2 != dado.Dado3 && dado.Dado3 != dado.Dado4))
                        {
                            lblC3.Visible = false;
                            picDado1.Visible = false;
                            picDado2.Visible = false;
                            picDado3.Visible = false;
                            picDado4.Visible = false;
                            picDado5.Visible = false;
                            picDado6.Visible = false;
                            pictureBox2.Visible = false;
                            pictureBox3.Visible = false;
                            pictureBox4.Visible = false;
                            pictureBox5.Visible = false;
                            pictureBox6.Visible = false;
                            pictureBox7.Visible = false;
                            pictureBox8.Visible = false;
                            pictureBox9.Visible = false;
                            pictureBox10.Visible = false;
                            pictureBox11.Visible = false;
                            pictureBox12.Visible = false;
                            pictureBox13.Visible = false;
                            pictureBox14.Visible = false;
                            pictureBox15.Visible = false;
                            pictureBox16.Visible = false;
                            pictureBox17.Visible = false;
                            pictureBox18.Visible = false;
                            pictureBox19.Visible = false;
                            pictureBox20.Visible = false;
                            pictureBox21.Visible = false;
                            pictureBox22.Visible = false;
                            pictureBox23.Visible = false;
                            pictureBox24.Visible = false;
                            pictureBox25.Visible = false;
                            pictureBox26.Visible = false;
                            pictureBox27.Visible = false;

                            picDado1.Image = null;
                            picDado2.Image = null;
                            picDado3.Image = null;
                            picDado4.Image = null;
                            picDado5.Image = null;
                            picDado6.Image = null;
                            pictureBox2.Image = null;
                            pictureBox3.Image = null;
                            pictureBox4.Image = null;
                            pictureBox5.Image = null;
                            pictureBox6.Image = null;
                            pictureBox7.Image = null;
                            pictureBox8.Image = null;
                            pictureBox9.Image = null;
                            pictureBox10.Image = null;
                            pictureBox11.Image = null;
                            pictureBox12.Image = null;
                            pictureBox13.Image = null;
                            pictureBox14.Image = null;
                            pictureBox15.Image = null;
                            pictureBox16.Image = null;
                            pictureBox17.Image = null;
                            pictureBox18.Image = null;
                            pictureBox19.Image = null;
                            pictureBox20.Image = null;
                            pictureBox21.Image = null;
                            pictureBox22.Image = null;
                            pictureBox23.Image = null;
                            pictureBox24.Image = null;
                            pictureBox25.Image = null;
                            pictureBox26.Image = null;
                            pictureBox27.Image = null;


                            if (dado.Dado1 == 1)
                            {
                                picDado1.ImageLocation = directoryInfo + @"cara-de-morrer(1).png";
                                picDado1.Location = new Point(276, 238);
                                picDado1.Visible = true;
                                pictureBox26.ImageLocation = directoryInfo + @"cara-de-morrer(1) - Copia.png";
                                pictureBox26.Location = new Point(195, 498);
                                pictureBox26.Visible = true;
                                pictureBox20.ImageLocation = directoryInfo + @"cara-de-morrer(2) - Copia.png";
                                pictureBox20.Location = new Point(36, 428);
                                pictureBox20.Visible = true;
                            }
                            if (dado.Dado1 == 2)
                            {
                                picDado2.ImageLocation = directoryInfo + @"face2.png";
                                picDado2.Location = new Point(276, 238);
                                picDado2.Visible = true;
                                pictureBox26.ImageLocation = directoryInfo + @"face2 - Copia.png";
                                pictureBox26.Location = new Point(195, 498);
                                pictureBox26.Visible = true;
                                pictureBox20.ImageLocation = directoryInfo + @"face2 - Copia (2).png";
                                pictureBox20.Location = new Point(36, 428);
                                pictureBox20.Visible = true;
                            }
                            if (dado.Dado1 == 3)
                            {
                                picDado3.ImageLocation = directoryInfo + @"Pngtreevector_dice_three_icon_4102328.png";
                                picDado3.Location = new Point(276, 238);
                                picDado3.Visible = true;
                                pictureBox26.ImageLocation = directoryInfo + @"Pngtreevector_dice_three_icon_4102328 - Copia.png";
                                pictureBox26.Location = new Point(195, 498);
                                pictureBox26.Visible = true;
                                pictureBox20.ImageLocation = directoryInfo + @"Pngtreevector_dice_three_icon_4102328 - Copia (2).png";
                                pictureBox20.Location = new Point(36, 428);
                                pictureBox20.Visible = true;
                            }
                            if (dado.Dado1 == 4)
                            {
                                picDado4.ImageLocation = directoryInfo + @"Pngtreevector_dice_four_icon_4102329.png";
                                picDado4.Location = new Point(276, 238);
                                picDado4.Visible = true;
                                pictureBox26.ImageLocation = directoryInfo + @"Pngtreevector_dice_four_icon_4102329 - Copia.png";
                                pictureBox26.Location = new Point(195, 498);
                                pictureBox26.Visible = true;
                                pictureBox20.ImageLocation = directoryInfo + @"Pngtreevector_dice_four_icon_4102329 - Copia (2).png";
                                pictureBox20.Location = new Point(36, 428);
                                pictureBox20.Visible = true;
                            }
                            if (dado.Dado1 == 5)
                            {
                                picDado5.ImageLocation = directoryInfo + @"Pngtreevector_dice_five_icon_4102330.png";
                                picDado5.Location = new Point(276, 238);
                                picDado5.Visible = true;
                                pictureBox26.ImageLocation = directoryInfo + @"Pngtreevector_dice_five_icon_4102330 - Copia.png";
                                pictureBox26.Location = new Point(195, 498);
                                pictureBox26.Visible = true;
                                pictureBox20.ImageLocation = directoryInfo + @"Pngtreevector_dice_five_icon_4102330 - Copia (2).png";
                                pictureBox20.Location = new Point(36, 428);
                                pictureBox20.Visible = true;
                            }
                            if (dado.Dado1 == 6)
                            {
                                picDado6.ImageLocation = directoryInfo + @"Pngtreevector_dice_six_icon_4102331.png";
                                picDado6.Location = new Point(276, 238);
                                picDado6.Visible = true;
                                pictureBox26.ImageLocation = directoryInfo + @"Pngtreevector_dice_six_icon_4102331 - Copia.png";
                                pictureBox26.Location = new Point(195, 498);
                                pictureBox26.Visible = true;
                                pictureBox20.ImageLocation = directoryInfo + @"Pngtreevector_dice_six_icon_4102331 - Copia (2).png";
                                pictureBox20.Location = new Point(36, 428);
                                pictureBox20.Visible = true;
                            }


                            if (dado.Dado2 == 1)
                            {

                                pictureBox2.ImageLocation = directoryInfo + @"cara-de-morrer(3) - Copia.png";
                                pictureBox2.Location = new Point(334, 238);
                                pictureBox2.Visible = true;
                                pictureBox24.ImageLocation = directoryInfo + @"cara-de-morrer(4) - Copia.png";
                                pictureBox24.Location = new Point(36, 498);
                                pictureBox24.Visible = true;
                                pictureBox21.ImageLocation = directoryInfo + @"cara-de-morrer(5) - Copia.png";
                                pictureBox21.Location = new Point(103, 428);
                                pictureBox21.Visible = true;
                            }
                            if (dado.Dado2 == 2)
                            {
                                pictureBox3.ImageLocation = directoryInfo + @"face2 - Copia (3).png";
                                pictureBox3.Location = new Point(334, 238);
                                pictureBox3.Visible = true;
                                pictureBox24.ImageLocation = directoryInfo + @"face2 - Copia (4).png";
                                pictureBox24.Location = new Point(36, 498);
                                pictureBox24.Visible = true;
                                pictureBox21.ImageLocation = directoryInfo + @"face2 - Copia (5).png";
                                pictureBox21.Location = new Point(103, 428);
                                pictureBox21.Visible = true;
                            }
                            if (dado.Dado2 == 3)
                            {
                                pictureBox4.ImageLocation = directoryInfo + @"Pngtreevector_dice_three_icon_4102328 - Copia (3).png";
                                pictureBox4.Location = new Point(334, 238);
                                pictureBox4.Visible = true;
                                pictureBox24.ImageLocation = directoryInfo + @"Pngtreevector_dice_three_icon_4102328 - Copia (4).png";
                                pictureBox24.Location = new Point(36, 498);
                                pictureBox24.Visible = true;
                                pictureBox21.ImageLocation = directoryInfo + @"Pngtreevector_dice_three_icon_4102328 - Copia (5).png";
                                pictureBox21.Location = new Point(103, 428);
                                pictureBox21.Visible = true;
                            }
                            if (dado.Dado2 == 4)
                            {
                                pictureBox7.ImageLocation = directoryInfo + @"Pngtreevector_dice_four_icon_4102329 - Copia (3).png";
                                pictureBox7.Location = new Point(334, 238);
                                pictureBox7.Visible = true;
                                pictureBox24.ImageLocation = directoryInfo + @"Pngtreevector_dice_four_icon_4102329 - Copia (4).png";
                                pictureBox24.Location = new Point(36, 498);
                                pictureBox24.Visible = true;
                                pictureBox21.ImageLocation = directoryInfo + @"Pngtreevector_dice_four_icon_4102329  - Copia (5).png";
                                pictureBox21.Location = new Point(103, 428);
                                pictureBox21.Visible = true;
                            }
                            if (dado.Dado2 == 5)
                            {
                                pictureBox5.ImageLocation = directoryInfo + @"Pngtreevector_dice_five_icon_4102330 - Copia (3).png";
                                pictureBox5.Location = new Point(334, 238);
                                pictureBox5.Visible = true;
                                pictureBox24.ImageLocation = directoryInfo + @"Pngtreevector_dice_five_icon_4102330 - Copia (4).png";
                                pictureBox24.Location = new Point(36, 498);
                                pictureBox24.Visible = true;
                                pictureBox21.ImageLocation = directoryInfo + @"Pngtreevector_dice_five_icon_4102330 - Copia (5).png";
                                pictureBox21.Location = new Point(103, 428);
                                pictureBox21.Visible = true;
                            }
                            if (dado.Dado2 == 6)
                            {
                                pictureBox6.ImageLocation = directoryInfo + @"Pngtreevector_dice_six_icon_4102331 - Copia (3).png";
                                pictureBox6.Location = new Point(334, 238);
                                pictureBox6.Visible = true;
                                pictureBox24.ImageLocation = directoryInfo + @"Pngtreevector_dice_six_icon_4102331 - Copia (4).png";
                                pictureBox24.Location = new Point(36, 498);
                                pictureBox24.Visible = true;
                                pictureBox21.ImageLocation = directoryInfo + @"Pngtreevector_dice_six_icon_4102331 - Copia (5).png";
                                pictureBox21.Location = new Point(103, 428);
                                pictureBox21.Visible = true;
                            }


                            if (dado.Dado3 == 1)
                            {

                                pictureBox8.ImageLocation = directoryInfo + @"cara-de-morrer(6) - Copia.png";
                                pictureBox8.Location = new Point(276, 304);
                                pictureBox8.Visible = true;
                                pictureBox25.ImageLocation = directoryInfo + @"cara-de-morrer(7) - Copia.png";
                                pictureBox25.Location = new Point(103, 498);
                                pictureBox25.Visible = true;
                                pictureBox22.ImageLocation = directoryInfo + @"cara-de-morrer(8) - Copia.png";
                                pictureBox22.Location = new Point(195, 428);
                                pictureBox22.Visible = true;
                            }
                            if (dado.Dado3 == 2)
                            {
                                pictureBox9.ImageLocation = directoryInfo + @"face2 - Copia (6).png";
                                pictureBox9.Location = new Point(276, 304);
                                pictureBox9.Visible = true;
                                pictureBox25.ImageLocation = directoryInfo + @"face2 - Copia (7).png";
                                pictureBox25.Location = new Point(103, 498);
                                pictureBox25.Visible = true;
                                pictureBox22.ImageLocation = directoryInfo + @"face2 - Copia (8).png";
                                pictureBox22.Location = new Point(195, 428);
                                pictureBox22.Visible = true;
                            }
                            if (dado.Dado3 == 3)
                            {
                                pictureBox10.ImageLocation = directoryInfo + @"Pngtreevector_dice_three_icon_4102328 - Copia (6).png";
                                pictureBox10.Location = new Point(276, 304);
                                pictureBox10.Visible = true;
                                pictureBox25.ImageLocation = directoryInfo + @"Pngtreevector_dice_three_icon_4102328 - Copia (7).png";
                                pictureBox25.Location = new Point(103, 498);
                                pictureBox25.Visible = true;
                                pictureBox22.ImageLocation = directoryInfo + @"Pngtreevector_dice_three_icon_4102328 - Copia (8).png";
                                pictureBox22.Location = new Point(195, 428);
                                pictureBox22.Visible = true;
                            }
                            if (dado.Dado3 == 4)
                            {
                                pictureBox13.ImageLocation = directoryInfo + @"Pngtreevector_dice_four_icon_4102329 - Copia (6).png";
                                pictureBox13.Location = new Point(276, 304);
                                pictureBox13.Visible = true;
                                pictureBox25.ImageLocation = directoryInfo + @"Pngtreevector_dice_four_icon_4102329 - Copia (7).png";
                                pictureBox25.Location = new Point(103, 498);
                                pictureBox25.Visible = true;
                                pictureBox22.ImageLocation = directoryInfo + @"Pngtreevector_dice_four_icon_4102329 - Copia (8).png";
                                pictureBox22.Location = new Point(195, 428);
                                pictureBox22.Visible = true;
                            }
                            if (dado.Dado3 == 5)
                            {
                                pictureBox11.ImageLocation = directoryInfo + @"Pngtreevector_dice_five_icon_4102330 - Copia (6).png";
                                pictureBox11.Location = new Point(276, 304);
                                pictureBox11.Visible = true;
                                pictureBox25.ImageLocation = directoryInfo + @"Pngtreevector_dice_five_icon_4102330 - Copia (7).png";
                                pictureBox25.Location = new Point(103, 498);
                                pictureBox25.Visible = true;
                                pictureBox22.ImageLocation = directoryInfo + @"Pngtreevector_dice_five_icon_4102330 - Copia (8).png";
                                pictureBox22.Location = new Point(195, 428);
                                pictureBox22.Visible = true;
                            }
                            if (dado.Dado3 == 6)
                            {
                                pictureBox12.ImageLocation = directoryInfo + @"Pngtreevector_dice_six_icon_4102331 - Copia (6).png";
                                pictureBox12.Location = new Point(276, 304);
                                pictureBox12.Visible = true;
                                pictureBox25.ImageLocation = directoryInfo + @"Pngtreevector_dice_six_icon_4102331 - Copia (7).png";
                                pictureBox25.Location = new Point(103, 498);
                                pictureBox25.Visible = true;
                                pictureBox22.ImageLocation = directoryInfo + @"Pngtreevector_dice_six_icon_4102331 - Copia (8).png";
                                pictureBox22.Location = new Point(195, 428);
                                pictureBox22.Visible = true;
                            }


                            if (dado.Dado4 == 1)
                            {
                                pictureBox14.ImageLocation = directoryInfo + @"cara-de-morrer(9) - Copia.png";
                                pictureBox14.Location = new Point(334, 304);
                                pictureBox14.Visible = true;
                                pictureBox27.ImageLocation = directoryInfo + @"cara-de-morrer(10) - Copia.png";
                                pictureBox27.Location = new Point(263, 498);
                                pictureBox27.Visible = true;
                                pictureBox23.ImageLocation = directoryInfo + @"cara-de-morrer(11) - Copia.png";
                                pictureBox23.Location = new Point(263, 428);
                                pictureBox23.Visible = true;

                            }
                            if (dado.Dado4 == 2)
                            {
                                pictureBox15.ImageLocation = directoryInfo + @"face2 - Copia (9).png";
                                pictureBox15.Location = new Point(334, 304);
                                pictureBox15.Visible = true;
                                pictureBox27.ImageLocation = directoryInfo + @"face2 - Copia (10).png";
                                pictureBox27.Location = new Point(263, 498);
                                pictureBox27.Visible = true;
                                pictureBox23.ImageLocation = directoryInfo + @"face2 - Copia (11).png";
                                pictureBox23.Location = new Point(263, 428);
                                pictureBox23.Visible = true;
                            }
                            if (dado.Dado4 == 3)
                            {
                                pictureBox16.ImageLocation = directoryInfo + @"Pngtreevector_dice_three_icon_4102328 - Copia (9).png";
                                pictureBox16.Location = new Point(334, 304);
                                pictureBox16.Visible = true;
                                pictureBox27.ImageLocation = directoryInfo + @"Pngtreevector_dice_three_icon_4102328 - Copia (10).png";
                                pictureBox27.Location = new Point(263, 498);
                                pictureBox27.Visible = true;
                                pictureBox23.ImageLocation = directoryInfo + @"Pngtreevector_dice_three_icon_4102328 - Copia (11).png";
                                pictureBox23.Location = new Point(263, 428);
                                pictureBox23.Visible = true;
                            }
                            if (dado.Dado4 == 4)
                            {
                                pictureBox19.ImageLocation = directoryInfo + @"Pngtreevector_dice_four_icon_4102329 - Copia (9).png";
                                pictureBox19.Location = new Point(334, 304);
                                pictureBox19.Visible = true;
                                pictureBox27.ImageLocation = directoryInfo + @"Pngtreevector_dice_four_icon_4102329 - Copia (10).png";
                                pictureBox27.Location = new Point(263, 498);
                                pictureBox27.Visible = true;
                                pictureBox23.ImageLocation = directoryInfo + @"Pngtreevector_dice_four_icon_4102329 - Copia (11).png";
                                pictureBox23.Location = new Point(263, 428);
                                pictureBox23.Visible = true;
                            }
                            if (dado.Dado4 == 5)
                            {
                                pictureBox17.ImageLocation = directoryInfo + @"Pngtreevector_dice_five_icon_4102330 - Copia (9).png";
                                pictureBox17.Location = new Point(334, 304);
                                pictureBox17.Visible = true;
                                pictureBox27.ImageLocation = directoryInfo + @"Pngtreevector_dice_five_icon_4102330 - Copia (10).png";
                                pictureBox27.Location = new Point(263, 498);
                                pictureBox27.Visible = true;
                                pictureBox23.ImageLocation = directoryInfo + @"Pngtreevector_dice_five_icon_4102330 - Copia (11).png";
                                pictureBox23.Location = new Point(263, 428);
                                pictureBox23.Visible = true;
                            }
                            if (dado.Dado4 == 6)
                            {
                                pictureBox18.ImageLocation = directoryInfo + @"Pngtreevector_dice_six_icon_4102331 - Copia (9).png";
                                pictureBox18.Location = new Point(334, 304);
                                pictureBox18.Visible = true;
                                pictureBox27.ImageLocation = directoryInfo + @"Pngtreevector_dice_six_icon_4102331 - Copia (10).png";
                                pictureBox27.Location = new Point(263, 498);
                                pictureBox27.Visible = true;
                                pictureBox23.ImageLocation = directoryInfo + @"Pngtreevector_dice_six_icon_4102331 - Copia (11).png";
                                pictureBox23.Location = new Point(263, 428);
                                pictureBox23.Visible = true;
                            }
                        }
                        if (dado.Dado1 != dado.Dado2 && dado.Dado2 != dado.Dado3 && dado.Dado3 != dado.Dado4)
                        {
                            lblC1.Visible = true;
                            lblC2.Visible = true;
                            lblC3.Visible = true;
                            picDado1.Visible = false;
                            picDado2.Visible = false;
                            picDado3.Visible = false;
                            picDado4.Visible = false;
                            picDado5.Visible = false;
                            picDado6.Visible = false;
                            pictureBox2.Visible = false;
                            pictureBox3.Visible = false;
                            pictureBox4.Visible = false;
                            pictureBox5.Visible = false;
                            pictureBox6.Visible = false;
                            pictureBox7.Visible = false;
                            pictureBox8.Visible = false;
                            pictureBox9.Visible = false;
                            pictureBox10.Visible = false;
                            pictureBox11.Visible = false;
                            pictureBox12.Visible = false;
                            pictureBox13.Visible = false;
                            pictureBox14.Visible = false;
                            pictureBox15.Visible = false;
                            pictureBox16.Visible = false;
                            pictureBox17.Visible = false;
                            pictureBox18.Visible = false;
                            pictureBox19.Visible = false;
                            pictureBox20.Visible = false;
                            pictureBox21.Visible = false;
                            pictureBox22.Visible = false;
                            pictureBox23.Visible = false;
                            pictureBox24.Visible = false;
                            pictureBox25.Visible = false;
                            pictureBox26.Visible = false;
                            pictureBox27.Visible = false;
                            pictureBox28.Visible = false;
                            pictureBox29.Visible = false;
                            pictureBox30.Visible = false;
                            pictureBox31.Visible = false;

                            picDado1.Image = null;
                            picDado2.Image = null;
                            picDado3.Image = null;
                            picDado4.Image = null;
                            picDado5.Image = null;
                            picDado6.Image = null;
                            pictureBox2.Image = null;
                            pictureBox3.Image = null;
                            pictureBox4.Image = null;
                            pictureBox5.Image = null;
                            pictureBox6.Image = null;
                            pictureBox7.Image = null;
                            pictureBox8.Image = null;
                            pictureBox9.Image = null;
                            pictureBox10.Image = null;
                            pictureBox11.Image = null;
                            pictureBox12.Image = null;
                            pictureBox13.Image = null;
                            pictureBox14.Image = null;
                            pictureBox15.Image = null;
                            pictureBox16.Image = null;
                            pictureBox17.Image = null;
                            pictureBox18.Image = null;
                            pictureBox19.Image = null;
                            pictureBox20.Image = null;
                            pictureBox21.Image = null;
                            pictureBox22.Image = null;
                            pictureBox23.Image = null;
                            pictureBox24.Image = null;
                            pictureBox25.Image = null;
                            pictureBox26.Image = null;
                            pictureBox27.Image = null;
                            pictureBox28.Image = null;
                            pictureBox29.Image = null;
                            pictureBox30.Image = null;
                            pictureBox31.Image = null;

                            if (dado.Dado1 == 1)
                            {
                                picDado1.ImageLocation = directoryInfo + @"cara-de-morrer(1).png";
                                picDado1.Location = new Point(276, 238);
                                picDado1.Visible = true;
                                pictureBox24.ImageLocation = directoryInfo + @"cara-de-morrer(1) - Copia.png";
                                pictureBox24.Location = new Point(36, 498);
                                pictureBox24.Visible = true;
                                pictureBox20.ImageLocation = directoryInfo + @"cara-de-morrer(2) - Copia.png";
                                pictureBox20.Location = new Point(36, 428);
                                pictureBox20.Visible = true;
                                pictureBox28.ImageLocation = directoryInfo + @"cara-de-morrer(3) - Copia.png";
                                pictureBox28.Location = new Point(36, 565);
                                pictureBox28.Visible = true;
                            }
                            if (dado.Dado1 == 2)
                            {
                                picDado2.ImageLocation = directoryInfo + @"face2.png";
                                picDado2.Location = new Point(276, 238);
                                picDado2.Visible = true;
                                pictureBox24.ImageLocation = directoryInfo + @"face2 - Copia.png";
                                pictureBox24.Location = new Point(36, 498);
                                pictureBox24.Visible = true;
                                pictureBox20.ImageLocation = directoryInfo + @"face2 - Copia (2).png";
                                pictureBox20.Location = new Point(36, 428);
                                pictureBox20.Visible = true;
                                pictureBox28.ImageLocation = directoryInfo + @"face2 - Copia (3).png";
                                pictureBox28.Location = new Point(36, 565);
                                pictureBox28.Visible = true;
                            }
                            if (dado.Dado1 == 3)
                            {
                                picDado3.ImageLocation = directoryInfo + @"Pngtreevector_dice_three_icon_4102328.png";
                                picDado3.Location = new Point(276, 238);
                                picDado3.Visible = true;
                                pictureBox24.ImageLocation = directoryInfo + @"Pngtreevector_dice_three_icon_4102328 - Copia.png";
                                pictureBox24.Location = new Point(36, 498);
                                pictureBox24.Visible = true;
                                pictureBox20.ImageLocation = directoryInfo + @"Pngtreevector_dice_three_icon_4102328 - Copia (2).png";
                                pictureBox20.Location = new Point(36, 428);
                                pictureBox20.Visible = true;
                                pictureBox28.ImageLocation = directoryInfo + @"Pngtreevector_dice_three_icon_4102328 - Copia (3).png";
                                pictureBox28.Location = new Point(36, 565);
                                pictureBox28.Visible = true;
                            }
                            if (dado.Dado1 == 4)
                            {
                                picDado4.ImageLocation = directoryInfo + @"Pngtreevector_dice_four_icon_4102329.png";
                                picDado4.Location = new Point(276, 238);
                                picDado4.Visible = true;
                                pictureBox24.ImageLocation = directoryInfo + @"Pngtreevector_dice_four_icon_4102329 - Copia.png";
                                pictureBox24.Location = new Point(36, 498);
                                pictureBox24.Visible = true;
                                pictureBox20.ImageLocation = directoryInfo + @"Pngtreevector_dice_four_icon_4102329 - Copia (2).png";
                                pictureBox20.Location = new Point(36, 428);
                                pictureBox20.Visible = true;
                                pictureBox28.ImageLocation = directoryInfo + @"Pngtreevector_dice_four_icon_4102329 - Copia (3).png";
                                pictureBox28.Location = new Point(36, 565);
                                pictureBox28.Visible = true;
                            }
                            if (dado.Dado1 == 5)
                            {
                                picDado5.ImageLocation = directoryInfo + @"Pngtreevector_dice_five_icon_4102330.png";
                                picDado5.Location = new Point(276, 238);
                                picDado5.Visible = true;
                                pictureBox24.ImageLocation = directoryInfo + @"Pngtreevector_dice_five_icon_4102330 - Copia.png";
                                pictureBox24.Location = new Point(36, 498);
                                pictureBox24.Visible = true;
                                pictureBox20.ImageLocation = directoryInfo + @"Pngtreevector_dice_five_icon_4102330 - Copia (2).png";
                                pictureBox20.Location = new Point(36, 428);
                                pictureBox20.Visible = true;
                                pictureBox28.ImageLocation = directoryInfo + @"Pngtreevector_dice_five_icon_4102330 - Copia (3).png";
                                pictureBox28.Location = new Point(36, 565);
                                pictureBox28.Visible = true;
                            }
                            if (dado.Dado1 == 6)
                            {
                                picDado6.ImageLocation = directoryInfo + @"Pngtreevector_dice_six_icon_4102331.png";
                                picDado6.Location = new Point(276, 238);
                                picDado6.Visible = true;
                                pictureBox24.ImageLocation = directoryInfo + @"Pngtreevector_dice_six_icon_4102331 - Copia.png";
                                pictureBox24.Location = new Point(36, 498);
                                pictureBox24.Visible = true;
                                pictureBox20.ImageLocation = directoryInfo + @"Pngtreevector_dice_six_icon_4102331 - Copia (2).png";
                                pictureBox20.Location = new Point(36, 428);
                                pictureBox20.Visible = true;
                                pictureBox28.ImageLocation = directoryInfo + @"Pngtreevector_dice_six_icon_4102331 - Copia (3).png";
                                pictureBox28.Location = new Point(36, 565);
                                pictureBox28.Visible = true;
                            }


                            if (dado.Dado2 == 1)
                            {

                                pictureBox2.ImageLocation = directoryInfo + @"cara-de-morrer(4) - Copia.png";
                                pictureBox2.Location = new Point(334, 238);
                                pictureBox2.Visible = true;
                                pictureBox26.ImageLocation = directoryInfo + @"cara-de-morrer(5) - Copia.png";
                                pictureBox26.Location = new Point(195, 498);
                                pictureBox26.Visible = true;
                                pictureBox21.ImageLocation = directoryInfo + @"cara-de-morrer(6) - Copia.png";
                                pictureBox21.Location = new Point(103, 428);
                                pictureBox21.Visible = true;
                                pictureBox31.ImageLocation = directoryInfo + @"cara-de-morrer(7) - Copia.png";
                                pictureBox31.Location = new Point(263, 565);
                                pictureBox31.Visible = true;
                            }
                            if (dado.Dado2 == 2)
                            {
                                pictureBox3.ImageLocation = directoryInfo + @"face2 - Copia (4).png";
                                pictureBox3.Location = new Point(334, 238);
                                pictureBox3.Visible = true;
                                pictureBox26.ImageLocation = directoryInfo + @"face2 - Copia (5).png";
                                pictureBox26.Location = new Point(195, 498);
                                pictureBox26.Visible = true;
                                pictureBox21.ImageLocation = directoryInfo + @"face2 - Copia (6).png";
                                pictureBox21.Location = new Point(103, 428);
                                pictureBox21.Visible = true;
                                pictureBox31.ImageLocation = directoryInfo + @"face2 - Copia (7).png";
                                pictureBox31.Location = new Point(263, 565);
                                pictureBox31.Visible = true;
                            }
                            if (dado.Dado2 == 3)
                            {
                                pictureBox4.ImageLocation = directoryInfo + @"Pngtreevector_dice_three_icon_4102328 - Copia (4).png";
                                pictureBox4.Location = new Point(334, 238);
                                pictureBox4.Visible = true;
                                pictureBox26.ImageLocation = directoryInfo + @"Pngtreevector_dice_three_icon_4102328 - Copia (5).png";
                                pictureBox26.Location = new Point(195, 498);
                                pictureBox26.Visible = true;
                                pictureBox21.ImageLocation = directoryInfo + @"Pngtreevector_dice_three_icon_4102328 - Copia (6).png";
                                pictureBox21.Location = new Point(103, 428);
                                pictureBox21.Visible = true;
                                pictureBox31.ImageLocation = directoryInfo + @"Pngtreevector_dice_three_icon_4102328 - Copia (7).png";
                                pictureBox31.Location = new Point(263, 565);
                                pictureBox31.Visible = true;
                            }
                            if (dado.Dado2 == 4)
                            {
                                pictureBox7.ImageLocation = directoryInfo + @"Pngtreevector_dice_four_icon_4102329 - Copia (4).png";
                                pictureBox7.Location = new Point(334, 238);
                                pictureBox7.Visible = true;
                                pictureBox26.ImageLocation = directoryInfo + @"Pngtreevector_dice_four_icon_4102329 - Copia (5).png";
                                pictureBox26.Location = new Point(195, 498);
                                pictureBox26.Visible = true;
                                pictureBox21.ImageLocation = directoryInfo + @"Pngtreevector_dice_four_icon_4102329 - Copia (6).png";
                                pictureBox21.Location = new Point(103, 428);
                                pictureBox21.Visible = true;
                                pictureBox31.ImageLocation = directoryInfo + @"Pngtreevector_dice_four_icon_4102329 - Copia (7).png";
                                pictureBox31.Location = new Point(263, 565);
                                pictureBox31.Visible = true;
                            }
                            if (dado.Dado2 == 5)
                            {
                                pictureBox5.ImageLocation = directoryInfo + @"Pngtreevector_dice_five_icon_4102330 - Copia (4).png";
                                pictureBox5.Location = new Point(334, 238);
                                pictureBox5.Visible = true;
                                pictureBox26.ImageLocation = directoryInfo + @"Pngtreevector_dice_five_icon_4102330 - Copia (5).png";
                                pictureBox26.Location = new Point(195, 498);
                                pictureBox26.Visible = true;
                                pictureBox21.ImageLocation = directoryInfo + @"Pngtreevector_dice_five_icon_4102330 - Copia (6).png";
                                pictureBox21.Location = new Point(103, 428);
                                pictureBox21.Visible = true;
                                pictureBox31.ImageLocation = directoryInfo + @"Pngtreevector_dice_five_icon_4102330 - Copia (7).png";
                                pictureBox31.Location = new Point(263, 565);
                                pictureBox31.Visible = true;
                            }
                            if (dado.Dado2 == 6)
                            {
                                pictureBox6.ImageLocation = directoryInfo + @"Pngtreevector_dice_six_icon_4102331 - Copia (4).png";
                                pictureBox6.Location = new Point(334, 238);
                                pictureBox6.Visible = true;
                                pictureBox26.ImageLocation = directoryInfo + @"Pngtreevector_dice_six_icon_4102331 - Copia (5).png";
                                pictureBox26.Location = new Point(195, 498);
                                pictureBox26.Visible = true;
                                pictureBox21.ImageLocation = directoryInfo + @"Pngtreevector_dice_six_icon_4102331 - Copia (6).png";
                                pictureBox21.Location = new Point(103, 428);
                                pictureBox21.Visible = true;
                                pictureBox31.ImageLocation = directoryInfo + @"Pngtreevector_dice_six_icon_4102331 - Copia (7).png";
                                pictureBox31.Location = new Point(263, 565);
                                pictureBox31.Visible = true;
                            }


                            if (dado.Dado3 == 1)
                            {

                                pictureBox8.ImageLocation = directoryInfo + @"cara-de-morrer(8) - Copia.png";
                                pictureBox8.Location = new Point(276, 304);
                                pictureBox8.Visible = true;
                                pictureBox25.ImageLocation = directoryInfo + @"cara-de-morrer(9) - Copia.png";
                                pictureBox25.Location = new Point(103, 498);
                                pictureBox25.Visible = true;
                                pictureBox22.ImageLocation = directoryInfo + @"cara-de-morrer(10) - Copia.png";
                                pictureBox22.Location = new Point(195, 428);
                                pictureBox22.Visible = true;
                                pictureBox30.ImageLocation = directoryInfo + @"cara-de-morrer(11) - Copia.png";
                                pictureBox30.Location = new Point(195, 565);
                                pictureBox30.Visible = true;
                            }

                            if (dado.Dado3 == 2)
                            {
                                pictureBox9.ImageLocation = directoryInfo + @"face2 - Copia (8).png";
                                pictureBox9.Location = new Point(276, 304);
                                pictureBox9.Visible = true;
                                pictureBox25.ImageLocation = directoryInfo + @"face2 - Copia (9).png";
                                pictureBox25.Location = new Point(103, 498);
                                pictureBox25.Visible = true;
                                pictureBox22.ImageLocation = directoryInfo + @"face2 - Copia (10).png";
                                pictureBox22.Location = new Point(195, 428);
                                pictureBox22.Visible = true;
                                pictureBox30.ImageLocation = directoryInfo + @"face2 - Copia (11).png";
                                pictureBox30.Location = new Point(195, 565);
                                pictureBox30.Visible = true;
                            }

                            if (dado.Dado3 == 3)
                            {
                                pictureBox10.ImageLocation = directoryInfo + @"Pngtreevector_dice_three_icon_4102328 - Copia (8).png";
                                pictureBox10.Location = new Point(276, 304);
                                pictureBox10.Visible = true;
                                pictureBox25.ImageLocation = directoryInfo + @"Pngtreevector_dice_three_icon_4102328 - Copia (9).png";
                                pictureBox25.Location = new Point(103, 498);
                                pictureBox25.Visible = true;
                                pictureBox22.ImageLocation = directoryInfo + @"Pngtreevector_dice_three_icon_4102328 - Copia (10).png";
                                pictureBox22.Location = new Point(195, 428);
                                pictureBox22.Visible = true;
                                pictureBox30.ImageLocation = directoryInfo + @"Pngtreevector_dice_three_icon_4102328 - Copia (11).png";
                                pictureBox30.Location = new Point(195, 565);
                                pictureBox30.Visible = true;
                            }

                            if (dado.Dado3 == 4)
                            {
                                pictureBox13.ImageLocation = directoryInfo + @"Pngtreevector_dice_four_icon_4102329 - Copia (8).png";
                                pictureBox13.Location = new Point(276, 304);
                                pictureBox13.Visible = true;
                                pictureBox25.ImageLocation = directoryInfo + @"Pngtreevector_dice_four_icon_4102329 - Copia (9).png";
                                pictureBox25.Location = new Point(103, 498);
                                pictureBox25.Visible = true;
                                pictureBox22.ImageLocation = directoryInfo + @"Pngtreevector_dice_four_icon_4102329 - Copia (10).png";
                                pictureBox22.Location = new Point(195, 428);
                                pictureBox22.Visible = true;
                                pictureBox30.ImageLocation = directoryInfo + @"Pngtreevector_dice_four_icon_4102329 - Copia (11).png";
                                pictureBox30.Location = new Point(195, 565);
                                pictureBox30.Visible = true;
                            }

                            if (dado.Dado3 == 5)
                            {
                                pictureBox11.ImageLocation = directoryInfo + @"Pngtreevector_dice_five_icon_4102330 - Copia (8).png";
                                pictureBox11.Location = new Point(276, 304);
                                pictureBox11.Visible = true;
                                pictureBox25.ImageLocation = directoryInfo + @"Pngtreevector_dice_five_icon_4102330 - Copia (9).png";
                                pictureBox25.Location = new Point(103, 498);
                                pictureBox25.Visible = true;
                                pictureBox22.ImageLocation = directoryInfo + @"Pngtreevector_dice_five_icon_4102330 - Copia (10).png";
                                pictureBox22.Location = new Point(195, 428);
                                pictureBox22.Visible = true;
                                pictureBox30.ImageLocation = directoryInfo + @"Pngtreevector_dice_five_icon_4102330 - Copia (11).png";
                                pictureBox30.Location = new Point(195, 565);
                                pictureBox30.Visible = true;
                            }

                            if (dado.Dado3 == 6)
                            {
                                pictureBox12.ImageLocation = directoryInfo + @"Pngtreevector_dice_six_icon_4102331 - Copia (8).png";
                                pictureBox12.Location = new Point(276, 304);
                                pictureBox12.Visible = true;
                                pictureBox25.ImageLocation = directoryInfo + @"Pngtreevector_dice_six_icon_4102331 - Copia (9).png";
                                pictureBox25.Location = new Point(103, 498);
                                pictureBox25.Visible = true;
                                pictureBox22.ImageLocation = directoryInfo + @"Pngtreevector_dice_six_icon_4102331 - Copia (10).png";
                                pictureBox22.Location = new Point(195, 428);
                                pictureBox22.Visible = true;
                                pictureBox30.ImageLocation = directoryInfo + @"Pngtreevector_dice_six_icon_4102331 - Copia (11).png";
                                pictureBox30.Location = new Point(195, 565);
                                pictureBox30.Visible = true;
                            }


                            if (dado.Dado4 == 1)
                            {
                                pictureBox14.ImageLocation = directoryInfo + @"cara-de-morrer(12) - Copia.png";
                                pictureBox14.Location = new Point(334, 304);
                                pictureBox14.Visible = true;
                                pictureBox27.ImageLocation = directoryInfo + @"cara-de-morrer(13) - Copia.png";
                                pictureBox27.Location = new Point(263, 498);
                                pictureBox27.Visible = true;
                                pictureBox23.ImageLocation = directoryInfo + @"cara-de-morrer(14) - Copia.png";
                                pictureBox23.Location = new Point(263, 428);
                                pictureBox23.Visible = true;
                                pictureBox29.ImageLocation = directoryInfo + @"cara-de-morrer(15) - Copia.png";
                                pictureBox29.Location = new Point(103, 565);
                                pictureBox29.Visible = true;

                            }
                            if (dado.Dado4 == 2)
                            {
                                pictureBox15.ImageLocation = directoryInfo + @"face2 - Copia (12).png";
                                pictureBox15.Location = new Point(334, 304);
                                pictureBox15.Visible = true;
                                pictureBox27.ImageLocation = directoryInfo + @"face2 - Copia (13).png";
                                pictureBox27.Location = new Point(263, 498);
                                pictureBox27.Visible = true;
                                pictureBox23.ImageLocation = directoryInfo + @"face2 - Copia (14).png";
                                pictureBox23.Location = new Point(263, 428);
                                pictureBox23.Visible = true;
                                pictureBox29.ImageLocation = directoryInfo + @"face2 - Copia (15).png";
                                pictureBox29.Location = new Point(103, 565);
                                pictureBox29.Visible = true;
                            }
                            if (dado.Dado4 == 3)
                            {
                                pictureBox16.ImageLocation = directoryInfo + @"Pngtreevector_dice_three_icon_4102328 - Copia (12).png";
                                pictureBox16.Location = new Point(334, 304);
                                pictureBox16.Visible = true;
                                pictureBox27.ImageLocation = directoryInfo + @"Pngtreevector_dice_three_icon_4102328 - Copia (13).png";
                                pictureBox27.Location = new Point(263, 498);
                                pictureBox27.Visible = true;
                                pictureBox23.ImageLocation = directoryInfo + @"Pngtreevector_dice_three_icon_4102328 - Copia (14).png";
                                pictureBox23.Location = new Point(263, 428);
                                pictureBox23.Visible = true;
                                pictureBox29.ImageLocation = directoryInfo + @"Pngtreevector_dice_three_icon_4102328 - Copia (15).png";
                                pictureBox29.Location = new Point(103, 565);
                                pictureBox29.Visible = true;
                            }
                            if (dado.Dado4 == 4)
                            {
                                pictureBox19.ImageLocation = directoryInfo + @"Pngtreevector_dice_four_icon_4102329 - Copia (12).png";
                                pictureBox19.Location = new Point(334, 304);
                                pictureBox19.Visible = true;
                                pictureBox27.ImageLocation = directoryInfo + @"Pngtreevector_dice_four_icon_4102329 - Copia (13).png";
                                pictureBox27.Location = new Point(263, 498);
                                pictureBox27.Visible = true;
                                pictureBox23.ImageLocation = directoryInfo + @"Pngtreevector_dice_four_icon_4102329 - Copia (14).png";
                                pictureBox23.Location = new Point(263, 428);
                                pictureBox23.Visible = true;
                                pictureBox29.ImageLocation = directoryInfo + @"Pngtreevector_dice_four_icon_4102329 - Copia (15).png";
                                pictureBox29.Location = new Point(103, 565);
                                pictureBox29.Visible = true;
                            }
                            if (dado.Dado4 == 5)
                            {
                                pictureBox17.ImageLocation = directoryInfo + @"Pngtreevector_dice_five_icon_4102330 - Copia (12).png";
                                pictureBox17.Location = new Point(334, 304);
                                pictureBox17.Visible = true;
                                pictureBox27.ImageLocation = directoryInfo + @"Pngtreevector_dice_five_icon_4102330 - Copia (13).png";
                                pictureBox27.Location = new Point(263, 498);
                                pictureBox27.Visible = true;
                                pictureBox23.ImageLocation = directoryInfo + @"Pngtreevector_dice_five_icon_4102330 - Copia (14).png";
                                pictureBox23.Location = new Point(263, 428);
                                pictureBox23.Visible = true;
                                pictureBox29.ImageLocation = directoryInfo + @"Pngtreevector_dice_five_icon_4102330 - Copia (15).png";
                                pictureBox29.Location = new Point(103, 565);
                                pictureBox29.Visible = true;
                            }
                            if (dado.Dado4 == 6)
                            {
                                pictureBox18.ImageLocation = directoryInfo + @"Pngtreevector_dice_six_icon_4102331 - Copia (12).png";
                                pictureBox18.Location = new Point(334, 304);
                                pictureBox18.Visible = true;
                                pictureBox27.ImageLocation = directoryInfo + @"Pngtreevector_dice_six_icon_4102331 - Copia (13).png";
                                pictureBox27.Location = new Point(263, 498);
                                pictureBox27.Visible = true;
                                pictureBox23.ImageLocation = directoryInfo + @"Pngtreevector_dice_six_icon_4102331 - Copia (14).png";
                                pictureBox23.Location = new Point(263, 428);
                                pictureBox23.Visible = true;
                                pictureBox29.ImageLocation = directoryInfo + @"Pngtreevector_dice_six_icon_4102331 - Copia (15).png";
                                pictureBox29.Location = new Point(103, 565);
                                pictureBox29.Visible = true;

                            }
                        }

                        //string[] trilha2 = new string[1] { "2" };
                        //string result = Jogo.VerificarTrilhas(idPartida);
                        //if(result=="2")

                        //if ((pcBoxJ1T3.Location == new Point(507, (504 - 153) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 102) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 51) - 51) && pcBoxJ1T3.Location == new Point(507, 504 - 51) && pcBoxJ1T3.Location == new Point(507, 504)) || (pcBoxJ2T3.Location == new Point(527, 504 - (51 * 4)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 3)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 2)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 1)) && pcBoxJ2T3.Location == new Point(527, 504)) || (pcBoxJ3T3.Location == new Point(506, 521 - (51 * 4)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 3)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 2)) && pcBoxJ3T3.Location == new Point(506, 521 - (51)) && pcBoxJ3T3.Location == new Point(506, 521)) || (pcBoxJ4T3.Location == new Point(526, 521 - (51 * 4)) && pcBoxJ4T3.Location == new Point(526, 521 - (51 * 3)) && pcBoxJ4T3.Location == new Point(526, 521 - (51 * 2)) && pcBoxJ4T3.Location == new Point(526, 521 - (51)) && pcBoxJ4T3.Location == new Point(526, 521)) || (pcBoxJ1T4.Location == new Point(574, (559 - 255) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 204) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 153) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 102) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 51) - 51) && pcBoxJ1T4.Location == new Point(574, 559 - 51) && pcBoxJ1T4.Location == new Point(574, 559)) || (pcBoxJ2T4.Location == new Point(594, 559 - (51 * 6)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 5)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 4)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 3)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 2)) && pcBoxJ2T4.Location == new Point(594, 559 - 51) && pcBoxJ2T4.Location == new Point(594, 559)) || (pcBoxJ3T4.Location == new Point(574, 570 - (51 * 6)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 5)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 4)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 3)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 2)) && pcBoxJ3T4.Location == new Point(574, 570 - (51)) && pcBoxJ3T4.Location == new Point(574, 570)) || (pcBoxJ4T4.Location == new Point(594, 570 - (51 * 6)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 5)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 4)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 3)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 2)) && pcBoxJ4T4.Location == new Point(594, 570 - (51)) && pcBoxJ4T4.Location == new Point(594, 570)) || (pcBoxJ1T5.Location == new Point(639, (608 - 357) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 306) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 255) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 204) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 153) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 102) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 51) - 51) && pcBoxJ1T5.Location == new Point(639, 608 - 51) && pcBoxJ1T5.Location == new Point(639, 608)) || (pcBoxJ2T5.Location == new Point(659, 608 - (51 * 8)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 7)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 6)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 5)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 4)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 3)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 2)) && pcBoxJ2T5.Location == new Point(659, 608 - (51)) && pcBoxJ2T5.Location == new Point(659, 608)) || (pcBoxJ3T5.Location == new Point(639, 620 - (51 * 8)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 7)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 6)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 5)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 4)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 3)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 2)) && pcBoxJ3T5.Location == new Point(639, 620 - (51)) && pcBoxJ3T5.Location == new Point(639, 620)) || (pcBoxJ4T5.Location == new Point(659, 620 - (51 * 8)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 7)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 6)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 5)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 4)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 3)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 2)) && pcBoxJ4T5.Location == new Point(659, 620 - (51)) && pcBoxJ4T5.Location == new Point(659, 620)) || (pcBoxJ1T6.Location == new Point(705, (658 - 459) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 408) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 357) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 306) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 255) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 204) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 153) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 102) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 51) - 51) && pcBoxJ1T6.Location == new Point(705, 658 - 51) && pcBoxJ1T6.Location == new Point(705, 658)) || (pcBoxJ2T6.Location == new Point(725, 658 - (51 * 10)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 9)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 8)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 7)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 6)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 5)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 4)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 3)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 2)) && pcBoxJ2T6.Location == new Point(725, 658 - (51)) && pcBoxJ2T6.Location == new Point(725, 658)) || (pcBoxJ3T6.Location == new Point(703, 671 - (51 * 10)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 9)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 8)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 7)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 6)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 5)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 4)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 3)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 2)) && pcBoxJ3T6.Location == new Point(703, 671 - (51)) && pcBoxJ3T6.Location == new Point(703, 671)) || (pcBoxJ4T6.Location == new Point(723, 671 - (51 * 10)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 9)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 8)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 7)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 6)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 5)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 4)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 3)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 2)) && pcBoxJ4T6.Location == new Point(723, 671 - (51)) && pcBoxJ4T6.Location == new Point(723, 671)) || (pcBoxJ1T6.Location == new Point(705, (658 - 459) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 408) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 357) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 306) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 255) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 204) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 153) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 102) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 51) - 51) && pcBoxJ1T6.Location == new Point(705, 658 - 51) && pcBoxJ1T6.Location == new Point(705, 658)) || (pcBoxJ2T6.Location == new Point(725, 658 - (51 * 10)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 9)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 8)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 7)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 6)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 5)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 4)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 3)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 2)) && pcBoxJ2T6.Location == new Point(725, 658 - (51)) && pcBoxJ2T6.Location == new Point(725, 658)) || (pcBoxJ3T6.Location == new Point(703, 671 - (51 * 10)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 9)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 8)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 7)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 6)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 5)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 4)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 3)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 2)) && pcBoxJ3T6.Location == new Point(703, 671 - (51)) && pcBoxJ3T6.Location == new Point(703, 671)) || (pcBoxJ4T6.Location == new Point(723, 671 - (51 * 10)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 9)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 8)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 7)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 6)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 5)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 4)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 3)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 2)) && pcBoxJ4T6.Location == new Point(723, 671 - (51)) && pcBoxJ4T6.Location == new Point(723, 671)) || (pcBoxJ1T7.Location == new Point(771, (710 - 561) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 510) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 459) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 408) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 357) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 306) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 255) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 204) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 153) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 102) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 51) - 51) && pcBoxJ1T7.Location == new Point(771, 710 - 51) && pcBoxJ1T7.Location == new Point(771, 710)) || (pcBoxJ2T7.Location == new Point(791, 710 - (51 * 12)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 11)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 10)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 9)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 8)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 7)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 6)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 5)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 4)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 3)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 2)) && pcBoxJ2T7.Location == new Point(791, 710 - (51)) && pcBoxJ2T7.Location == new Point(791, 710)) || (pcBoxJ3T7.Location == new Point(770, 723 - (51 * 12)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 11)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 10)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 9)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 8)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 7)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 6)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 5)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 4)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 3)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 2)) && pcBoxJ3T7.Location == new Point(770, 723 - (51)) && pcBoxJ3T7.Location == new Point(770, 723)) || (pcBoxJ4T7.Location == new Point(787, 723 - (51 * 12)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 11)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 10)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 9)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 8)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 7)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 6)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 5)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 4)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 3)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 2)) && pcBoxJ4T7.Location == new Point(787, 723 - (51)) && pcBoxJ4T7.Location == new Point(787, 723)) || (pcBoxJ1T8.Location == new Point(837, (658 - 459) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 408) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 357) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 306) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 255) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 204) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 153) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 102) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 51) - 51) && pcBoxJ1T8.Location == new Point(837, 658 - 51) && pcBoxJ1T8.Location == new Point(837, 658)) || (pcBoxJ2T8.Location == new Point(857, 658 - (51 * 10)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 9)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 8)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 7)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 6)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 5)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 4)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 3)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 2)) && pcBoxJ2T8.Location == new Point(857, 658 - (51)) && pcBoxJ2T8.Location == new Point(857, 658)) || (pcBoxJ3T8.Location == new Point(836, 671 - (51 * 10)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 9)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 8)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 7)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 6)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 5)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 4)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 3)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 2)) && pcBoxJ3T8.Location == new Point(836, 671 - (51)) && pcBoxJ3T8.Location == new Point(836, 671)) || (pcBoxJ4T8.Location == new Point(856, 671 - (51 * 10)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 9)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 8)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 7)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 6)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 5)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 4)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 3)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 2)) && pcBoxJ4T8.Location == new Point(856, 671 - (51)) && pcBoxJ4T8.Location == new Point(856, 671)) || (pcBoxJ1T9.Location == new Point(900, (608 - 357) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 306) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 255) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 204) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 153) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 102) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 51) - 51) && pcBoxJ1T9.Location == new Point(900, 608 - 51) && pcBoxJ1T9.Location == new Point(900, 608)) || (pcBoxJ2T9.Location == new Point(920, 608 - (51 * 8)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 7)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 6)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 5)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 4)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 3)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 2)) && pcBoxJ2T9.Location == new Point(920, 608 - (51)) && pcBoxJ2T9.Location == new Point(920, 608)) || (pcBoxJ3T9.Location == new Point(897, 618 - (51 * 8)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 7)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 6)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 5)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 4)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 3)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 2)) && pcBoxJ3T9.Location == new Point(897, 618 - (51)) && pcBoxJ3T9.Location == new Point(897, 618)) || (pcBoxJ4T9.Location == new Point(917, 618 - (51 * 8)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 7)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 6)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 5)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 4)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 3)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 2)) && pcBoxJ4T9.Location == new Point(917, 618 - (51)) && pcBoxJ4T9.Location == new Point(917, 618)) || (pcBoxJ1T10.Location == new Point(967, (559 - 255) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 204) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 153) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 102) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 51) - 51) && pcBoxJ1T10.Location == new Point(967, 559 - 51) && pcBoxJ1T10.Location == new Point(967, 559)) || (pcBoxJ2T10.Location == new Point(987, 559 - (51 * 6)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 5)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 4)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 3)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 2)) && pcBoxJ2T10.Location == new Point(987, 559 - (51)) && pcBoxJ2T10.Location == new Point(987, 559)) || (pcBoxJ3T10.Location == new Point(966, 572 - (51 * 6)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 5)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 4)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 3)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 2)) && pcBoxJ3T10.Location == new Point(966, 572 - (51)) && pcBoxJ3T10.Location == new Point(966, 572)) || (pcBoxJ4T10.Location == new Point(986, 572 - (51 * 6)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 5)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 4)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 3)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 2)) && pcBoxJ4T10.Location == new Point(986, 572 - (51)) && pcBoxJ4T10.Location == new Point(986, 572)) || (pcBoxJ1T11.Location == new Point(1031, (504 - 153) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 102) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 51) - 51) && pcBoxJ1T11.Location == new Point(1031, 504 - 51) && pcBoxJ1T11.Location == new Point(1031, 504)) || (pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 4)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 3)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 2)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51)) && pcBoxJ2T11.Location == new Point(1051, 504)) || (pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 4)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 3)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 2)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51)) && pcBoxJ3T11.Location == new Point(1036, 518)) || (pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 4)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 3)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 2)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51)) && pcBoxJ4T11.Location == new Point(1056, 518)) || (pcBoxJ1T12.Location == new Point(1097, (455 - 51) - 51) && pcBoxJ1T12.Location == new Point(1097, 455 - 51) && pcBoxJ1T12.Location == new Point(1097, 455)) || (pcBoxJ2T12.Location == new Point(1117, 455 - (51 * 2)) && pcBoxJ2T12.Location == new Point(1117, 455 - (51)) && pcBoxJ2T12.Location == new Point(1117, 455)) || (pcBoxJ3T12.Location == new Point(1097, 470 - (51 * 2)) && pcBoxJ3T12.Location == new Point(1097, 470 - (51)) && pcBoxJ3T12.Location == new Point(1097, 470)) || (pcBoxJ4T12.Location == new Point(1117, 470 - (51 * 2)) && pcBoxJ4T12.Location == new Point(1117, 470 - (51)) && pcBoxJ4T12.Location == new Point(1117, 470)))
                        //{


                        //if (pcBoxJ1T2.Location == new Point(446, 455) && pcBoxJ1T2.Location == new Point(446, 455 - 51) && pcBoxJ1T2.Location == new Point(446, (455 - 51) - 51) || (pcBoxJ2T2.Location == new Point(461, 455 - (51 * 2))&&pcBoxJ2T2.Location == new Point(461, 455 - 51)&&pcBoxJ2T2.Location == new Point(461, 455)) || (pcBoxJ3T2.Location == new Point(446, 471 - (51 * 2)) && pcBoxJ3T2.Location == new Point(446, 471 - (51)) && pcBoxJ3T2.Location == new Point(446, 471))|| (pcBoxJ4T2.Location == new Point(466, 471 - (51 * 2)) && pcBoxJ4T2.Location == new Point(466, 471 - (51)) && pcBoxJ4T2.Location == new Point(466, 471)))
                        //{
                        //    if (dado.Dado1 + dado.Dado3 == 2 || dado.Dado2 + dado.Dado4 == 2)
                        //    {
                        //        string ordem = "1324";
                        //        int R1 = dado.Dado1 + dado.Dado3;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado1 + dado.Dado4 == 2 || dado.Dado2 + dado.Dado3 == 2)
                        //    {
                        //        string ordem = "1423";
                        //        int R1 = dado.Dado1 + dado.Dado4;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado1 + dado.Dado2 == 2 || dado.Dado3 + dado.Dado4 == 2)
                        //    {
                        //        string ordem = "1234";
                        //        int R1 = dado.Dado1 + dado.Dado2;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado2 + dado.Dado3 == 2 || dado.Dado1 + dado.Dado4 == 2)
                        //    {
                        //        string ordem = "2314";
                        //        int R1 = dado.Dado2 + dado.Dado3;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado2 + dado.Dado4 == 2 || dado.Dado1 + dado.Dado3 == 2)
                        //    {
                        //        string ordem = "2413";
                        //        int R1 = dado.Dado2 + dado.Dado4;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado3 + dado.Dado4 == 2 || dado.Dado1 + dado.Dado2 == 2)
                        //    {
                        //        string ordem = "3412";
                        //        int R1 = dado.Dado3 + dado.Dado4;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //}

                        


                        //if (dado.Dado1 + dado.Dado4 == 2 || dado.Dado2 + dado.Dado3 == 2)
                        //{

                        //    string ordem = "1423";
                        //    int R1 = dado.Dado1 + dado.Dado4;
                        //    int R2 = dado.Dado2 + dado.Dado3;
                        //    string v1 = R1.ToString();
                        //    string v2 = R2.ToString();
                        //    if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //    if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //    string linha3 = v1 + v2;
                        //    string result = Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //    if (result.Substring(0, 4) == "ERRO")
                        //    {
                        //        Jogo.Mover(IdJogador, senhajogador, "2413", linha3);
                        //    }
                        //    Jogo.Parar(IdJogador, senhajogador);
                        //    goto Fim;
                        //}

                        //if (dado.Dado1 + dado.Dado2 == 2 || dado.Dado3 + dado.Dado4 == 2)
                        //{

                        //    string ordem = "1234";
                        //    int R1 = dado.Dado1 + dado.Dado2;
                        //    int R2 = dado.Dado3 + dado.Dado4;
                        //    string v1 = R1.ToString();
                        //    string v2 = R2.ToString();
                        //    if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //    if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //    string linha3 = v1 + v2;
                        //    string result = Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //    if (result.Substring(0, 4) == "ERRO")
                        //    {
                        //        Jogo.Mover(IdJogador, senhajogador, "2413", linha3);
                        //    }
                        //    Jogo.Parar(IdJogador, senhajogador);
                        //    goto Fim;
                        //}

                        //trilha 3

                        //if ((pcBoxJ1T2.Location == new Point(446, 455) && pcBoxJ1T2.Location == new Point(446, 455 - 51) && pcBoxJ1T2.Location == new Point(446, (455 - 51) - 51) || (pcBoxJ2T2.Location == new Point(461, 455 - (51 * 2)) && pcBoxJ2T2.Location == new Point(461, 455 - 51) && pcBoxJ2T2.Location == new Point(461, 455)) || (pcBoxJ3T2.Location == new Point(446, 471 - (51 * 2)) && pcBoxJ3T2.Location == new Point(446, 471 - (51)) && pcBoxJ3T2.Location == new Point(446, 471)) || (pcBoxJ4T2.Location == new Point(466, 471 - (51 * 2)) && pcBoxJ4T2.Location == new Point(466, 471 - (51)) && pcBoxJ4T2.Location == new Point(466, 471)) || (pcBoxJ1T4.Location == new Point(574, (559 - 255) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 204) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 153) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 102) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 51) - 51) && pcBoxJ1T4.Location == new Point(574, 559 - 51) && pcBoxJ1T4.Location == new Point(574, 559)) || (pcBoxJ2T4.Location == new Point(594, 559 - (51 * 6)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 5)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 4)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 3)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 2)) && pcBoxJ2T4.Location == new Point(594, 559 - 51) && pcBoxJ2T4.Location == new Point(594, 559)) || (pcBoxJ3T4.Location == new Point(574, 570 - (51 * 6)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 5)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 4)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 3)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 2)) && pcBoxJ3T4.Location == new Point(574, 570 - (51)) && pcBoxJ3T4.Location == new Point(574, 570)) || (pcBoxJ4T4.Location == new Point(594, 570 - (51 * 6)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 5)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 4)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 3)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 2)) && pcBoxJ4T4.Location == new Point(594, 570 - (51)) && pcBoxJ4T4.Location == new Point(594, 570)) || (pcBoxJ1T5.Location == new Point(639, (608 - 357) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 306) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 255) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 204) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 153) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 102) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 51) - 51) && pcBoxJ1T5.Location == new Point(639, 608 - 51) && pcBoxJ1T5.Location == new Point(639, 608)) || (pcBoxJ2T5.Location == new Point(659, 608 - (51 * 8)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 7)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 6)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 5)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 4)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 3)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 2)) && pcBoxJ2T5.Location == new Point(659, 608 - (51)) && pcBoxJ2T5.Location == new Point(659, 608)) || (pcBoxJ3T5.Location == new Point(639, 620 - (51 * 8)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 7)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 6)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 5)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 4)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 3)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 2)) && pcBoxJ3T5.Location == new Point(639, 620 - (51)) && pcBoxJ3T5.Location == new Point(639, 620)) || (pcBoxJ4T5.Location == new Point(659, 620 - (51 * 8)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 7)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 6)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 5)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 4)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 3)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 2)) && pcBoxJ4T5.Location == new Point(659, 620 - (51)) && pcBoxJ4T5.Location == new Point(659, 620)) || (pcBoxJ1T6.Location == new Point(705, (658 - 459) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 408) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 357) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 306) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 255) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 204) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 153) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 102) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 51) - 51) && pcBoxJ1T6.Location == new Point(705, 658 - 51) && pcBoxJ1T6.Location == new Point(705, 658)) || (pcBoxJ2T6.Location == new Point(725, 658 - (51 * 10)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 9)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 8)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 7)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 6)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 5)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 4)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 3)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 2)) && pcBoxJ2T6.Location == new Point(725, 658 - (51)) && pcBoxJ2T6.Location == new Point(725, 658)) || (pcBoxJ3T6.Location == new Point(703, 671 - (51 * 10)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 9)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 8)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 7)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 6)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 5)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 4)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 3)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 2)) && pcBoxJ3T6.Location == new Point(703, 671 - (51)) && pcBoxJ3T6.Location == new Point(703, 671)) || (pcBoxJ4T6.Location == new Point(723, 671 - (51 * 10)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 9)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 8)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 7)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 6)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 5)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 4)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 3)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 2)) && pcBoxJ4T6.Location == new Point(723, 671 - (51)) && pcBoxJ4T6.Location == new Point(723, 671)) || (pcBoxJ1T6.Location == new Point(705, (658 - 459) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 408) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 357) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 306) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 255) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 204) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 153) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 102) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 51) - 51) && pcBoxJ1T6.Location == new Point(705, 658 - 51) && pcBoxJ1T6.Location == new Point(705, 658)) || (pcBoxJ2T6.Location == new Point(725, 658 - (51 * 10)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 9)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 8)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 7)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 6)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 5)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 4)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 3)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 2)) && pcBoxJ2T6.Location == new Point(725, 658 - (51)) && pcBoxJ2T6.Location == new Point(725, 658)) || (pcBoxJ3T6.Location == new Point(703, 671 - (51 * 10)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 9)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 8)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 7)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 6)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 5)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 4)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 3)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 2)) && pcBoxJ3T6.Location == new Point(703, 671 - (51)) && pcBoxJ3T6.Location == new Point(703, 671)) || (pcBoxJ4T6.Location == new Point(723, 671 - (51 * 10)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 9)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 8)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 7)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 6)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 5)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 4)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 3)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 2)) && pcBoxJ4T6.Location == new Point(723, 671 - (51)) && pcBoxJ4T6.Location == new Point(723, 671)) || (pcBoxJ1T7.Location == new Point(771, (710 - 561) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 510) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 459) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 408) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 357) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 306) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 255) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 204) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 153) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 102) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 51) - 51) && pcBoxJ1T7.Location == new Point(771, 710 - 51) && pcBoxJ1T7.Location == new Point(771, 710)) || (pcBoxJ2T7.Location == new Point(791, 710 - (51 * 12)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 11)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 10)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 9)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 8)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 7)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 6)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 5)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 4)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 3)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 2)) && pcBoxJ2T7.Location == new Point(791, 710 - (51)) && pcBoxJ2T7.Location == new Point(791, 710)) || (pcBoxJ3T7.Location == new Point(770, 723 - (51 * 12)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 11)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 10)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 9)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 8)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 7)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 6)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 5)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 4)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 3)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 2)) && pcBoxJ3T7.Location == new Point(770, 723 - (51)) && pcBoxJ3T7.Location == new Point(770, 723)) || (pcBoxJ4T7.Location == new Point(787, 723 - (51 * 12)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 11)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 10)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 9)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 8)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 7)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 6)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 5)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 4)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 3)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 2)) && pcBoxJ4T7.Location == new Point(787, 723 - (51)) && pcBoxJ4T7.Location == new Point(787, 723)) || (pcBoxJ1T8.Location == new Point(837, (658 - 459) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 408) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 357) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 306) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 255) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 204) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 153) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 102) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 51) - 51) && pcBoxJ1T8.Location == new Point(837, 658 - 51) && pcBoxJ1T8.Location == new Point(837, 658)) || (pcBoxJ2T8.Location == new Point(857, 658 - (51 * 10)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 9)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 8)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 7)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 6)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 5)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 4)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 3)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 2)) && pcBoxJ2T8.Location == new Point(857, 658 - (51)) && pcBoxJ2T8.Location == new Point(857, 658)) || (pcBoxJ3T8.Location == new Point(836, 671 - (51 * 10)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 9)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 8)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 7)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 6)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 5)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 4)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 3)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 2)) && pcBoxJ3T8.Location == new Point(836, 671 - (51)) && pcBoxJ3T8.Location == new Point(836, 671)) || (pcBoxJ4T8.Location == new Point(856, 671 - (51 * 10)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 9)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 8)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 7)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 6)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 5)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 4)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 3)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 2)) && pcBoxJ4T8.Location == new Point(856, 671 - (51)) && pcBoxJ4T8.Location == new Point(856, 671)) || (pcBoxJ1T9.Location == new Point(900, (608 - 357) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 306) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 255) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 204) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 153) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 102) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 51) - 51) && pcBoxJ1T9.Location == new Point(900, 608 - 51) && pcBoxJ1T9.Location == new Point(900, 608)) || (pcBoxJ2T9.Location == new Point(920, 608 - (51 * 8)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 7)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 6)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 5)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 4)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 3)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 2)) && pcBoxJ2T9.Location == new Point(920, 608 - (51)) && pcBoxJ2T9.Location == new Point(920, 608)) || (pcBoxJ3T9.Location == new Point(897, 618 - (51 * 8)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 7)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 6)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 5)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 4)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 3)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 2)) && pcBoxJ3T9.Location == new Point(897, 618 - (51)) && pcBoxJ3T9.Location == new Point(897, 618)) || (pcBoxJ4T9.Location == new Point(917, 618 - (51 * 8)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 7)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 6)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 5)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 4)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 3)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 2)) && pcBoxJ4T9.Location == new Point(917, 618 - (51)) && pcBoxJ4T9.Location == new Point(917, 618)) || (pcBoxJ1T10.Location == new Point(967, (559 - 255) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 204) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 153) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 102) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 51) - 51) && pcBoxJ1T10.Location == new Point(967, 559 - 51) && pcBoxJ1T10.Location == new Point(967, 559)) || (pcBoxJ2T10.Location == new Point(987, 559 - (51 * 6)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 5)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 4)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 3)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 2)) && pcBoxJ2T10.Location == new Point(987, 559 - (51)) && pcBoxJ2T10.Location == new Point(987, 559)) || (pcBoxJ3T10.Location == new Point(966, 572 - (51 * 6)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 5)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 4)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 3)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 2)) && pcBoxJ3T10.Location == new Point(966, 572 - (51)) && pcBoxJ3T10.Location == new Point(966, 572)) || (pcBoxJ4T10.Location == new Point(986, 572 - (51 * 6)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 5)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 4)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 3)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 2)) && pcBoxJ4T10.Location == new Point(986, 572 - (51)) && pcBoxJ4T10.Location == new Point(986, 572)) || (pcBoxJ1T11.Location == new Point(1031, (504 - 153) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 102) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 51) - 51) && pcBoxJ1T11.Location == new Point(1031, 504 - 51) && pcBoxJ1T11.Location == new Point(1031, 504)) || (pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 4)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 3)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 2)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51)) && pcBoxJ2T11.Location == new Point(1051, 504)) || (pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 4)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 3)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 2)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51)) && pcBoxJ3T11.Location == new Point(1036, 518)) || (pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 4)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 3)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 2)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51)) && pcBoxJ4T11.Location == new Point(1056, 518)) || (pcBoxJ1T12.Location == new Point(1097, (455 - 51) - 51) && pcBoxJ1T12.Location == new Point(1097, 455 - 51) && pcBoxJ1T12.Location == new Point(1097, 455)) || (pcBoxJ2T12.Location == new Point(1117, 455 - (51 * 2)) && pcBoxJ2T12.Location == new Point(1117, 455 - (51)) && pcBoxJ2T12.Location == new Point(1117, 455)) || (pcBoxJ3T12.Location == new Point(1097, 470 - (51 * 2)) && pcBoxJ3T12.Location == new Point(1097, 470 - (51)) && pcBoxJ3T12.Location == new Point(1097, 470)) || (pcBoxJ4T12.Location == new Point(1117, 470 - (51 * 2)) && pcBoxJ4T12.Location == new Point(1117, 470 - (51)) && pcBoxJ4T12.Location == new Point(1117, 470))))
                        //{

                        //if ((pcBoxJ1T2.Location == new Point(446, 455) && pcBoxJ1T2.Location == new Point(446, 455 - 51) && pcBoxJ1T2.Location == new Point(446, (455 - 51) - 51)) || (pcBoxJ2T2.Location == new Point(461, 455 - (51 * 2)) && pcBoxJ2T2.Location == new Point(461, 455 - 51) && pcBoxJ2T2.Location == new Point(461, 455)) || (pcBoxJ3T2.Location == new Point(446, 471 - (51 * 2)) && pcBoxJ3T2.Location == new Point(446, 471 - (51)) && pcBoxJ3T2.Location == new Point(446, 471)) || (pcBoxJ4T2.Location == new Point(466, 471 - (51 * 2)) && pcBoxJ4T2.Location == new Point(466, 471 - (51)) && pcBoxJ4T2.Location == new Point(466, 471)) || (pcBoxJ1T4.Location == new Point(574, (559 - 255) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 204) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 153) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 102) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 51) - 51) && pcBoxJ1T4.Location == new Point(574, 559 - 51) && pcBoxJ1T4.Location == new Point(574, 559)) || (pcBoxJ2T4.Location == new Point(594, 559 - (51 * 6)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 5)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 4)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 3)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 2)) && pcBoxJ2T4.Location == new Point(594, 559 - 51) && pcBoxJ2T4.Location == new Point(594, 559)) || (pcBoxJ3T4.Location == new Point(574, 570 - (51 * 6)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 5)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 4)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 3)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 2)) && pcBoxJ3T4.Location == new Point(574, 570 - (51)) && pcBoxJ3T4.Location == new Point(574, 570)) || (pcBoxJ4T4.Location == new Point(594, 570 - (51 * 6)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 5)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 4)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 3)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 2)) && pcBoxJ4T4.Location == new Point(594, 570 - (51)) && pcBoxJ4T4.Location == new Point(594, 570)) || (pcBoxJ1T5.Location == new Point(639, (608 - 357) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 306) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 255) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 204) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 153) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 102) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 51) - 51) && pcBoxJ1T5.Location == new Point(639, 608 - 51) && pcBoxJ1T5.Location == new Point(639, 608)) || (pcBoxJ2T5.Location == new Point(659, 608 - (51 * 8)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 7)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 6)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 5)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 4)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 3)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 2)) && pcBoxJ2T5.Location == new Point(659, 608 - (51)) && pcBoxJ2T5.Location == new Point(659, 608)) || (pcBoxJ3T5.Location == new Point(639, 620 - (51 * 8)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 7)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 6)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 5)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 4)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 3)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 2)) && pcBoxJ3T5.Location == new Point(639, 620 - (51)) && pcBoxJ3T5.Location == new Point(639, 620)) || (pcBoxJ4T5.Location == new Point(659, 620 - (51 * 8)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 7)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 6)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 5)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 4)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 3)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 2)) && pcBoxJ4T5.Location == new Point(659, 620 - (51)) && pcBoxJ4T5.Location == new Point(659, 620)) || (pcBoxJ1T6.Location == new Point(705, (658 - 459) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 408) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 357) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 306) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 255) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 204) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 153) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 102) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 51) - 51) && pcBoxJ1T6.Location == new Point(705, 658 - 51) && pcBoxJ1T6.Location == new Point(705, 658)) || (pcBoxJ2T6.Location == new Point(725, 658 - (51 * 10)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 9)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 8)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 7)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 6)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 5)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 4)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 3)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 2)) && pcBoxJ2T6.Location == new Point(725, 658 - (51)) && pcBoxJ2T6.Location == new Point(725, 658)) || (pcBoxJ3T6.Location == new Point(703, 671 - (51 * 10)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 9)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 8)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 7)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 6)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 5)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 4)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 3)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 2)) && pcBoxJ3T6.Location == new Point(703, 671 - (51)) && pcBoxJ3T6.Location == new Point(703, 671)) || (pcBoxJ4T6.Location == new Point(723, 671 - (51 * 10)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 9)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 8)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 7)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 6)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 5)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 4)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 3)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 2)) && pcBoxJ4T6.Location == new Point(723, 671 - (51)) && pcBoxJ4T6.Location == new Point(723, 671)) || (pcBoxJ1T6.Location == new Point(705, (658 - 459) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 408) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 357) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 306) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 255) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 204) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 153) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 102) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 51) - 51) && pcBoxJ1T6.Location == new Point(705, 658 - 51) && pcBoxJ1T6.Location == new Point(705, 658)) || (pcBoxJ2T6.Location == new Point(725, 658 - (51 * 10)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 9)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 8)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 7)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 6)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 5)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 4)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 3)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 2)) && pcBoxJ2T6.Location == new Point(725, 658 - (51)) && pcBoxJ2T6.Location == new Point(725, 658)) || (pcBoxJ3T6.Location == new Point(703, 671 - (51 * 10)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 9)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 8)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 7)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 6)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 5)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 4)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 3)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 2)) && pcBoxJ3T6.Location == new Point(703, 671 - (51)) && pcBoxJ3T6.Location == new Point(703, 671)) || (pcBoxJ4T6.Location == new Point(723, 671 - (51 * 10)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 9)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 8)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 7)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 6)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 5)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 4)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 3)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 2)) && pcBoxJ4T6.Location == new Point(723, 671 - (51)) && pcBoxJ4T6.Location == new Point(723, 671)) || (pcBoxJ1T7.Location == new Point(771, (710 - 561) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 510) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 459) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 408) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 357) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 306) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 255) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 204) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 153) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 102) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 51) - 51) && pcBoxJ1T7.Location == new Point(771, 710 - 51) && pcBoxJ1T7.Location == new Point(771, 710)) || (pcBoxJ2T7.Location == new Point(791, 710 - (51 * 12)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 11)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 10)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 9)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 8)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 7)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 6)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 5)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 4)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 3)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 2)) && pcBoxJ2T7.Location == new Point(791, 710 - (51)) && pcBoxJ2T7.Location == new Point(791, 710)) || (pcBoxJ3T7.Location == new Point(770, 723 - (51 * 12)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 11)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 10)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 9)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 8)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 7)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 6)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 5)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 4)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 3)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 2)) && pcBoxJ3T7.Location == new Point(770, 723 - (51)) && pcBoxJ3T7.Location == new Point(770, 723)) || (pcBoxJ4T7.Location == new Point(787, 723 - (51 * 12)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 11)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 10)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 9)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 8)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 7)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 6)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 5)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 4)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 3)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 2)) && pcBoxJ4T7.Location == new Point(787, 723 - (51)) && pcBoxJ4T7.Location == new Point(787, 723)) || (pcBoxJ1T8.Location == new Point(837, (658 - 459) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 408) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 357) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 306) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 255) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 204) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 153) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 102) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 51) - 51) && pcBoxJ1T8.Location == new Point(837, 658 - 51) && pcBoxJ1T8.Location == new Point(837, 658)) || (pcBoxJ2T8.Location == new Point(857, 658 - (51 * 10)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 9)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 8)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 7)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 6)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 5)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 4)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 3)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 2)) && pcBoxJ2T8.Location == new Point(857, 658 - (51)) && pcBoxJ2T8.Location == new Point(857, 658)) || (pcBoxJ3T8.Location == new Point(836, 671 - (51 * 10)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 9)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 8)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 7)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 6)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 5)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 4)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 3)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 2)) && pcBoxJ3T8.Location == new Point(836, 671 - (51)) && pcBoxJ3T8.Location == new Point(836, 671)) || (pcBoxJ4T8.Location == new Point(856, 671 - (51 * 10)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 9)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 8)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 7)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 6)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 5)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 4)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 3)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 2)) && pcBoxJ4T8.Location == new Point(856, 671 - (51)) && pcBoxJ4T8.Location == new Point(856, 671)) || (pcBoxJ1T9.Location == new Point(900, (608 - 357) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 306) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 255) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 204) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 153) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 102) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 51) - 51) && pcBoxJ1T9.Location == new Point(900, 608 - 51) && pcBoxJ1T9.Location == new Point(900, 608)) || (pcBoxJ2T9.Location == new Point(920, 608 - (51 * 8)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 7)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 6)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 5)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 4)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 3)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 2)) && pcBoxJ2T9.Location == new Point(920, 608 - (51)) && pcBoxJ2T9.Location == new Point(920, 608)) || (pcBoxJ3T9.Location == new Point(897, 618 - (51 * 8)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 7)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 6)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 5)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 4)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 3)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 2)) && pcBoxJ3T9.Location == new Point(897, 618 - (51)) && pcBoxJ3T9.Location == new Point(897, 618)) || (pcBoxJ4T9.Location == new Point(917, 618 - (51 * 8)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 7)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 6)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 5)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 4)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 3)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 2)) && pcBoxJ4T9.Location == new Point(917, 618 - (51)) && pcBoxJ4T9.Location == new Point(917, 618)) || (pcBoxJ1T10.Location == new Point(967, (559 - 255) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 204) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 153) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 102) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 51) - 51) && pcBoxJ1T10.Location == new Point(967, 559 - 51) && pcBoxJ1T10.Location == new Point(967, 559)) || (pcBoxJ2T10.Location == new Point(987, 559 - (51 * 6)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 5)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 4)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 3)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 2)) && pcBoxJ2T10.Location == new Point(987, 559 - (51)) && pcBoxJ2T10.Location == new Point(987, 559)) || (pcBoxJ3T10.Location == new Point(966, 572 - (51 * 6)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 5)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 4)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 3)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 2)) && pcBoxJ3T10.Location == new Point(966, 572 - (51)) && pcBoxJ3T10.Location == new Point(966, 572)) || (pcBoxJ4T10.Location == new Point(986, 572 - (51 * 6)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 5)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 4)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 3)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 2)) && pcBoxJ4T10.Location == new Point(986, 572 - (51)) && pcBoxJ4T10.Location == new Point(986, 572)) || (pcBoxJ1T11.Location == new Point(1031, (504 - 153) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 102) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 51) - 51) && pcBoxJ1T11.Location == new Point(1031, 504 - 51) && pcBoxJ1T11.Location == new Point(1031, 504)) || (pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 4)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 3)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 2)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51)) && pcBoxJ2T11.Location == new Point(1051, 504)) || (pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 4)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 3)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 2)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51)) && pcBoxJ3T11.Location == new Point(1036, 518)) || (pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 4)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 3)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 2)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51)) && pcBoxJ4T11.Location == new Point(1056, 518)) || (pcBoxJ1T12.Location == new Point(1097, (455 - 51) - 51) && pcBoxJ1T12.Location == new Point(1097, 455 - 51) && pcBoxJ1T12.Location == new Point(1097, 455)) || (pcBoxJ2T12.Location == new Point(1117, 455 - (51 * 2)) && pcBoxJ2T12.Location == new Point(1117, 455 - (51)) && pcBoxJ2T12.Location == new Point(1117, 455)) || (pcBoxJ3T12.Location == new Point(1097, 470 - (51 * 2)) && pcBoxJ3T12.Location == new Point(1097, 470 - (51)) && pcBoxJ3T12.Location == new Point(1097, 470)) || (pcBoxJ4T12.Location == new Point(1117, 470 - (51 * 2)) && pcBoxJ4T12.Location == new Point(1117, 470 - (51)) && pcBoxJ4T12.Location == new Point(1117, 470)))
                        //{

                        //if ((pcBoxJ1T2.Location == new Point(446, 455) && pcBoxJ1T2.Location == new Point(446, 455 - 51) && pcBoxJ1T2.Location == new Point(446, (455 - 51) - 51) || (pcBoxJ2T2.Location == new Point(461, 455 - (51 * 2)) && pcBoxJ2T2.Location == new Point(461, 455 - 51) && pcBoxJ2T2.Location == new Point(461, 455)) || (pcBoxJ3T2.Location == new Point(446, 471 - (51 * 2)) && pcBoxJ3T2.Location == new Point(446, 471 - (51)) && pcBoxJ3T2.Location == new Point(446, 471)) || (pcBoxJ4T2.Location == new Point(466, 471 - (51 * 2)) && pcBoxJ4T2.Location == new Point(466, 471 - (51)) && pcBoxJ4T2.Location == new Point(466, 471))) || (pcBoxJ1T4.Location == new Point(574, (559 - 255) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 204) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 153) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 102) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 51) - 51) && pcBoxJ1T4.Location == new Point(574, 559 - 51) && pcBoxJ1T4.Location == new Point(574, 559) || (pcBoxJ2T4.Location == new Point(594, 559 - (51 * 6)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 5)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 4)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 3)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 2)) && pcBoxJ2T4.Location == new Point(594, 559 - 51) && pcBoxJ2T4.Location == new Point(594, 559)) || (pcBoxJ3T4.Location == new Point(574, 570 - (51 * 6)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 5)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 4)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 3)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 2)) && pcBoxJ3T4.Location == new Point(574, 570 - (51)) && pcBoxJ3T4.Location == new Point(574, 570)) || (pcBoxJ4T4.Location == new Point(594, 570 - (51 * 6)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 5)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 4)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 3)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 2)) && pcBoxJ4T4.Location == new Point(594, 570 - (51)) && pcBoxJ4T4.Location == new Point(594, 570))) || (pcBoxJ1T5.Location == new Point(639, (608 - 357) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 306) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 255) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 204) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 153) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 102) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 51) - 51) && pcBoxJ1T5.Location == new Point(639, 608 - 51) && pcBoxJ1T5.Location == new Point(639, 608) || (pcBoxJ2T5.Location == new Point(659, 608 - (51 * 8)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 7)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 6)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 5)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 4)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 3)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 2)) && pcBoxJ2T5.Location == new Point(659, 608 - (51)) && pcBoxJ2T5.Location == new Point(659, 608)) || (pcBoxJ3T5.Location == new Point(639, 620 - (51 * 8)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 7)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 6)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 5)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 4)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 3)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 2)) && pcBoxJ3T5.Location == new Point(639, 620 - (51)) && pcBoxJ3T5.Location == new Point(639, 620)) || (pcBoxJ4T5.Location == new Point(659, 620 - (51 * 8)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 7)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 6)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 5)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 4)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 3)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 2)) && pcBoxJ4T5.Location == new Point(659, 620 - (51)) && pcBoxJ4T5.Location == new Point(659, 620))) || (pcBoxJ1T6.Location == new Point(705, (658 - 459) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 408) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 357) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 306) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 255) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 204) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 153) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 102) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 51) - 51) && pcBoxJ1T6.Location == new Point(705, 658 - 51) && pcBoxJ1T6.Location == new Point(705, 658) || (pcBoxJ2T6.Location == new Point(725, 658 - (51 * 10)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 9)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 8)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 7)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 6)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 5)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 4)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 3)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 2)) && pcBoxJ2T6.Location == new Point(725, 658 - (51)) && pcBoxJ2T6.Location == new Point(725, 658)) || (pcBoxJ3T6.Location == new Point(703, 671 - (51 * 10)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 9)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 8)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 7)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 6)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 5)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 4)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 3)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 2)) && pcBoxJ3T6.Location == new Point(703, 671 - (51)) && pcBoxJ3T6.Location == new Point(703, 671)) || (pcBoxJ4T6.Location == new Point(723, 671 - (51 * 10)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 9)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 8)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 7)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 6)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 5)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 4)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 3)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 2)) && pcBoxJ4T6.Location == new Point(723, 671 - (51)) && pcBoxJ4T6.Location == new Point(723, 671))) || (pcBoxJ1T6.Location == new Point(705, (658 - 459) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 408) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 357) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 306) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 255) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 204) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 153) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 102) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 51) - 51) && pcBoxJ1T6.Location == new Point(705, 658 - 51) && pcBoxJ1T6.Location == new Point(705, 658) || (pcBoxJ2T6.Location == new Point(725, 658 - (51 * 10)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 9)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 8)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 7)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 6)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 5)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 4)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 3)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 2)) && pcBoxJ2T6.Location == new Point(725, 658 - (51)) && pcBoxJ2T6.Location == new Point(725, 658)) || (pcBoxJ3T6.Location == new Point(703, 671 - (51 * 10)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 9)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 8)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 7)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 6)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 5)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 4)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 3)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 2)) && pcBoxJ3T6.Location == new Point(703, 671 - (51)) && pcBoxJ3T6.Location == new Point(703, 671)) || (pcBoxJ4T6.Location == new Point(723, 671 - (51 * 10)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 9)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 8)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 7)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 6)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 5)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 4)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 3)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 2)) && pcBoxJ4T6.Location == new Point(723, 671 - (51)) && pcBoxJ4T6.Location == new Point(723, 671))) || (pcBoxJ1T7.Location == new Point(771, (710 - 561) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 510) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 459) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 408) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 357) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 306) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 255) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 204) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 153) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 102) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 51) - 51) && pcBoxJ1T7.Location == new Point(771, 710 - 51) && pcBoxJ1T7.Location == new Point(771, 710) || (pcBoxJ2T7.Location == new Point(791, 710 - (51 * 12)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 11)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 10)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 9)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 8)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 7)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 6)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 5)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 4)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 3)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 2)) && pcBoxJ2T7.Location == new Point(791, 710 - (51)) && pcBoxJ2T7.Location == new Point(791, 710)) || (pcBoxJ3T7.Location == new Point(770, 723 - (51 * 12)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 11)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 10)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 9)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 8)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 7)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 6)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 5)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 4)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 3)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 2)) && pcBoxJ3T7.Location == new Point(770, 723 - (51)) && pcBoxJ3T7.Location == new Point(770, 723) || (pcBoxJ4T7.Location == new Point(787, 723 - (51 * 12)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 11)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 10)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 9)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 8)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 7)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 6)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 5)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 4)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 3)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 2)) && pcBoxJ4T7.Location == new Point(787, 723 - (51)) && pcBoxJ4T7.Location == new Point(787, 723))) || (pcBoxJ1T8.Location == new Point(837, (658 - 459) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 408) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 357) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 306) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 255) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 204) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 153) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 102) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 51) - 51) && pcBoxJ1T8.Location == new Point(837, 658 - 51) && pcBoxJ1T8.Location == new Point(837, 658) || (pcBoxJ2T8.Location == new Point(857, 658 - (51 * 10)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 9)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 8)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 7)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 6)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 5)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 4)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 3)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 2)) && pcBoxJ2T8.Location == new Point(857, 658 - (51)) && pcBoxJ2T8.Location == new Point(857, 658)) || (pcBoxJ3T8.Location == new Point(836, 671 - (51 * 10)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 9)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 8)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 7)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 6)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 5)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 4)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 3)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 2)) && pcBoxJ3T8.Location == new Point(836, 671 - (51)) && pcBoxJ3T8.Location == new Point(836, 671)) || (pcBoxJ4T8.Location == new Point(856, 671 - (51 * 10)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 9)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 8)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 7)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 6)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 5)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 4)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 3)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 2)) && pcBoxJ4T8.Location == new Point(856, 671 - (51)) && pcBoxJ4T8.Location == new Point(856, 671))) || (pcBoxJ1T9.Location == new Point(900, (608 - 357) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 306) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 255) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 204) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 153) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 102) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 51) - 51) && pcBoxJ1T9.Location == new Point(900, 608 - 51) && pcBoxJ1T9.Location == new Point(900, 608) || (pcBoxJ2T9.Location == new Point(920, 608 - (51 * 8)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 7)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 6)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 5)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 4)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 3)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 2)) && pcBoxJ2T9.Location == new Point(920, 608 - (51)) && pcBoxJ2T9.Location == new Point(920, 608)) || (pcBoxJ3T9.Location == new Point(897, 618 - (51 * 8)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 7)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 6)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 5)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 4)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 3)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 2)) && pcBoxJ3T9.Location == new Point(897, 618 - (51)) && pcBoxJ3T9.Location == new Point(897, 618)) || (pcBoxJ4T9.Location == new Point(917, 618 - (51 * 8)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 7)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 6)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 5)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 4)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 3)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 2)) && pcBoxJ4T9.Location == new Point(917, 618 - (51)) && pcBoxJ4T9.Location == new Point(917, 618))) || (pcBoxJ1T10.Location == new Point(967, (559 - 255) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 204) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 153) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 102) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 51) - 51) && pcBoxJ1T10.Location == new Point(967, 559 - 51) && pcBoxJ1T10.Location == new Point(967, 559) || (pcBoxJ2T10.Location == new Point(987, 559 - (51 * 6)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 5)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 4)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 3)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 2)) && pcBoxJ2T10.Location == new Point(987, 559 - (51)) && pcBoxJ2T10.Location == new Point(987, 559)) || (pcBoxJ3T10.Location == new Point(966, 572 - (51 * 6)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 5)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 4)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 3)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 2)) && pcBoxJ3T10.Location == new Point(966, 572 - (51)) && pcBoxJ3T10.Location == new Point(966, 572)) || (pcBoxJ4T10.Location == new Point(986, 572 - (51 * 6)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 5)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 4)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 3)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 2)) && pcBoxJ4T10.Location == new Point(986, 572 - (51)) && pcBoxJ4T10.Location == new Point(986, 572))) || (pcBoxJ1T11.Location == new Point(1031, (504 - 153) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 102) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 51) - 51) && pcBoxJ1T11.Location == new Point(1031, 504 - 51) && pcBoxJ1T11.Location == new Point(1031, 504) || (pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 4)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 3)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 2)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51)) && pcBoxJ2T11.Location == new Point(1051, 504)) || (pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 4)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 3)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 2)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51)) && pcBoxJ3T11.Location == new Point(1036, 518)) || (pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 4)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 3)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 2)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51)) && pcBoxJ4T11.Location == new Point(1056, 518))) || (pcBoxJ1T12.Location == new Point(1097, (455 - 51) - 51) && pcBoxJ1T12.Location == new Point(1097, 455 - 51) && pcBoxJ1T12.Location == new Point(1097, 455) || (pcBoxJ2T12.Location == new Point(1117, 455 - (51 * 2)) && pcBoxJ2T12.Location == new Point(1117, 455 - (51)) && pcBoxJ2T12.Location == new Point(1117, 455)) || (pcBoxJ3T12.Location == new Point(1097, 470 - (51 * 2)) && pcBoxJ3T12.Location == new Point(1097, 470 - (51)) && pcBoxJ3T12.Location == new Point(1097, 470)) || (pcBoxJ4T12.Location == new Point(1117, 470 - (51 * 2)) && pcBoxJ4T12.Location == new Point(1117, 470 - (51)) && pcBoxJ4T12.Location == new Point(1117, 470)))))
                        //{

                        //    if (dado.Dado1 + dado.Dado3 == 3 || dado.Dado2 + dado.Dado4 == 3)
                        //    {
                        //        string ordem = "1324";
                        //        int R1 = dado.Dado1 + dado.Dado3;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        string result = Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        if (result.Substring(0, 4) == "ERRO")
                        //        {
                        //            Jogo.Mover(IdJogador, senhajogador, "2413", linha3);
                        //        }
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado1 + dado.Dado4 == 3 || dado.Dado2 + dado.Dado3 == 3)
                        //    {
                        //        string ordem = "1423";
                        //        int R1 = dado.Dado1 + dado.Dado4;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado1 + dado.Dado2 == 3 || dado.Dado3 + dado.Dado4 == 3)
                        //    {
                        //        string ordem = "1234";
                        //        int R1 = dado.Dado1 + dado.Dado2;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado2 + dado.Dado3 == 3 || dado.Dado1 + dado.Dado4 == 3)
                        //    {
                        //        string ordem = "2314";
                        //        int R1 = dado.Dado2 + dado.Dado3;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado2 + dado.Dado4 == 3 || dado.Dado1 + dado.Dado3 == 3)
                        //    {
                        //        string ordem = "2413";
                        //        int R1 = dado.Dado2 + dado.Dado4;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado3 + dado.Dado4 == 3 || dado.Dado1 + dado.Dado2 == 3)
                        //    {
                        //        string ordem = "3412";
                        //        int R1 = dado.Dado3 + dado.Dado4;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //}


                        

                        //if (dado.Dado1 + dado.Dado4 == 3 || dado.Dado2 + dado.Dado3 == 3)
                        //{

                        //    string ordem = "1423";
                        //    int R1 = dado.Dado1 + dado.Dado4;
                        //    int R2 = dado.Dado2 + dado.Dado3;
                        //    string v1 = R1.ToString();
                        //    string v2 = R2.ToString();
                        //    if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //    if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //    string linha3 = v1 + v2;
                        //    string result = Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //    if (result.Substring(0, 4) == "ERRO")
                        //    {
                        //        Jogo.Mover(IdJogador, senhajogador, "2413", linha3);
                        //    }
                        //    Jogo.Parar(IdJogador, senhajogador);
                        //    goto Fim;
                        //}

                        //if (dado.Dado1 + dado.Dado2 == 3 || dado.Dado3 + dado.Dado4 == 3)
                        //{

                        //    string ordem = "1234";
                        //    int R1 = dado.Dado1 + dado.Dado2;
                        //    int R2 = dado.Dado3 + dado.Dado4;
                        //    string v1 = R1.ToString();
                        //    string v2 = R2.ToString();
                        //    if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //    if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //    string linha3 = v1 + v2;
                        //    string result = Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //    if (result.Substring(0, 4) == "ERRO")
                        //    {
                        //        Jogo.Mover(IdJogador, senhajogador, "2413", linha3);
                        //    }
                        //    Jogo.Parar(IdJogador, senhajogador);
                        //    goto Fim;
                        //}

                        //trilha 4

                        //if ((pcBoxJ1T2.Location == new Point(446, 455) && pcBoxJ1T2.Location == new Point(446, 455 - 51) && pcBoxJ1T2.Location == new Point(446, (455 - 51) - 51) || (pcBoxJ2T2.Location == new Point(461, 455 - (51 * 2)) && pcBoxJ2T2.Location == new Point(461, 455 - 51) && pcBoxJ2T2.Location == new Point(461, 455)) || (pcBoxJ3T2.Location == new Point(446, 471 - (51 * 2)) && pcBoxJ3T2.Location == new Point(446, 471 - (51)) && pcBoxJ3T2.Location == new Point(446, 471)) || (pcBoxJ4T2.Location == new Point(466, 471 - (51 * 2)) && pcBoxJ4T2.Location == new Point(466, 471 - (51)) && pcBoxJ4T2.Location == new Point(466, 471)) || (pcBoxJ1T3.Location == new Point(507, (504 - 153) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 102) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 51) - 51) && pcBoxJ1T3.Location == new Point(507, 504 - 51) && pcBoxJ1T3.Location == new Point(507, 504)) || (pcBoxJ2T3.Location == new Point(527, 504 - (51 * 4)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 3)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 2)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 1)) && pcBoxJ2T3.Location == new Point(527, 504)) || (pcBoxJ3T3.Location == new Point(506, 521 - (51 * 4)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 3)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 2)) && pcBoxJ3T3.Location == new Point(506, 521 - (51)) && pcBoxJ3T3.Location == new Point(506, 521)) || (pcBoxJ4T3.Location == new Point(526, 521 - (51 * 4)) && pcBoxJ4T3.Location == new Point(526, 521 - (51 * 3)) && pcBoxJ4T3.Location == new Point(526, 521 - (51 * 2)) && pcBoxJ4T3.Location == new Point(526, 521 - (51)) && pcBoxJ4T3.Location == new Point(526, 521)) || (pcBoxJ1T5.Location == new Point(639, (608 - 357) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 306) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 255) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 204) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 153) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 102) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 51) - 51) && pcBoxJ1T5.Location == new Point(639, 608 - 51) && pcBoxJ1T5.Location == new Point(639, 608)) || (pcBoxJ2T5.Location == new Point(659, 608 - (51 * 8)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 7)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 6)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 5)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 4)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 3)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 2)) && pcBoxJ2T5.Location == new Point(659, 608 - (51)) && pcBoxJ2T5.Location == new Point(659, 608)) || (pcBoxJ3T5.Location == new Point(639, 620 - (51 * 8)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 7)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 6)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 5)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 4)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 3)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 2)) && pcBoxJ3T5.Location == new Point(639, 620 - (51)) && pcBoxJ3T5.Location == new Point(639, 620)) || (pcBoxJ4T5.Location == new Point(659, 620 - (51 * 8)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 7)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 6)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 5)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 4)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 3)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 2)) && pcBoxJ4T5.Location == new Point(659, 620 - (51)) && pcBoxJ4T5.Location == new Point(659, 620)) || (pcBoxJ1T6.Location == new Point(705, (658 - 459) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 408) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 357) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 306) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 255) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 204) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 153) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 102) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 51) - 51) && pcBoxJ1T6.Location == new Point(705, 658 - 51) && pcBoxJ1T6.Location == new Point(705, 658)) || (pcBoxJ2T6.Location == new Point(725, 658 - (51 * 10)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 9)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 8)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 7)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 6)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 5)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 4)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 3)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 2)) && pcBoxJ2T6.Location == new Point(725, 658 - (51)) && pcBoxJ2T6.Location == new Point(725, 658)) || (pcBoxJ3T6.Location == new Point(703, 671 - (51 * 10)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 9)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 8)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 7)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 6)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 5)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 4)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 3)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 2)) && pcBoxJ3T6.Location == new Point(703, 671 - (51)) && pcBoxJ3T6.Location == new Point(703, 671)) || (pcBoxJ4T6.Location == new Point(723, 671 - (51 * 10)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 9)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 8)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 7)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 6)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 5)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 4)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 3)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 2)) && pcBoxJ4T6.Location == new Point(723, 671 - (51)) && pcBoxJ4T6.Location == new Point(723, 671)) || (pcBoxJ1T6.Location == new Point(705, (658 - 459) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 408) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 357) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 306) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 255) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 204) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 153) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 102) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 51) - 51) && pcBoxJ1T6.Location == new Point(705, 658 - 51) && pcBoxJ1T6.Location == new Point(705, 658)) || (pcBoxJ2T6.Location == new Point(725, 658 - (51 * 10)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 9)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 8)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 7)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 6)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 5)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 4)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 3)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 2)) && pcBoxJ2T6.Location == new Point(725, 658 - (51)) && pcBoxJ2T6.Location == new Point(725, 658)) || (pcBoxJ3T6.Location == new Point(703, 671 - (51 * 10)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 9)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 8)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 7)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 6)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 5)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 4)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 3)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 2)) && pcBoxJ3T6.Location == new Point(703, 671 - (51)) && pcBoxJ3T6.Location == new Point(703, 671)) || (pcBoxJ4T6.Location == new Point(723, 671 - (51 * 10)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 9)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 8)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 7)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 6)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 5)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 4)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 3)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 2)) && pcBoxJ4T6.Location == new Point(723, 671 - (51)) && pcBoxJ4T6.Location == new Point(723, 671)) || (pcBoxJ1T7.Location == new Point(771, (710 - 561) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 510) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 459) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 408) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 357) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 306) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 255) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 204) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 153) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 102) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 51) - 51) && pcBoxJ1T7.Location == new Point(771, 710 - 51) && pcBoxJ1T7.Location == new Point(771, 710)) || (pcBoxJ2T7.Location == new Point(791, 710 - (51 * 12)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 11)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 10)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 9)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 8)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 7)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 6)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 5)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 4)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 3)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 2)) && pcBoxJ2T7.Location == new Point(791, 710 - (51)) && pcBoxJ2T7.Location == new Point(791, 710)) || (pcBoxJ3T7.Location == new Point(770, 723 - (51 * 12)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 11)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 10)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 9)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 8)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 7)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 6)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 5)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 4)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 3)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 2)) && pcBoxJ3T7.Location == new Point(770, 723 - (51)) && pcBoxJ3T7.Location == new Point(770, 723)) || (pcBoxJ4T7.Location == new Point(787, 723 - (51 * 12)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 11)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 10)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 9)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 8)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 7)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 6)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 5)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 4)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 3)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 2)) && pcBoxJ4T7.Location == new Point(787, 723 - (51)) && pcBoxJ4T7.Location == new Point(787, 723)) || (pcBoxJ1T8.Location == new Point(837, (658 - 459) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 408) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 357) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 306) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 255) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 204) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 153) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 102) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 51) - 51) && pcBoxJ1T8.Location == new Point(837, 658 - 51) && pcBoxJ1T8.Location == new Point(837, 658)) || (pcBoxJ2T8.Location == new Point(857, 658 - (51 * 10)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 9)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 8)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 7)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 6)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 5)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 4)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 3)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 2)) && pcBoxJ2T8.Location == new Point(857, 658 - (51)) && pcBoxJ2T8.Location == new Point(857, 658)) || (pcBoxJ3T8.Location == new Point(836, 671 - (51 * 10)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 9)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 8)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 7)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 6)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 5)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 4)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 3)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 2)) && pcBoxJ3T8.Location == new Point(836, 671 - (51)) && pcBoxJ3T8.Location == new Point(836, 671)) || (pcBoxJ4T8.Location == new Point(856, 671 - (51 * 10)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 9)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 8)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 7)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 6)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 5)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 4)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 3)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 2)) && pcBoxJ4T8.Location == new Point(856, 671 - (51)) && pcBoxJ4T8.Location == new Point(856, 671)) || (pcBoxJ1T9.Location == new Point(900, (608 - 357) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 306) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 255) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 204) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 153) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 102) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 51) - 51) && pcBoxJ1T9.Location == new Point(900, 608 - 51) && pcBoxJ1T9.Location == new Point(900, 608)) || (pcBoxJ2T9.Location == new Point(920, 608 - (51 * 8)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 7)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 6)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 5)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 4)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 3)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 2)) && pcBoxJ2T9.Location == new Point(920, 608 - (51)) && pcBoxJ2T9.Location == new Point(920, 608)) || (pcBoxJ3T9.Location == new Point(897, 618 - (51 * 8)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 7)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 6)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 5)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 4)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 3)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 2)) && pcBoxJ3T9.Location == new Point(897, 618 - (51)) && pcBoxJ3T9.Location == new Point(897, 618)) || (pcBoxJ4T9.Location == new Point(917, 618 - (51 * 8)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 7)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 6)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 5)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 4)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 3)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 2)) && pcBoxJ4T9.Location == new Point(917, 618 - (51)) && pcBoxJ4T9.Location == new Point(917, 618)) || (pcBoxJ1T10.Location == new Point(967, (559 - 255) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 204) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 153) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 102) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 51) - 51) && pcBoxJ1T10.Location == new Point(967, 559 - 51) && pcBoxJ1T10.Location == new Point(967, 559)) || (pcBoxJ2T10.Location == new Point(987, 559 - (51 * 6)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 5)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 4)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 3)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 2)) && pcBoxJ2T10.Location == new Point(987, 559 - (51)) && pcBoxJ2T10.Location == new Point(987, 559)) || (pcBoxJ3T10.Location == new Point(966, 572 - (51 * 6)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 5)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 4)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 3)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 2)) && pcBoxJ3T10.Location == new Point(966, 572 - (51)) && pcBoxJ3T10.Location == new Point(966, 572)) || (pcBoxJ4T10.Location == new Point(986, 572 - (51 * 6)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 5)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 4)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 3)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 2)) && pcBoxJ4T10.Location == new Point(986, 572 - (51)) && pcBoxJ4T10.Location == new Point(986, 572)) || (pcBoxJ1T11.Location == new Point(1031, (504 - 153) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 102) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 51) - 51) && pcBoxJ1T11.Location == new Point(1031, 504 - 51) && pcBoxJ1T11.Location == new Point(1031, 504)) || (pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 4)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 3)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 2)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51)) && pcBoxJ2T11.Location == new Point(1051, 504)) || (pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 4)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 3)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 2)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51)) && pcBoxJ3T11.Location == new Point(1036, 518))) || (pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 4)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 3)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 2)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51)) && pcBoxJ4T11.Location == new Point(1056, 518)) || (pcBoxJ1T12.Location == new Point(1097, (455 - 51) - 51) && pcBoxJ1T12.Location == new Point(1097, 455 - 51) && pcBoxJ1T12.Location == new Point(1097, 455)) || (pcBoxJ2T12.Location == new Point(1117, 455 - (51 * 2)) && pcBoxJ2T12.Location == new Point(1117, 455 - (51)) && pcBoxJ2T12.Location == new Point(1117, 455)) || (pcBoxJ3T12.Location == new Point(1097, 470 - (51 * 2)) && pcBoxJ3T12.Location == new Point(1097, 470 - (51)) && pcBoxJ3T12.Location == new Point(1097, 470)) || (pcBoxJ4T12.Location == new Point(1117, 470 - (51 * 2)) && pcBoxJ4T12.Location == new Point(1117, 470 - (51)) && pcBoxJ4T12.Location == new Point(1117, 470)))
                        ////{
                        //if ((pcBoxJ1T2.Location == new Point(446, 455) && pcBoxJ1T2.Location == new Point(446, 455 - 51) && pcBoxJ1T2.Location == new Point(446, (455 - 51) - 51)) || (pcBoxJ2T2.Location == new Point(461, 455 - (51 * 2)) && pcBoxJ2T2.Location == new Point(461, 455 - 51) && pcBoxJ2T2.Location == new Point(461, 455)) || (pcBoxJ3T2.Location == new Point(446, 471 - (51 * 2)) && pcBoxJ3T2.Location == new Point(446, 471 - (51)) && pcBoxJ3T2.Location == new Point(446, 471)) || (pcBoxJ4T2.Location == new Point(466, 471 - (51 * 2)) && pcBoxJ4T2.Location == new Point(466, 471 - (51)) && pcBoxJ4T2.Location == new Point(466, 471)) || (pcBoxJ1T3.Location == new Point(507, (504 - 153) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 102) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 51) - 51) && pcBoxJ1T3.Location == new Point(507, 504 - 51) && pcBoxJ1T3.Location == new Point(507, 504)) || (pcBoxJ2T3.Location == new Point(527, 504 - (51 * 4)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 3)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 2)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 1)) && pcBoxJ2T3.Location == new Point(527, 504)) || (pcBoxJ3T3.Location == new Point(506, 521 - (51 * 4)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 3)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 2)) && pcBoxJ3T3.Location == new Point(506, 521 - (51)) && pcBoxJ3T3.Location == new Point(506, 521)) || (pcBoxJ4T3.Location == new Point(526, 521 - (51 * 4)) && pcBoxJ4T3.Location == new Point(526, 521 - (51 * 3)) && pcBoxJ4T3.Location == new Point(526, 521 - (51 * 2)) && pcBoxJ4T3.Location == new Point(526, 521 - (51)) && pcBoxJ4T3.Location == new Point(526, 521)) || (pcBoxJ1T5.Location == new Point(639, (608 - 357) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 306) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 255) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 204) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 153) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 102) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 51) - 51) && pcBoxJ1T5.Location == new Point(639, 608 - 51) && pcBoxJ1T5.Location == new Point(639, 608)) || (pcBoxJ2T5.Location == new Point(659, 608 - (51 * 8)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 7)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 6)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 5)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 4)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 3)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 2)) && pcBoxJ2T5.Location == new Point(659, 608 - (51)) && pcBoxJ2T5.Location == new Point(659, 608)) || (pcBoxJ3T5.Location == new Point(639, 620 - (51 * 8)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 7)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 6)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 5)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 4)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 3)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 2)) && pcBoxJ3T5.Location == new Point(639, 620 - (51)) && pcBoxJ3T5.Location == new Point(639, 620)) || (pcBoxJ4T5.Location == new Point(659, 620 - (51 * 8)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 7)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 6)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 5)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 4)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 3)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 2)) && pcBoxJ4T5.Location == new Point(659, 620 - (51)) && pcBoxJ4T5.Location == new Point(659, 620)) || (pcBoxJ1T6.Location == new Point(705, (658 - 459) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 408) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 357) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 306) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 255) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 204) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 153) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 102) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 51) - 51) && pcBoxJ1T6.Location == new Point(705, 658 - 51) && pcBoxJ1T6.Location == new Point(705, 658)) || (pcBoxJ2T6.Location == new Point(725, 658 - (51 * 10)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 9)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 8)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 7)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 6)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 5)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 4)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 3)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 2)) && pcBoxJ2T6.Location == new Point(725, 658 - (51)) && pcBoxJ2T6.Location == new Point(725, 658)) || (pcBoxJ3T6.Location == new Point(703, 671 - (51 * 10)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 9)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 8)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 7)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 6)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 5)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 4)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 3)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 2)) && pcBoxJ3T6.Location == new Point(703, 671 - (51)) && pcBoxJ3T6.Location == new Point(703, 671)) || (pcBoxJ4T6.Location == new Point(723, 671 - (51 * 10)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 9)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 8)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 7)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 6)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 5)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 4)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 3)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 2)) && pcBoxJ4T6.Location == new Point(723, 671 - (51)) && pcBoxJ4T6.Location == new Point(723, 671)) || (pcBoxJ1T6.Location == new Point(705, (658 - 459) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 408) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 357) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 306) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 255) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 204) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 153) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 102) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 51) - 51) && pcBoxJ1T6.Location == new Point(705, 658 - 51) && pcBoxJ1T6.Location == new Point(705, 658)) || (pcBoxJ2T6.Location == new Point(725, 658 - (51 * 10)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 9)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 8)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 7)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 6)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 5)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 4)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 3)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 2)) && pcBoxJ2T6.Location == new Point(725, 658 - (51)) && pcBoxJ2T6.Location == new Point(725, 658)) || (pcBoxJ3T6.Location == new Point(703, 671 - (51 * 10)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 9)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 8)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 7)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 6)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 5)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 4)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 3)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 2)) && pcBoxJ3T6.Location == new Point(703, 671 - (51)) && pcBoxJ3T6.Location == new Point(703, 671)) || (pcBoxJ4T6.Location == new Point(723, 671 - (51 * 10)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 9)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 8)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 7)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 6)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 5)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 4)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 3)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 2)) && pcBoxJ4T6.Location == new Point(723, 671 - (51)) && pcBoxJ4T6.Location == new Point(723, 671)) || (pcBoxJ1T7.Location == new Point(771, (710 - 561) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 510) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 459) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 408) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 357) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 306) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 255) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 204) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 153) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 102) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 51) - 51) && pcBoxJ1T7.Location == new Point(771, 710 - 51) && pcBoxJ1T7.Location == new Point(771, 710)) || (pcBoxJ2T7.Location == new Point(791, 710 - (51 * 12)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 11)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 10)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 9)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 8)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 7)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 6)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 5)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 4)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 3)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 2)) && pcBoxJ2T7.Location == new Point(791, 710 - (51)) && pcBoxJ2T7.Location == new Point(791, 710)) || (pcBoxJ3T7.Location == new Point(770, 723 - (51 * 12)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 11)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 10)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 9)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 8)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 7)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 6)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 5)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 4)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 3)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 2)) && pcBoxJ3T7.Location == new Point(770, 723 - (51)) && pcBoxJ3T7.Location == new Point(770, 723)) || (pcBoxJ4T7.Location == new Point(787, 723 - (51 * 12)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 11)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 10)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 9)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 8)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 7)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 6)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 5)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 4)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 3)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 2)) && pcBoxJ4T7.Location == new Point(787, 723 - (51)) && pcBoxJ4T7.Location == new Point(787, 723)) || (pcBoxJ1T8.Location == new Point(837, (658 - 459) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 408) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 357) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 306) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 255) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 204) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 153) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 102) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 51) - 51) && pcBoxJ1T8.Location == new Point(837, 658 - 51) && pcBoxJ1T8.Location == new Point(837, 658)) || (pcBoxJ2T8.Location == new Point(857, 658 - (51 * 10)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 9)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 8)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 7)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 6)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 5)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 4)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 3)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 2)) && pcBoxJ2T8.Location == new Point(857, 658 - (51)) && pcBoxJ2T8.Location == new Point(857, 658)) || (pcBoxJ3T8.Location == new Point(836, 671 - (51 * 10)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 9)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 8)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 7)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 6)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 5)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 4)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 3)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 2)) && pcBoxJ3T8.Location == new Point(836, 671 - (51)) && pcBoxJ3T8.Location == new Point(836, 671)) || (pcBoxJ4T8.Location == new Point(856, 671 - (51 * 10)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 9)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 8)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 7)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 6)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 5)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 4)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 3)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 2)) && pcBoxJ4T8.Location == new Point(856, 671 - (51)) && pcBoxJ4T8.Location == new Point(856, 671)) || (pcBoxJ1T9.Location == new Point(900, (608 - 357) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 306) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 255) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 204) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 153) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 102) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 51) - 51) && pcBoxJ1T9.Location == new Point(900, 608 - 51) && pcBoxJ1T9.Location == new Point(900, 608)) || (pcBoxJ2T9.Location == new Point(920, 608 - (51 * 8)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 7)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 6)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 5)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 4)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 3)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 2)) && pcBoxJ2T9.Location == new Point(920, 608 - (51)) && pcBoxJ2T9.Location == new Point(920, 608)) || (pcBoxJ3T9.Location == new Point(897, 618 - (51 * 8)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 7)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 6)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 5)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 4)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 3)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 2)) && pcBoxJ3T9.Location == new Point(897, 618 - (51)) && pcBoxJ3T9.Location == new Point(897, 618)) || (pcBoxJ4T9.Location == new Point(917, 618 - (51 * 8)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 7)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 6)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 5)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 4)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 3)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 2)) && pcBoxJ4T9.Location == new Point(917, 618 - (51)) && pcBoxJ4T9.Location == new Point(917, 618)) || (pcBoxJ1T10.Location == new Point(967, (559 - 255) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 204) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 153) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 102) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 51) - 51) && pcBoxJ1T10.Location == new Point(967, 559 - 51) && pcBoxJ1T10.Location == new Point(967, 559)) || (pcBoxJ2T10.Location == new Point(987, 559 - (51 * 6)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 5)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 4)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 3)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 2)) && pcBoxJ2T10.Location == new Point(987, 559 - (51)) && pcBoxJ2T10.Location == new Point(987, 559)) || (pcBoxJ3T10.Location == new Point(966, 572 - (51 * 6)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 5)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 4)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 3)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 2)) && pcBoxJ3T10.Location == new Point(966, 572 - (51)) && pcBoxJ3T10.Location == new Point(966, 572)) || (pcBoxJ4T10.Location == new Point(986, 572 - (51 * 6)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 5)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 4)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 3)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 2)) && pcBoxJ4T10.Location == new Point(986, 572 - (51)) && pcBoxJ4T10.Location == new Point(986, 572)) || (pcBoxJ1T11.Location == new Point(1031, (504 - 153) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 102) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 51) - 51) && pcBoxJ1T11.Location == new Point(1031, 504 - 51) && pcBoxJ1T11.Location == new Point(1031, 504)) || (pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 4)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 3)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 2)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51)) && pcBoxJ2T11.Location == new Point(1051, 504)) || (pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 4)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 3)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 2)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51)) && pcBoxJ3T11.Location == new Point(1036, 518)) || (pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 4)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 3)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 2)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51)) && pcBoxJ4T11.Location == new Point(1056, 518)) || (pcBoxJ1T12.Location == new Point(1097, (455 - 51) - 51) && pcBoxJ1T12.Location == new Point(1097, 455 - 51) && pcBoxJ1T12.Location == new Point(1097, 455)) || (pcBoxJ2T12.Location == new Point(1117, 455 - (51 * 2)) && pcBoxJ2T12.Location == new Point(1117, 455 - (51)) && pcBoxJ2T12.Location == new Point(1117, 455)) || (pcBoxJ3T12.Location == new Point(1097, 470 - (51 * 2)) && pcBoxJ3T12.Location == new Point(1097, 470 - (51)) && pcBoxJ3T12.Location == new Point(1097, 470)) || (pcBoxJ4T12.Location == new Point(1117, 470 - (51 * 2)) && pcBoxJ4T12.Location == new Point(1117, 470 - (51)) && pcBoxJ4T12.Location == new Point(1117, 470)))
                        //{


                        //if ((pcBoxJ1T2.Location == new Point(446, 455) && pcBoxJ1T2.Location == new Point(446, 455 - 51) && pcBoxJ1T2.Location == new Point(446, (455 - 51) - 51) || (pcBoxJ2T2.Location == new Point(461, 455 - (51 * 2)) && pcBoxJ2T2.Location == new Point(461, 455 - 51) && pcBoxJ2T2.Location == new Point(461, 455)) || (pcBoxJ3T2.Location == new Point(446, 471 - (51 * 2)) && pcBoxJ3T2.Location == new Point(446, 471 - (51)) && pcBoxJ3T2.Location == new Point(446, 471)) || (pcBoxJ4T2.Location == new Point(466, 471 - (51 * 2)) && pcBoxJ4T2.Location == new Point(466, 471 - (51)) && pcBoxJ4T2.Location == new Point(466, 471))) || (pcBoxJ1T3.Location == new Point(507, (504 - 153) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 102) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 51) - 51) && pcBoxJ1T3.Location == new Point(507, 504 - 51) && pcBoxJ1T3.Location == new Point(507, 504) || (pcBoxJ2T3.Location == new Point(527, 504 - (51 * 4)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 3)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 2)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 1)) && pcBoxJ2T3.Location == new Point(527, 504)) || (pcBoxJ3T3.Location == new Point(506, 521 - (51 * 4)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 3)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 2)) && pcBoxJ3T3.Location == new Point(506, 521 - (51)) && pcBoxJ3T3.Location == new Point(506, 521)) || (pcBoxJ1T5.Location == new Point(639, (608 - 357) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 306) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 255) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 204) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 153) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 102) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 51) - 51) && pcBoxJ1T5.Location == new Point(639, 608 - 51) && pcBoxJ1T5.Location == new Point(639, 608) || (pcBoxJ2T5.Location == new Point(659, 608 - (51 * 8)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 7)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 6)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 5)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 4)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 3)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 2)) && pcBoxJ2T5.Location == new Point(659, 608 - (51)) && pcBoxJ2T5.Location == new Point(659, 608)) || (pcBoxJ3T5.Location == new Point(639, 620 - (51 * 8)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 7)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 6)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 5)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 4)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 3)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 2)) && pcBoxJ3T5.Location == new Point(639, 620 - (51)) && pcBoxJ3T5.Location == new Point(639, 620)) || (pcBoxJ4T5.Location == new Point(659, 620 - (51 * 8)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 7)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 6)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 5)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 4)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 3)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 2)) && pcBoxJ4T5.Location == new Point(659, 620 - (51)) && pcBoxJ4T5.Location == new Point(659, 620))) || (pcBoxJ1T6.Location == new Point(705, (658 - 459) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 408) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 357) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 306) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 255) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 204) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 153) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 102) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 51) - 51) && pcBoxJ1T6.Location == new Point(705, 658 - 51) && pcBoxJ1T6.Location == new Point(705, 658) || (pcBoxJ2T6.Location == new Point(725, 658 - (51 * 10)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 9)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 8)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 7)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 6)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 5)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 4)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 3)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 2)) && pcBoxJ2T6.Location == new Point(725, 658 - (51)) && pcBoxJ2T6.Location == new Point(725, 658)) || (pcBoxJ3T6.Location == new Point(703, 671 - (51 * 10)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 9)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 8)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 7)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 6)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 5)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 4)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 3)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 2)) && pcBoxJ3T6.Location == new Point(703, 671 - (51)) && pcBoxJ3T6.Location == new Point(703, 671)) || (pcBoxJ4T6.Location == new Point(723, 671 - (51 * 10)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 9)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 8)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 7)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 6)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 5)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 4)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 3)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 2)) && pcBoxJ4T6.Location == new Point(723, 671 - (51)) && pcBoxJ4T6.Location == new Point(723, 671))) || (pcBoxJ1T6.Location == new Point(705, (658 - 459) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 408) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 357) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 306) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 255) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 204) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 153) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 102) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 51) - 51) && pcBoxJ1T6.Location == new Point(705, 658 - 51) && pcBoxJ1T6.Location == new Point(705, 658) || (pcBoxJ2T6.Location == new Point(725, 658 - (51 * 10)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 9)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 8)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 7)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 6)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 5)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 4)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 3)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 2)) && pcBoxJ2T6.Location == new Point(725, 658 - (51)) && pcBoxJ2T6.Location == new Point(725, 658)) || (pcBoxJ3T6.Location == new Point(703, 671 - (51 * 10)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 9)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 8)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 7)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 6)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 5)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 4)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 3)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 2)) && pcBoxJ3T6.Location == new Point(703, 671 - (51)) && pcBoxJ3T6.Location == new Point(703, 671)) || (pcBoxJ4T6.Location == new Point(723, 671 - (51 * 10)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 9)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 8)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 7)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 6)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 5)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 4)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 3)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 2)) && pcBoxJ4T6.Location == new Point(723, 671 - (51)) && pcBoxJ4T6.Location == new Point(723, 671))) || (pcBoxJ1T7.Location == new Point(771, (710 - 561) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 510) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 459) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 408) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 357) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 306) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 255) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 204) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 153) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 102) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 51) - 51) && pcBoxJ1T7.Location == new Point(771, 710 - 51) && pcBoxJ1T7.Location == new Point(771, 710) || (pcBoxJ2T7.Location == new Point(791, 710 - (51 * 12)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 11)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 10)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 9)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 8)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 7)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 6)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 5)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 4)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 3)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 2)) && pcBoxJ2T7.Location == new Point(791, 710 - (51)) && pcBoxJ2T7.Location == new Point(791, 710)) || (pcBoxJ3T7.Location == new Point(770, 723 - (51 * 12)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 11)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 10)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 9)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 8)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 7)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 6)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 5)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 4)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 3)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 2)) && pcBoxJ3T7.Location == new Point(770, 723 - (51)) && pcBoxJ3T7.Location == new Point(770, 723) || (pcBoxJ4T7.Location == new Point(787, 723 - (51 * 12)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 11)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 10)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 9)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 8)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 7)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 6)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 5)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 4)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 3)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 2)) && pcBoxJ4T7.Location == new Point(787, 723 - (51)) && pcBoxJ4T7.Location == new Point(787, 723))) || (pcBoxJ1T8.Location == new Point(837, (658 - 459) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 408) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 357) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 306) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 255) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 204) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 153) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 102) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 51) - 51) && pcBoxJ1T8.Location == new Point(837, 658 - 51) && pcBoxJ1T8.Location == new Point(837, 658) || (pcBoxJ2T8.Location == new Point(857, 658 - (51 * 10)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 9)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 8)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 7)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 6)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 5)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 4)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 3)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 2)) && pcBoxJ2T8.Location == new Point(857, 658 - (51)) && pcBoxJ2T8.Location == new Point(857, 658)) || (pcBoxJ3T8.Location == new Point(836, 671 - (51 * 10)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 9)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 8)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 7)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 6)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 5)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 4)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 3)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 2)) && pcBoxJ3T8.Location == new Point(836, 671 - (51)) && pcBoxJ3T8.Location == new Point(836, 671)) || (pcBoxJ4T8.Location == new Point(856, 671 - (51 * 10)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 9)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 8)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 7)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 6)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 5)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 4)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 3)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 2)) && pcBoxJ4T8.Location == new Point(856, 671 - (51)) && pcBoxJ4T8.Location == new Point(856, 671))) || (pcBoxJ1T9.Location == new Point(900, (608 - 357) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 306) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 255) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 204) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 153) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 102) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 51) - 51) && pcBoxJ1T9.Location == new Point(900, 608 - 51) && pcBoxJ1T9.Location == new Point(900, 608) || (pcBoxJ2T9.Location == new Point(920, 608 - (51 * 8)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 7)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 6)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 5)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 4)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 3)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 2)) && pcBoxJ2T9.Location == new Point(920, 608 - (51)) && pcBoxJ2T9.Location == new Point(920, 608)) || (pcBoxJ3T9.Location == new Point(897, 618 - (51 * 8)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 7)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 6)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 5)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 4)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 3)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 2)) && pcBoxJ3T9.Location == new Point(897, 618 - (51)) && pcBoxJ3T9.Location == new Point(897, 618)) || (pcBoxJ4T9.Location == new Point(917, 618 - (51 * 8)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 7)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 6)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 5)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 4)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 3)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 2)) && pcBoxJ4T9.Location == new Point(917, 618 - (51)) && pcBoxJ4T9.Location == new Point(917, 618))) || (pcBoxJ1T10.Location == new Point(967, (559 - 255) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 204) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 153) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 102) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 51) - 51) && pcBoxJ1T10.Location == new Point(967, 559 - 51) && pcBoxJ1T10.Location == new Point(967, 559) || (pcBoxJ2T10.Location == new Point(987, 559 - (51 * 6)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 5)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 4)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 3)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 2)) && pcBoxJ2T10.Location == new Point(987, 559 - (51)) && pcBoxJ2T10.Location == new Point(987, 559)) || (pcBoxJ3T10.Location == new Point(966, 572 - (51 * 6)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 5)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 4)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 3)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 2)) && pcBoxJ3T10.Location == new Point(966, 572 - (51)) && pcBoxJ3T10.Location == new Point(966, 572)) || (pcBoxJ4T10.Location == new Point(986, 572 - (51 * 6)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 5)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 4)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 3)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 2)) && pcBoxJ4T10.Location == new Point(986, 572 - (51)) && pcBoxJ4T10.Location == new Point(986, 572))) || (pcBoxJ1T11.Location == new Point(1031, (504 - 153) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 102) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 51) - 51) && pcBoxJ1T11.Location == new Point(1031, 504 - 51) && pcBoxJ1T11.Location == new Point(1031, 504) || (pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 4)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 3)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 2)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51)) && pcBoxJ2T11.Location == new Point(1051, 504)) || (pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 4)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 3)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 2)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51)) && pcBoxJ3T11.Location == new Point(1036, 518)) || (pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 4)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 3)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 2)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51)) && pcBoxJ4T11.Location == new Point(1056, 518))) || (pcBoxJ1T12.Location == new Point(1097, (455 - 51) - 51) && pcBoxJ1T12.Location == new Point(1097, 455 - 51) && pcBoxJ1T12.Location == new Point(1097, 455) || (pcBoxJ2T12.Location == new Point(1117, 455 - (51 * 2)) && pcBoxJ2T12.Location == new Point(1117, 455 - (51)) && pcBoxJ2T12.Location == new Point(1117, 455)) || (pcBoxJ3T12.Location == new Point(1097, 470 - (51 * 2)) && pcBoxJ3T12.Location == new Point(1097, 470 - (51)) && pcBoxJ3T12.Location == new Point(1097, 470)) || (pcBoxJ4T12.Location == new Point(1117, 470 - (51 * 2)) && pcBoxJ4T12.Location == new Point(1117, 470 - (51)) && pcBoxJ4T12.Location == new Point(1117, 470))))))
                        //{
                        //if (pcBoxJ1T4.Location == new Point(574, (559 - 255) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 204) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 153) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 102) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 51) - 51) && pcBoxJ1T4.Location == new Point(574, 559 - 51) && pcBoxJ1T4.Location == new Point(574, 559) || (pcBoxJ2T4.Location == new Point(594, 559 - (51 * 6))&&pcBoxJ2T4.Location == new Point(594, 559 - (51 * 5))&&pcBoxJ2T4.Location == new Point(594, 559 - (51 * 4))&& pcBoxJ2T4.Location == new Point(594, 559 - (51 * 3))&&pcBoxJ2T4.Location == new Point(594, 559 - (51 * 2))&&pcBoxJ2T4.Location == new Point(594, 559 - 51)&&pcBoxJ2T4.Location == new Point(594, 559)) || (pcBoxJ3T4.Location == new Point(574, 570 - (51 * 6))&& pcBoxJ3T4.Location == new Point(574, 570 - (51 * 5))&& pcBoxJ3T4.Location == new Point(574, 570 - (51 * 4))&& pcBoxJ3T4.Location == new Point(574, 570 - (51 * 3))&& pcBoxJ3T4.Location == new Point(574, 570 - (51 * 2))&& pcBoxJ3T4.Location == new Point(574, 570 - (51))&& pcBoxJ3T4.Location == new Point(574, 570)) || (pcBoxJ4T4.Location == new Point(594, 570 - (51 * 6))&&pcBoxJ4T4.Location == new Point(594, 570 - (51 * 5))&& pcBoxJ4T4.Location == new Point(594, 570 - (51 * 4))&& pcBoxJ4T4.Location == new Point(594, 570 - (51 * 3))&& pcBoxJ4T4.Location == new Point(594, 570 - (51 * 2))&& pcBoxJ4T4.Location == new Point(594, 570 - (51))&&pcBoxJ4T4.Location == new Point(594, 570)))
                        //{
                        //    if (dado.Dado1 + dado.Dado3 == 4 || dado.Dado2 + dado.Dado4 == 4)
                        //    {
                        //        string ordem = "1324";
                        //        int R1 = dado.Dado1 + dado.Dado3;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        string result = Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        if (result.Substring(0, 4) == "ERRO")
                        //        {
                        //            Jogo.Mover(IdJogador, senhajogador, "2413", linha3);
                        //        }
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado1 + dado.Dado4 == 4 || dado.Dado2 + dado.Dado3 == 4)
                        //    {
                        //        string ordem = "1423";
                        //        int R1 = dado.Dado1 + dado.Dado4;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        string result = Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        if (result.Substring(0, 4) == "ERRO")
                        //        {
                        //            Jogo.Mover(IdJogador, senhajogador, "2413", linha3);
                        //        }
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado1 + dado.Dado2 == 4 || dado.Dado3 + dado.Dado4 == 4)
                        //    {
                        //        string ordem = "1234";
                        //        int R1 = dado.Dado1 + dado.Dado2;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        string result = Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        if (result.Substring(0, 4) == "ERRO")
                        //        {
                        //            Jogo.Mover(IdJogador, senhajogador, "2413", linha3);
                        //        }
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado2 + dado.Dado3 == 4 || dado.Dado1 + dado.Dado4 == 4)
                        //    {
                        //        string ordem = "2314";
                        //        int R1 = dado.Dado2 + dado.Dado3;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        string result = Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        if (result.Substring(0, 4) == "ERRO")
                        //        {
                        //            Jogo.Mover(IdJogador, senhajogador, "2413", linha3);
                        //        }
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado2 + dado.Dado4 == 4 || dado.Dado1 + dado.Dado3 == 4)
                        //    {
                        //        string ordem = "2413";
                        //        int R1 = dado.Dado2 + dado.Dado4;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado3 + dado.Dado4 == 4 || dado.Dado1 + dado.Dado2 == 4)
                        //    {
                        //        string ordem = "3412";
                        //        int R1 = dado.Dado3 + dado.Dado4;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //}



                        //if (dado.Dado1 + dado.Dado4 == 4 || dado.Dado2 + dado.Dado3 == 4)
                        //{

                        //    string ordem = "1423";
                        //    int R1 = dado.Dado1 + dado.Dado4;
                        //    int R2 = dado.Dado2 + dado.Dado3;
                        //    string v1 = R1.ToString();
                        //    string v2 = R2.ToString();
                        //    if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //    if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //    string linha3 = v1 + v2;
                        //    string result = Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //    if (result.Substring(0, 4) == "ERRO")
                        //    {
                        //        Jogo.Mover(IdJogador, senhajogador, "2413", linha3);
                        //    }
                        //    Jogo.Parar(IdJogador, senhajogador);
                        //    goto Fim;
                        //}

                        //if (dado.Dado1 + dado.Dado2 == 4 || dado.Dado3 + dado.Dado4 == 4)
                        //{

                        //    string ordem = "1234";
                        //    int R1 = dado.Dado1 + dado.Dado2;
                        //    int R2 = dado.Dado3 + dado.Dado4;
                        //    string v1 = R1.ToString();
                        //    string v2 = R2.ToString();
                        //    if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //    if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //    string linha3 = v1 + v2;
                        //    string result = Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //    if (result.Substring(0, 4) == "ERRO")
                        //    {
                        //        Jogo.Mover(IdJogador, senhajogador, "2413", linha3);
                        //    }
                        //    Jogo.Parar(IdJogador, senhajogador);
                        //    goto Fim;
                        //}

                        //trilha 5
                        //if ((pcBoxJ1T2.Location == new Point(446, 455) && pcBoxJ1T2.Location == new Point(446, 455 - 51) && pcBoxJ1T2.Location == new Point(446, (455 - 51) - 51) || (pcBoxJ2T2.Location == new Point(461, 455 - (51 * 2)) && pcBoxJ2T2.Location == new Point(461, 455 - 51) && pcBoxJ2T2.Location == new Point(461, 455)) || (pcBoxJ3T2.Location == new Point(446, 471 - (51 * 2)) && pcBoxJ3T2.Location == new Point(446, 471 - (51)) && pcBoxJ3T2.Location == new Point(446, 471)) || (pcBoxJ4T2.Location == new Point(466, 471 - (51 * 2)) && pcBoxJ4T2.Location == new Point(466, 471 - (51)) && pcBoxJ4T2.Location == new Point(466, 471))) || (pcBoxJ1T3.Location == new Point(507, (504 - 153) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 102) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 51) - 51) && pcBoxJ1T3.Location == new Point(507, 504 - 51) && pcBoxJ1T3.Location == new Point(507, 504) || (pcBoxJ2T3.Location == new Point(527, 504 - (51 * 4)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 3)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 2)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 1)) && pcBoxJ2T3.Location == new Point(527, 504)) || (pcBoxJ3T3.Location == new Point(506, 521 - (51 * 4)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 3)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 2)) && pcBoxJ3T3.Location == new Point(506, 521 - (51)) && pcBoxJ3T3.Location == new Point(506, 521)) || (pcBoxJ1T4.Location == new Point(574, (559 - 255) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 204) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 153) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 102) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 51) - 51) && pcBoxJ1T4.Location == new Point(574, 559 - 51) && pcBoxJ1T4.Location == new Point(574, 559) || (pcBoxJ2T4.Location == new Point(594, 559 - (51 * 6)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 5)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 4)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 3)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 2)) && pcBoxJ2T4.Location == new Point(594, 559 - 51) && pcBoxJ2T4.Location == new Point(594, 559)) || (pcBoxJ3T4.Location == new Point(574, 570 - (51 * 6)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 5)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 4)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 3)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 2)) && pcBoxJ3T4.Location == new Point(574, 570 - (51)) && pcBoxJ3T4.Location == new Point(574, 570)) || (pcBoxJ4T4.Location == new Point(594, 570 - (51 * 6)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 5)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 4)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 3)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 2)) && pcBoxJ4T4.Location == new Point(594, 570 - (51)) && pcBoxJ4T4.Location == new Point(594, 570))) || (pcBoxJ1T6.Location == new Point(705, (658 - 459) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 408) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 357) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 306) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 255) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 204) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 153) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 102) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 51) - 51) && pcBoxJ1T6.Location == new Point(705, 658 - 51) && pcBoxJ1T6.Location == new Point(705, 658) || (pcBoxJ2T6.Location == new Point(725, 658 - (51 * 10)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 9)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 8)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 7)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 6)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 5)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 4)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 3)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 2)) && pcBoxJ2T6.Location == new Point(725, 658 - (51)) && pcBoxJ2T6.Location == new Point(725, 658)) || (pcBoxJ3T6.Location == new Point(703, 671 - (51 * 10)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 9)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 8)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 7)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 6)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 5)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 4)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 3)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 2)) && pcBoxJ3T6.Location == new Point(703, 671 - (51)) && pcBoxJ3T6.Location == new Point(703, 671)) || (pcBoxJ4T6.Location == new Point(723, 671 - (51 * 10)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 9)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 8)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 7)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 6)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 5)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 4)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 3)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 2)) && pcBoxJ4T6.Location == new Point(723, 671 - (51)) && pcBoxJ4T6.Location == new Point(723, 671))) || (pcBoxJ1T6.Location == new Point(705, (658 - 459) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 408) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 357) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 306) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 255) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 204) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 153) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 102) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 51) - 51) && pcBoxJ1T6.Location == new Point(705, 658 - 51) && pcBoxJ1T6.Location == new Point(705, 658) || (pcBoxJ2T6.Location == new Point(725, 658 - (51 * 10)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 9)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 8)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 7)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 6)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 5)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 4)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 3)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 2)) && pcBoxJ2T6.Location == new Point(725, 658 - (51)) && pcBoxJ2T6.Location == new Point(725, 658)) || (pcBoxJ3T6.Location == new Point(703, 671 - (51 * 10)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 9)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 8)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 7)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 6)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 5)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 4)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 3)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 2)) && pcBoxJ3T6.Location == new Point(703, 671 - (51)) && pcBoxJ3T6.Location == new Point(703, 671)) || (pcBoxJ4T6.Location == new Point(723, 671 - (51 * 10)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 9)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 8)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 7)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 6)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 5)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 4)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 3)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 2)) && pcBoxJ4T6.Location == new Point(723, 671 - (51)) && pcBoxJ4T6.Location == new Point(723, 671))) || (pcBoxJ1T7.Location == new Point(771, (710 - 561) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 510) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 459) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 408) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 357) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 306) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 255) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 204) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 153) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 102) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 51) - 51) && pcBoxJ1T7.Location == new Point(771, 710 - 51) && pcBoxJ1T7.Location == new Point(771, 710) || (pcBoxJ2T7.Location == new Point(791, 710 - (51 * 12)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 11)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 10)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 9)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 8)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 7)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 6)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 5)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 4)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 3)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 2)) && pcBoxJ2T7.Location == new Point(791, 710 - (51)) && pcBoxJ2T7.Location == new Point(791, 710)) || (pcBoxJ3T7.Location == new Point(770, 723 - (51 * 12)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 11)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 10)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 9)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 8)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 7)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 6)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 5)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 4)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 3)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 2)) && pcBoxJ3T7.Location == new Point(770, 723 - (51)) && pcBoxJ3T7.Location == new Point(770, 723) || (pcBoxJ4T7.Location == new Point(787, 723 - (51 * 12)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 11)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 10)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 9)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 8)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 7)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 6)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 5)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 4)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 3)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 2)) && pcBoxJ4T7.Location == new Point(787, 723 - (51)) && pcBoxJ4T7.Location == new Point(787, 723))) || (pcBoxJ1T8.Location == new Point(837, (658 - 459) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 408) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 357) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 306) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 255) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 204) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 153) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 102) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 51) - 51) && pcBoxJ1T8.Location == new Point(837, 658 - 51) && pcBoxJ1T8.Location == new Point(837, 658) || (pcBoxJ2T8.Location == new Point(857, 658 - (51 * 10)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 9)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 8)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 7)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 6)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 5)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 4)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 3)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 2)) && pcBoxJ2T8.Location == new Point(857, 658 - (51)) && pcBoxJ2T8.Location == new Point(857, 658)) || (pcBoxJ3T8.Location == new Point(836, 671 - (51 * 10)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 9)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 8)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 7)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 6)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 5)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 4)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 3)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 2)) && pcBoxJ3T8.Location == new Point(836, 671 - (51)) && pcBoxJ3T8.Location == new Point(836, 671)) || (pcBoxJ4T8.Location == new Point(856, 671 - (51 * 10)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 9)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 8)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 7)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 6)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 5)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 4)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 3)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 2)) && pcBoxJ4T8.Location == new Point(856, 671 - (51)) && pcBoxJ4T8.Location == new Point(856, 671))) || (pcBoxJ1T9.Location == new Point(900, (608 - 357) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 306) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 255) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 204) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 153) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 102) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 51) - 51) && pcBoxJ1T9.Location == new Point(900, 608 - 51) && pcBoxJ1T9.Location == new Point(900, 608) || (pcBoxJ2T9.Location == new Point(920, 608 - (51 * 8)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 7)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 6)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 5)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 4)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 3)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 2)) && pcBoxJ2T9.Location == new Point(920, 608 - (51)) && pcBoxJ2T9.Location == new Point(920, 608)) || (pcBoxJ3T9.Location == new Point(897, 618 - (51 * 8)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 7)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 6)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 5)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 4)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 3)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 2)) && pcBoxJ3T9.Location == new Point(897, 618 - (51)) && pcBoxJ3T9.Location == new Point(897, 618)) || (pcBoxJ4T9.Location == new Point(917, 618 - (51 * 8)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 7)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 6)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 5)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 4)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 3)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 2)) && pcBoxJ4T9.Location == new Point(917, 618 - (51)) && pcBoxJ4T9.Location == new Point(917, 618))) || (pcBoxJ1T10.Location == new Point(967, (559 - 255) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 204) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 153) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 102) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 51) - 51) && pcBoxJ1T10.Location == new Point(967, 559 - 51) && pcBoxJ1T10.Location == new Point(967, 559) || (pcBoxJ2T10.Location == new Point(987, 559 - (51 * 6)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 5)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 4)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 3)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 2)) && pcBoxJ2T10.Location == new Point(987, 559 - (51)) && pcBoxJ2T10.Location == new Point(987, 559)) || (pcBoxJ3T10.Location == new Point(966, 572 - (51 * 6)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 5)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 4)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 3)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 2)) && pcBoxJ3T10.Location == new Point(966, 572 - (51)) && pcBoxJ3T10.Location == new Point(966, 572)) || (pcBoxJ4T10.Location == new Point(986, 572 - (51 * 6)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 5)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 4)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 3)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 2)) && pcBoxJ4T10.Location == new Point(986, 572 - (51)) && pcBoxJ4T10.Location == new Point(986, 572))) || (pcBoxJ1T11.Location == new Point(1031, (504 - 153) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 102) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 51) - 51) && pcBoxJ1T11.Location == new Point(1031, 504 - 51) && pcBoxJ1T11.Location == new Point(1031, 504) || (pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 4)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 3)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 2)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51)) && pcBoxJ2T11.Location == new Point(1051, 504)) || (pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 4)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 3)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 2)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51)) && pcBoxJ3T11.Location == new Point(1036, 518)) || (pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 4)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 3)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 2)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51)) && pcBoxJ4T11.Location == new Point(1056, 518))) || (pcBoxJ1T12.Location == new Point(1097, (455 - 51) - 51) && pcBoxJ1T12.Location == new Point(1097, 455 - 51) && pcBoxJ1T12.Location == new Point(1097, 455) || (pcBoxJ2T12.Location == new Point(1117, 455 - (51 * 2)) && pcBoxJ2T12.Location == new Point(1117, 455 - (51)) && pcBoxJ2T12.Location == new Point(1117, 455)) || (pcBoxJ3T12.Location == new Point(1097, 470 - (51 * 2)) && pcBoxJ3T12.Location == new Point(1097, 470 - (51)) && pcBoxJ3T12.Location == new Point(1097, 470)) || (pcBoxJ4T12.Location == new Point(1117, 470 - (51 * 2)) && pcBoxJ4T12.Location == new Point(1117, 470 - (51)) && pcBoxJ4T12.Location == new Point(1117, 470))))))
                        //{




                        //if (pcBoxJ1T5.Location == new Point(639, (608 - 357) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 306) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 255) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 204) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 153) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 102) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 51) - 51) && pcBoxJ1T5.Location == new Point(639, 608 - 51) && pcBoxJ1T5.Location == new Point(639, 608) || (pcBoxJ2T5.Location == new Point(659, 608 - (51 * 8))&&pcBoxJ2T5.Location == new Point(659, 608 - (51 * 7))&&pcBoxJ2T5.Location == new Point(659, 608 - (51 * 6))&&pcBoxJ2T5.Location == new Point(659, 608 - (51 * 5))&& pcBoxJ2T5.Location == new Point(659, 608 - (51 * 4))&&pcBoxJ2T5.Location == new Point(659, 608 - (51 * 3))&& pcBoxJ2T5.Location == new Point(659, 608 - (51 * 2))&&pcBoxJ2T5.Location == new Point(659, 608 - (51))&& pcBoxJ2T5.Location == new Point(659, 608)) ||(pcBoxJ3T5.Location == new Point(639, 620 - (51 * 8))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 7))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 6))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 5))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 4))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 3))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 2))&& pcBoxJ3T5.Location == new Point(639, 620 - (51))&& pcBoxJ3T5.Location == new Point(639, 620)) ||(pcBoxJ4T5.Location == new Point(659, 620 - (51 * 8))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 7))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 6))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 5))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 4))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 3))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 2))&& pcBoxJ4T5.Location == new Point(659, 620 - (51))&& pcBoxJ4T5.Location == new Point(659, 620)))
                        //{
                        //    if (dado.Dado1 + dado.Dado3 == 5 || dado.Dado2 + dado.Dado4 == 5)
                        //    {

                        //        string ordem = "1324";
                        //        int R1 = dado.Dado1 + dado.Dado3;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }

                        //    if (dado.Dado1 + dado.Dado4 == 5 || dado.Dado2 + dado.Dado3 == 5)
                        //    {
                        //        string ordem = "1423";
                        //        int R1 = dado.Dado1 + dado.Dado4;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado1 + dado.Dado2 == 5 || dado.Dado3 + dado.Dado4 == 5)
                        //    {
                        //        string ordem = "1234";
                        //        int R1 = dado.Dado1 + dado.Dado2;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado2 + dado.Dado3 == 5 || dado.Dado1 + dado.Dado4 == 5)
                        //    {
                        //        string ordem = "2314";
                        //        int R1 = dado.Dado2 + dado.Dado3;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado2 + dado.Dado4 == 5 || dado.Dado1 + dado.Dado3 == 5)
                        //    {
                        //        string ordem = "2413";
                        //        int R1 = dado.Dado2 + dado.Dado4;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado3 + dado.Dado4 == 5 || dado.Dado1 + dado.Dado2 == 5)
                        //    {
                        //        string ordem = "3412";
                        //        int R1 = dado.Dado3 + dado.Dado4;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //}





                        

                        //if (dado.Dado1 + dado.Dado4 == 5 || dado.Dado2 + dado.Dado3 == 5)
                        //{

                        //    string ordem = "1423";
                        //    int R1 = dado.Dado1 + dado.Dado4;
                        //    int R2 = dado.Dado2 + dado.Dado3;
                        //    string v1 = R1.ToString();
                        //    string v2 = R2.ToString();
                        //    if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //    if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //    string linha3 = v1 + v2;
                        //    string result = Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //    if (result.Substring(0, 4) == "ERRO")
                        //    {
                        //        Jogo.Mover(IdJogador, senhajogador, "2413", linha3);
                        //    }
                        //    Jogo.Parar(IdJogador, senhajogador);
                        //    goto Fim;
                        //}

                        //if (dado.Dado1 + dado.Dado2 == 5 || dado.Dado3 + dado.Dado4 == 5)
                        //{

                        //    string ordem = "1234";
                        //    int R1 = dado.Dado1 + dado.Dado2;
                        //    int R2 = dado.Dado3 + dado.Dado4;
                        //    string v1 = R1.ToString();
                        //    string v2 = R2.ToString();
                        //    if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //    if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //    string linha3 = v1 + v2;
                        //    string result = Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //    if (result.Substring(0, 4) == "ERRO")
                        //    {
                        //        Jogo.Mover(IdJogador, senhajogador, "2413", linha3);
                        //    }
                        //    Jogo.Parar(IdJogador, senhajogador);
                        //    goto Fim;
                        //}
                        //trilha 6
                        //if ((pcBoxJ1T2.Location == new Point(446, 455) && pcBoxJ1T2.Location == new Point(446, 455 - 51) && pcBoxJ1T2.Location == new Point(446, (455 - 51) - 51) || (pcBoxJ2T2.Location == new Point(461, 455 - (51 * 2)) && pcBoxJ2T2.Location == new Point(461, 455 - 51) && pcBoxJ2T2.Location == new Point(461, 455)) || (pcBoxJ3T2.Location == new Point(446, 471 - (51 * 2)) && pcBoxJ3T2.Location == new Point(446, 471 - (51)) && pcBoxJ3T2.Location == new Point(446, 471)) || (pcBoxJ4T2.Location == new Point(466, 471 - (51 * 2)) && pcBoxJ4T2.Location == new Point(466, 471 - (51)) && pcBoxJ4T2.Location == new Point(466, 471))) || (pcBoxJ1T3.Location == new Point(507, (504 - 153) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 102) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 51) - 51) && pcBoxJ1T3.Location == new Point(507, 504 - 51) && pcBoxJ1T3.Location == new Point(507, 504) || (pcBoxJ2T3.Location == new Point(527, 504 - (51 * 4)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 3)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 2)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 1)) && pcBoxJ2T3.Location == new Point(527, 504)) || (pcBoxJ3T3.Location == new Point(506, 521 - (51 * 4)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 3)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 2)) && pcBoxJ3T3.Location == new Point(506, 521 - (51)) && pcBoxJ3T3.Location == new Point(506, 521)) || (pcBoxJ1T4.Location == new Point(574, (559 - 255) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 204) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 153) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 102) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 51) - 51) && pcBoxJ1T4.Location == new Point(574, 559 - 51) && pcBoxJ1T4.Location == new Point(574, 559) || (pcBoxJ2T4.Location == new Point(594, 559 - (51 * 6)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 5)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 4)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 3)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 2)) && pcBoxJ2T4.Location == new Point(594, 559 - 51) && pcBoxJ2T4.Location == new Point(594, 559)) || (pcBoxJ3T4.Location == new Point(574, 570 - (51 * 6)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 5)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 4)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 3)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 2)) && pcBoxJ3T4.Location == new Point(574, 570 - (51)) && pcBoxJ3T4.Location == new Point(574, 570)) || (pcBoxJ4T4.Location == new Point(594, 570 - (51 * 6)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 5)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 4)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 3)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 2)) && pcBoxJ4T4.Location == new Point(594, 570 - (51)) && pcBoxJ4T4.Location == new Point(594, 570)) || (pcBoxJ1T5.Location == new Point(639, (608 - 357) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 306) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 255) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 204) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 153) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 102) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 51) - 51) && pcBoxJ1T5.Location == new Point(639, 608 - 51) && pcBoxJ1T5.Location == new Point(639, 608) || (pcBoxJ2T5.Location == new Point(659, 608 - (51 * 8))&&pcBoxJ2T5.Location == new Point(659, 608 - (51 * 7))&&pcBoxJ2T5.Location == new Point(659, 608 - (51 * 6))&&pcBoxJ2T5.Location == new Point(659, 608 - (51 * 5))&& pcBoxJ2T5.Location == new Point(659, 608 - (51 * 4))&&pcBoxJ2T5.Location == new Point(659, 608 - (51 * 3))&& pcBoxJ2T5.Location == new Point(659, 608 - (51 * 2))&&pcBoxJ2T5.Location == new Point(659, 608 - (51))&& pcBoxJ2T5.Location == new Point(659, 608)) ||(pcBoxJ3T5.Location == new Point(639, 620 - (51 * 8))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 7))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 6))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 5))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 4))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 3))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 2))&& pcBoxJ3T5.Location == new Point(639, 620 - (51))&& pcBoxJ3T5.Location == new Point(639, 620)) ||(pcBoxJ4T5.Location == new Point(659, 620 - (51 * 8))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 7))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 6))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 5))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 4))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 3))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 2))&& pcBoxJ4T5.Location == new Point(659, 620 - (51))&& pcBoxJ4T5.Location == new Point(659, 620)) || (pcBoxJ1T5.Location == new Point(639, (608 - 357) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 306) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 255) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 204) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 153) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 102) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 51) - 51) && pcBoxJ1T5.Location == new Point(639, 608 - 51) && pcBoxJ1T5.Location == new Point(639, 608) || (pcBoxJ2T5.Location == new Point(659, 608 - (51 * 8))&&pcBoxJ2T5.Location == new Point(659, 608 - (51 * 7))&&pcBoxJ2T5.Location == new Point(659, 608 - (51 * 6))&&pcBoxJ2T5.Location == new Point(659, 608 - (51 * 5))&& pcBoxJ2T5.Location == new Point(659, 608 - (51 * 4))&&pcBoxJ2T5.Location == new Point(659, 608 - (51 * 3))&& pcBoxJ2T5.Location == new Point(659, 608 - (51 * 2))&&pcBoxJ2T5.Location == new Point(659, 608 - (51))&& pcBoxJ2T5.Location == new Point(659, 608)) ||(pcBoxJ3T5.Location == new Point(639, 620 - (51 * 8))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 7))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 6))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 5))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 4))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 3))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 2))&& pcBoxJ3T5.Location == new Point(639, 620 - (51))&& pcBoxJ3T5.Location == new Point(639, 620)) ||(pcBoxJ4T5.Location == new Point(659, 620 - (51 * 8))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 7))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 6))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 5))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 4))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 3))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 2))&& pcBoxJ4T5.Location == new Point(659, 620 - (51))&& pcBoxJ4T5.Location == new Point(659, 620))) || (pcBoxJ1T7.Location == new Point(771, (710 - 561) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 510) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 459) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 408) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 357) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 306) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 255) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 204) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 153) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 102) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 51) - 51)&&pcBoxJ1T7.Location == new Point(771, 710 - 51)&&pcBoxJ1T7.Location == new Point(771, 710) || (pcBoxJ2T7.Location == new Point(791, 710 - (51 * 12))&&pcBoxJ2T7.Location == new Point(791, 710 - (51 * 11))&&pcBoxJ2T7.Location == new Point(791, 710 - (51 * 10))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 9))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 8))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 7))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 6))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 5))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 4))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 3))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 2))&&pcBoxJ2T7.Location == new Point(791, 710 - (51))&&pcBoxJ2T7.Location == new Point(791, 710)) ||(pcBoxJ3T7.Location == new Point(770, 723 - (51 * 12))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 11))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 10))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 9))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 8))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 7))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 6))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 5))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 4))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 3))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 2))&& pcBoxJ3T7.Location == new Point(770, 723 - (51))&& pcBoxJ3T7.Location == new Point(770, 723) || (pcBoxJ4T7.Location == new Point(787, 723 - (51 * 12))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 11))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 10))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 9))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 8))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 7))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 6))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 5))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 4))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 3))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 2))&& pcBoxJ4T7.Location == new Point(787, 723 - (51))&& pcBoxJ4T7.Location == new Point(787, 723)))|| (pcBoxJ1T8.Location == new Point(837, (658 - 459) - 51)&& pcBoxJ1T8.Location == new Point(837, (658 - 408) - 51)&&pcBoxJ1T8.Location == new Point(837, (658 - 357) - 51)&& pcBoxJ1T8.Location == new Point(837, (658 - 306) - 51)&& pcBoxJ1T8.Location == new Point(837, (658 - 255) - 51)&&pcBoxJ1T8.Location == new Point(837, (658 - 204) - 51)&&pcBoxJ1T8.Location == new Point(837, (658 - 153) - 51)&& pcBoxJ1T8.Location == new Point(837, (658 - 102) - 51)&&pcBoxJ1T8.Location == new Point(837, (658 - 51) - 51)&& pcBoxJ1T8.Location == new Point(837, 658 - 51)&&pcBoxJ1T8.Location == new Point(837, 658) || (pcBoxJ2T8.Location == new Point(857, 658 - (51 * 10))&&pcBoxJ2T8.Location == new Point(857, 658 - (51 * 9))&&pcBoxJ2T8.Location == new Point(857, 658 - (51 * 8))&&pcBoxJ2T8.Location == new Point(857, 658 - (51 * 7))&&pcBoxJ2T8.Location == new Point(857, 658 - (51 * 6))&& pcBoxJ2T8.Location == new Point(857, 658 - (51 * 5))&&pcBoxJ2T8.Location == new Point(857, 658 - (51 * 4))&&pcBoxJ2T8.Location == new Point(857, 658 - (51 * 3))&&pcBoxJ2T8.Location == new Point(857, 658 - (51 * 2))&&pcBoxJ2T8.Location == new Point(857, 658 - (51))&& pcBoxJ2T8.Location == new Point(857, 658)) || (pcBoxJ3T8.Location == new Point(836, 671 - (51 * 10)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 9))&& pcBoxJ3T8.Location == new Point(836, 671 - (51 * 8))&& pcBoxJ3T8.Location == new Point(836, 671 - (51 * 7))&& pcBoxJ3T8.Location == new Point(836, 671 - (51 * 6))&& pcBoxJ3T8.Location == new Point(836, 671 - (51 * 5)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 4))&&pcBoxJ3T8.Location == new Point(836, 671 - (51 * 3))&& pcBoxJ3T8.Location == new Point(836, 671 - (51 * 2))&& pcBoxJ3T8.Location == new Point(836, 671 - (51))&& pcBoxJ3T8.Location == new Point(836, 671)) || (pcBoxJ4T8.Location == new Point(856, 671 - (51 * 10)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 9))&& pcBoxJ4T8.Location == new Point(856, 671 - (51 * 8))&& pcBoxJ4T8.Location == new Point(856, 671 - (51 * 7)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 6)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 5))&& pcBoxJ4T8.Location == new Point(856, 671 - (51 * 4)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 3)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 2)) && pcBoxJ4T8.Location == new Point(856, 671 - (51)) && pcBoxJ4T8.Location == new Point(856, 671))) || (pcBoxJ1T9.Location == new Point(900, (608 - 357) - 51)&& pcBoxJ1T9.Location == new Point(900, (608 - 306) - 51)&& pcBoxJ1T9.Location == new Point(900, (608 - 255) - 51)&& pcBoxJ1T9.Location == new Point(900, (608 - 204) - 51)&& pcBoxJ1T9.Location == new Point(900, (608 - 153) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 102) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 51) - 51)&& pcBoxJ1T9.Location == new Point(900, 608 - 51)&& pcBoxJ1T9.Location == new Point(900, 608) || (pcBoxJ2T9.Location == new Point(920, 608 - (51 * 8))&& pcBoxJ2T9.Location == new Point(920, 608 - (51 * 7))&&pcBoxJ2T9.Location == new Point(920, 608 - (51 * 6))&&pcBoxJ2T9.Location == new Point(920, 608 - (51 * 5))&&pcBoxJ2T9.Location == new Point(920, 608 - (51 * 4))&& pcBoxJ2T9.Location == new Point(920, 608 - (51 * 3))&& pcBoxJ2T9.Location == new Point(920, 608 - (51 * 2))&& pcBoxJ2T9.Location == new Point(920, 608 - (51))&&pcBoxJ2T9.Location == new Point(920, 608)) || (pcBoxJ3T9.Location == new Point(897, 618 - (51 * 8))&&pcBoxJ3T9.Location == new Point(897, 618 - (51 * 7))&&pcBoxJ3T9.Location == new Point(897, 618 - (51 * 6))&&pcBoxJ3T9.Location == new Point(897, 618 - (51 * 5))&&pcBoxJ3T9.Location == new Point(897, 618 - (51 * 4))&&pcBoxJ3T9.Location == new Point(897, 618 - (51 * 3))&&pcBoxJ3T9.Location == new Point(897, 618 - (51 * 2))&&pcBoxJ3T9.Location == new Point(897, 618 - (51))&& pcBoxJ3T9.Location == new Point(897, 618)) ||(pcBoxJ4T9.Location == new Point(917, 618 - (51 * 8)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 7))&& pcBoxJ4T9.Location == new Point(917, 618 - (51 * 6)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 5)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 4))&& pcBoxJ4T9.Location == new Point(917, 618 - (51 * 3)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 2)) && pcBoxJ4T9.Location == new Point(917, 618 - (51))&& pcBoxJ4T9.Location == new Point(917, 618))) || (pcBoxJ1T10.Location == new Point(967, (559 - 255) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 204) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 153) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 102) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 51) - 51) && pcBoxJ1T10.Location == new Point(967, 559 - 51) && pcBoxJ1T10.Location == new Point(967, 559) || (pcBoxJ2T10.Location == new Point(987, 559 - (51 * 6))&& pcBoxJ2T10.Location == new Point(987, 559 - (51 * 5))&& pcBoxJ2T10.Location == new Point(987, 559 - (51 * 4))&& pcBoxJ2T10.Location == new Point(987, 559 - (51 * 3))&& pcBoxJ2T10.Location == new Point(987, 559 - (51 * 2))&&pcBoxJ2T10.Location == new Point(987, 559 - (51))&&pcBoxJ2T10.Location == new Point(987, 559)) || (pcBoxJ3T10.Location == new Point(966, 572 - (51 * 6))&&pcBoxJ3T10.Location == new Point(966, 572 - (51 * 5))&& pcBoxJ3T10.Location == new Point(966, 572 - (51 * 4))&& pcBoxJ3T10.Location == new Point(966, 572 - (51 * 3))&&pcBoxJ3T10.Location == new Point(966, 572 - (51 * 2))&&pcBoxJ3T10.Location == new Point(966, 572 - (51))&& pcBoxJ3T10.Location == new Point(966, 572)) || (pcBoxJ4T10.Location == new Point(986, 572 - (51 * 6))&& pcBoxJ4T10.Location == new Point(986, 572 - (51 * 5))&& pcBoxJ4T10.Location == new Point(986, 572 - (51 * 4))&& pcBoxJ4T10.Location == new Point(986, 572 - (51 * 3))&& pcBoxJ4T10.Location == new Point(986, 572 - (51 * 2))&& pcBoxJ4T10.Location == new Point(986, 572 - (51))&& pcBoxJ4T10.Location == new Point(986, 572))) || (pcBoxJ1T11.Location == new Point(1031, (504 - 153) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 102) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 51) - 51) && pcBoxJ1T11.Location == new Point(1031, 504 - 51) && pcBoxJ1T11.Location == new Point(1031, 504) || (pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 4))&&pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 3))&& pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 2))&& pcBoxJ2T11.Location == new Point(1051, 504 - (51))&&pcBoxJ2T11.Location == new Point(1051, 504))|| (pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 4))&& pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 3))&& pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 2))&& pcBoxJ3T11.Location == new Point(1036, 518 - (51))&& pcBoxJ3T11.Location == new Point(1036, 518)) || (pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 4))&& pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 3))&& pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 2))&& pcBoxJ4T11.Location == new Point(1056, 518 - (51))&& pcBoxJ4T11.Location == new Point(1056, 518))) || (pcBoxJ1T12.Location == new Point(1097, (455 - 51) - 51) && pcBoxJ1T12.Location == new Point(1097, 455 - 51) && pcBoxJ1T12.Location == new Point(1097, 455) || (pcBoxJ2T12.Location == new Point(1117, 455 - (51 * 2))&& pcBoxJ2T12.Location == new Point(1117, 455 - (51))&& pcBoxJ2T12.Location == new Point(1117, 455)) || (pcBoxJ3T12.Location == new Point(1097, 470 - (51 * 2))&& pcBoxJ3T12.Location == new Point(1097, 470 - (51))&& pcBoxJ3T12.Location == new Point(1097, 470)) || (pcBoxJ4T12.Location == new Point(1117, 470 - (51 * 2))&& pcBoxJ4T12.Location == new Point(1117, 470 - (51))&& pcBoxJ4T12.Location == new Point(1117, 470))))))))
                        //{

                        //if ((pcBoxJ1T2.Location == new Point(446, 455) && pcBoxJ1T2.Location == new Point(446, 455 - 51) && pcBoxJ1T2.Location == new Point(446, (455 - 51) - 51) || (pcBoxJ2T2.Location == new Point(461, 455 - (51 * 2)) && pcBoxJ2T2.Location == new Point(461, 455 - 51) && pcBoxJ2T2.Location == new Point(461, 455)) || (pcBoxJ3T2.Location == new Point(446, 471 - (51 * 2)) && pcBoxJ3T2.Location == new Point(446, 471 - (51)) && pcBoxJ3T2.Location == new Point(446, 471)) || (pcBoxJ4T2.Location == new Point(466, 471 - (51 * 2)) && pcBoxJ4T2.Location == new Point(466, 471 - (51)) && pcBoxJ4T2.Location == new Point(466, 471)) || (pcBoxJ1T3.Location == new Point(507, (504 - 153) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 102) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 51) - 51) && pcBoxJ1T3.Location == new Point(507, 504 - 51) && pcBoxJ1T3.Location == new Point(507, 504)) || (pcBoxJ2T3.Location == new Point(527, 504 - (51 * 4)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 3)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 2)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 1)) && pcBoxJ2T3.Location == new Point(527, 504)) || (pcBoxJ3T3.Location == new Point(506, 521 - (51 * 4)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 3)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 2)) && pcBoxJ3T3.Location == new Point(506, 521 - (51)) && pcBoxJ3T3.Location == new Point(506, 521)) || (pcBoxJ4T3.Location == new Point(526, 521 - (51 * 4)) && pcBoxJ4T3.Location == new Point(526, 521 - (51 * 3)) && pcBoxJ4T3.Location == new Point(526, 521 - (51 * 2)) && pcBoxJ4T3.Location == new Point(526, 521 - (51)) && pcBoxJ4T3.Location == new Point(526, 521)) || (pcBoxJ1T4.Location == new Point(574, (559 - 255) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 204) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 153) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 102) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 51) - 51) && pcBoxJ1T4.Location == new Point(574, 559 - 51) && pcBoxJ1T4.Location == new Point(574, 559) || (pcBoxJ2T4.Location == new Point(594, 559 - (51 * 6)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 5)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 4)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 3)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 2)) && pcBoxJ2T4.Location == new Point(594, 559 - 51) && pcBoxJ2T4.Location == new Point(594, 559)) || (pcBoxJ3T4.Location == new Point(574, 570 - (51 * 6)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 5)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 4)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 3)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 2)) && pcBoxJ3T4.Location == new Point(574, 570 - (51)) && pcBoxJ3T4.Location == new Point(574, 570)) || (pcBoxJ4T4.Location == new Point(594, 570 - (51 * 6)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 5)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 4)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 3)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 2)) && pcBoxJ4T4.Location == new Point(594, 570 - (51)) && pcBoxJ4T4.Location == new Point(594, 570)) ||  (pcBoxJ1T5.Location == new Point(639, (608 - 357) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 306) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 255) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 204) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 153) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 102) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 51) - 51) && pcBoxJ1T5.Location == new Point(639, 608 - 51) && pcBoxJ1T5.Location == new Point(639, 608) || (pcBoxJ2T5.Location == new Point(659, 608 - (51 * 8))&&pcBoxJ2T5.Location == new Point(659, 608 - (51 * 7))&&pcBoxJ2T5.Location == new Point(659, 608 - (51 * 6))&&pcBoxJ2T5.Location == new Point(659, 608 - (51 * 5))&& pcBoxJ2T5.Location == new Point(659, 608 - (51 * 4))&&pcBoxJ2T5.Location == new Point(659, 608 - (51 * 3))&& pcBoxJ2T5.Location == new Point(659, 608 - (51 * 2))&&pcBoxJ2T5.Location == new Point(659, 608 - (51))&& pcBoxJ2T5.Location == new Point(659, 608)) ||(pcBoxJ3T5.Location == new Point(639, 620 - (51 * 8))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 7))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 6))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 5))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 4))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 3))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 2))&& pcBoxJ3T5.Location == new Point(639, 620 - (51))&& pcBoxJ3T5.Location == new Point(639, 620)) ||(pcBoxJ4T5.Location == new Point(659, 620 - (51 * 8))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 7))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 6))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 5))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 4))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 3))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 2))&& pcBoxJ4T5.Location == new Point(659, 620 - (51))&& pcBoxJ4T5.Location == new Point(659, 620))|| (pcBoxJ1T7.Location == new Point(771, (710 - 561) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 510) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 459) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 408) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 357) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 306) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 255) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 204) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 153) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 102) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 51) - 51) && pcBoxJ1T7.Location == new Point(771, 710 - 51) && pcBoxJ1T7.Location == new Point(771, 710)) || (pcBoxJ2T7.Location == new Point(791, 710 - (51 * 12)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 11)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 10)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 9)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 8)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 7)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 6)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 5)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 4)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 3)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 2)) && pcBoxJ2T7.Location == new Point(791, 710 - (51)) && pcBoxJ2T7.Location == new Point(791, 710)) || (pcBoxJ3T7.Location == new Point(770, 723 - (51 * 12)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 11)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 10)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 9)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 8)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 7)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 6)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 5)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 4)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 3)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 2)) && pcBoxJ3T7.Location == new Point(770, 723 - (51)) && pcBoxJ3T7.Location == new Point(770, 723)) || (pcBoxJ4T7.Location == new Point(787, 723 - (51 * 12)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 11)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 10)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 9)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 8)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 7)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 6)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 5)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 4)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 3)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 2)) && pcBoxJ4T7.Location == new Point(787, 723 - (51)) && pcBoxJ4T7.Location == new Point(787, 723)) || (pcBoxJ1T8.Location == new Point(837, (658 - 459) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 408) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 357) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 306) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 255) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 204) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 153) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 102) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 51) - 51) && pcBoxJ1T8.Location == new Point(837, 658 - 51) && pcBoxJ1T8.Location == new Point(837, 658)) || (pcBoxJ2T8.Location == new Point(857, 658 - (51 * 10)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 9)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 8)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 7)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 6)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 5)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 4)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 3)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 2)) && pcBoxJ2T8.Location == new Point(857, 658 - (51)) && pcBoxJ2T8.Location == new Point(857, 658)) || (pcBoxJ3T8.Location == new Point(836, 671 - (51 * 10)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 9)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 8)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 7)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 6)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 5)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 4)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 3)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 2)) && pcBoxJ3T8.Location == new Point(836, 671 - (51)) && pcBoxJ3T8.Location == new Point(836, 671)) || (pcBoxJ4T8.Location == new Point(856, 671 - (51 * 10)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 9)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 8)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 7)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 6)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 5)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 4)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 3)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 2)) && pcBoxJ4T8.Location == new Point(856, 671 - (51)) && pcBoxJ4T8.Location == new Point(856, 671)) || (pcBoxJ1T9.Location == new Point(900, (608 - 357) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 306) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 255) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 204) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 153) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 102) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 51) - 51) && pcBoxJ1T9.Location == new Point(900, 608 - 51) && pcBoxJ1T9.Location == new Point(900, 608)) || (pcBoxJ2T9.Location == new Point(920, 608 - (51 * 8)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 7)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 6)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 5)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 4)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 3)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 2)) && pcBoxJ2T9.Location == new Point(920, 608 - (51)) && pcBoxJ2T9.Location == new Point(920, 608)) || (pcBoxJ3T9.Location == new Point(897, 618 - (51 * 8)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 7)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 6)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 5)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 4)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 3)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 2)) && pcBoxJ3T9.Location == new Point(897, 618 - (51)) && pcBoxJ3T9.Location == new Point(897, 618)) || (pcBoxJ4T9.Location == new Point(917, 618 - (51 * 8)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 7)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 6)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 5)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 4)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 3)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 2)) && pcBoxJ4T9.Location == new Point(917, 618 - (51)) && pcBoxJ4T9.Location == new Point(917, 618)) || (pcBoxJ1T10.Location == new Point(967, (559 - 255) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 204) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 153) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 102) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 51) - 51) && pcBoxJ1T10.Location == new Point(967, 559 - 51) && pcBoxJ1T10.Location == new Point(967, 559)) || (pcBoxJ2T10.Location == new Point(987, 559 - (51 * 6)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 5)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 4)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 3)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 2)) && pcBoxJ2T10.Location == new Point(987, 559 - (51)) && pcBoxJ2T10.Location == new Point(987, 559)) || (pcBoxJ3T10.Location == new Point(966, 572 - (51 * 6)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 5)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 4)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 3)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 2)) && pcBoxJ3T10.Location == new Point(966, 572 - (51)) && pcBoxJ3T10.Location == new Point(966, 572)) || (pcBoxJ4T10.Location == new Point(986, 572 - (51 * 6)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 5)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 4)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 3)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 2)) && pcBoxJ4T10.Location == new Point(986, 572 - (51)) && pcBoxJ4T10.Location == new Point(986, 572)) || (pcBoxJ1T11.Location == new Point(1031, (504 - 153) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 102) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 51) - 51) && pcBoxJ1T11.Location == new Point(1031, 504 - 51) && pcBoxJ1T11.Location == new Point(1031, 504)) || (pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 4)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 3)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 2)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51)) && pcBoxJ2T11.Location == new Point(1051, 504)) || (pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 4)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 3)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 2)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51)) && pcBoxJ3T11.Location == new Point(1036, 518))) || (pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 4)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 3)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 2)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51)) && pcBoxJ4T11.Location == new Point(1056, 518)) || (pcBoxJ1T12.Location == new Point(1097, (455 - 51) - 51) && pcBoxJ1T12.Location == new Point(1097, 455 - 51) && pcBoxJ1T12.Location == new Point(1097, 455)) || (pcBoxJ2T12.Location == new Point(1117, 455 - (51 * 2)) && pcBoxJ2T12.Location == new Point(1117, 455 - (51)) && pcBoxJ2T12.Location == new Point(1117, 455)) || (pcBoxJ3T12.Location == new Point(1097, 470 - (51 * 2)) && pcBoxJ3T12.Location == new Point(1097, 470 - (51)) && pcBoxJ3T12.Location == new Point(1097, 470)) || (pcBoxJ4T12.Location == new Point(1117, 470 - (51 * 2)) && pcBoxJ4T12.Location == new Point(1117, 470 - (51)) && pcBoxJ4T12.Location == new Point(1117, 470)))))
                        //{

                        //    //if (pcBoxJ1T6.Location == new Point(705, (658 - 459) - 51)&& pcBoxJ1T6.Location == new Point(705, (658 - 408) - 51)&& pcBoxJ1T6.Location == new Point(705, (658 - 357) - 51)&&pcBoxJ1T6.Location == new Point(705, (658 - 306) - 51)&&pcBoxJ1T6.Location == new Point(705, (658 - 255) - 51)&&pcBoxJ1T6.Location == new Point(705, (658 - 204) - 51)&&pcBoxJ1T6.Location == new Point(705, (658 - 153) - 51) &&  pcBoxJ1T6.Location == new Point(705, (658 - 102) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 51) - 51)&&pcBoxJ1T6.Location == new Point(705, 658 - 51)&&pcBoxJ1T6.Location == new Point(705, 658) || (pcBoxJ2T6.Location == new Point(725, 658 - (51 * 10))&& pcBoxJ2T6.Location == new Point(725, 658 - (51 * 9))&& pcBoxJ2T6.Location == new Point(725, 658 - (51 * 8))&&pcBoxJ2T6.Location == new Point(725, 658 - (51 * 7))&& pcBoxJ2T6.Location == new Point(725, 658 - (51 * 6))&& pcBoxJ2T6.Location == new Point(725, 658 - (51 * 5))&&pcBoxJ2T6.Location == new Point(725, 658 - (51 * 4))&& pcBoxJ2T6.Location == new Point(725, 658 - (51 * 3))&&pcBoxJ2T6.Location == new Point(725, 658 - (51 * 2))&&pcBoxJ2T6.Location == new Point(725, 658 - (51))&& pcBoxJ2T6.Location == new Point(725, 658)) || (pcBoxJ3T6.Location == new Point(703, 671 - (51 * 10))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 9))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 8))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 7))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 6))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 5))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 4))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 3))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 2))&& pcBoxJ3T6.Location == new Point(703, 671 - (51))&& pcBoxJ3T6.Location == new Point(703, 671)) || (pcBoxJ4T6.Location == new Point(723, 671 - (51 * 10))&&pcBoxJ4T6.Location == new Point(723, 671 - (51 * 9))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 8))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 7))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 6))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 5))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 4))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 3))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 2))&& pcBoxJ4T6.Location == new Point(723, 671 - (51))&& pcBoxJ4T6.Location == new Point(723, 671)))
                        //    //{
                        //    if (dado.Dado1 + dado.Dado3 == 6 || dado.Dado2 + dado.Dado4 == 6)
                        //    {
                        //        string ordem = "1324";
                        //        int R1 = dado.Dado1 + dado.Dado3;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado1 + dado.Dado4 == 6 || dado.Dado2 + dado.Dado3 == 6)
                        //    {
                        //        string ordem = "1423";
                        //        int R1 = dado.Dado1 + dado.Dado4;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado1 + dado.Dado2 == 6 || dado.Dado3 + dado.Dado4 == 6)
                        //    {
                        //        string ordem = "1234";
                        //        int R1 = dado.Dado1 + dado.Dado2;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado2 + dado.Dado3 == 6 || dado.Dado1 + dado.Dado4 == 6)
                        //    {
                        //        string ordem = "2314";
                        //        int R1 = dado.Dado2 + dado.Dado3;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado2 + dado.Dado4 == 6 || dado.Dado1 + dado.Dado3 == 6)
                        //    {
                        //        string ordem = "2413";
                        //        int R1 = dado.Dado2 + dado.Dado4;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado3 + dado.Dado4 == 6 || dado.Dado1 + dado.Dado2 == 6)
                        //    {
                        //        string ordem = "3412";
                        //        int R1 = dado.Dado3 + dado.Dado4;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //}


                        //if (dado.Dado1 + dado.Dado4 == 6 || dado.Dado2 + dado.Dado3 == 6)
                        //{

                        //    string ordem = "1423";
                        //    int R1 = dado.Dado1 + dado.Dado4;
                        //    int R2 = dado.Dado2 + dado.Dado3;
                        //    string v1 = R1.ToString();
                        //    string v2 = R2.ToString();
                        //    if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //    if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //    string linha3 = v1 + v2;
                        //    string result = Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //    if (result.Substring(0, 4) == "ERRO")
                        //    {
                        //        Jogo.Mover(IdJogador, senhajogador, "2413", linha3);
                        //    }
                        //    Jogo.Parar(IdJogador, senhajogador);
                        //    goto Fim;
                        //}

                        //if (dado.Dado1 + dado.Dado2 == 6 || dado.Dado3 + dado.Dado4 == 6)
                        //{

                        //    string ordem = "1234";
                        //    int R1 = dado.Dado1 + dado.Dado2;
                        //    int R2 = dado.Dado3 + dado.Dado4;
                        //    string v1 = R1.ToString();
                        //    string v2 = R2.ToString();
                        //    if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //    if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //    string linha3 = v1 + v2;
                        //    string result = Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //    if (result.Substring(0, 4) == "ERRO")
                        //    {
                        //        Jogo.Mover(IdJogador, senhajogador, "2413", linha3);
                        //    }
                        //    Jogo.Parar(IdJogador, senhajogador);
                        //    goto Fim;
                        //}

                        //trilha 7

                        //if ((pcBoxJ1T2.Location == new Point(446, 455) && pcBoxJ1T2.Location == new Point(446, 455 - 51) && pcBoxJ1T2.Location == new Point(446, (455 - 51) - 51) || (pcBoxJ2T2.Location == new Point(461, 455 - (51 * 2)) && pcBoxJ2T2.Location == new Point(461, 455 - 51) && pcBoxJ2T2.Location == new Point(461, 455)) || (pcBoxJ3T2.Location == new Point(446, 471 - (51 * 2)) && pcBoxJ3T2.Location == new Point(446, 471 - (51)) && pcBoxJ3T2.Location == new Point(446, 471)) || (pcBoxJ4T2.Location == new Point(466, 471 - (51 * 2)) && pcBoxJ4T2.Location == new Point(466, 471 - (51)) && pcBoxJ4T2.Location == new Point(466, 471)) || (pcBoxJ1T3.Location == new Point(507, (504 - 153) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 102) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 51) - 51) && pcBoxJ1T3.Location == new Point(507, 504 - 51) && pcBoxJ1T3.Location == new Point(507, 504)) || (pcBoxJ2T3.Location == new Point(527, 504 - (51 * 4)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 3)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 2)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 1)) && pcBoxJ2T3.Location == new Point(527, 504)) || (pcBoxJ3T3.Location == new Point(506, 521 - (51 * 4)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 3)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 2)) && pcBoxJ3T3.Location == new Point(506, 521 - (51)) && pcBoxJ3T3.Location == new Point(506, 521)) || (pcBoxJ4T3.Location == new Point(526, 521 - (51 * 4)) && pcBoxJ4T3.Location == new Point(526, 521 - (51 * 3)) && pcBoxJ4T3.Location == new Point(526, 521 - (51 * 2)) && pcBoxJ4T3.Location == new Point(526, 521 - (51)) && pcBoxJ4T3.Location == new Point(526, 521)) || (pcBoxJ1T4.Location == new Point(574, (559 - 255) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 204) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 153) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 102) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 51) - 51) && pcBoxJ1T4.Location == new Point(574, 559 - 51) && pcBoxJ1T4.Location == new Point(574, 559) || (pcBoxJ2T4.Location == new Point(594, 559 - (51 * 6)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 5)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 4)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 3)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 2)) && pcBoxJ2T4.Location == new Point(594, 559 - 51) && pcBoxJ2T4.Location == new Point(594, 559)) || (pcBoxJ3T4.Location == new Point(574, 570 - (51 * 6)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 5)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 4)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 3)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 2)) && pcBoxJ3T4.Location == new Point(574, 570 - (51)) && pcBoxJ3T4.Location == new Point(574, 570)) || (pcBoxJ4T4.Location == new Point(594, 570 - (51 * 6)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 5)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 4)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 3)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 2)) && pcBoxJ4T4.Location == new Point(594, 570 - (51)) && pcBoxJ4T4.Location == new Point(594, 570)) || (pcBoxJ1T5.Location == new Point(639, (608 - 357) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 306) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 255) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 204) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 153) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 102) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 51) - 51) && pcBoxJ1T5.Location == new Point(639, 608 - 51) && pcBoxJ1T5.Location == new Point(639, 608) || (pcBoxJ2T5.Location == new Point(659, 608 - (51 * 8))&&pcBoxJ2T5.Location == new Point(659, 608 - (51 * 7))&&pcBoxJ2T5.Location == new Point(659, 608 - (51 * 6))&&pcBoxJ2T5.Location == new Point(659, 608 - (51 * 5))&& pcBoxJ2T5.Location == new Point(659, 608 - (51 * 4))&&pcBoxJ2T5.Location == new Point(659, 608 - (51 * 3))&& pcBoxJ2T5.Location == new Point(659, 608 - (51 * 2))&&pcBoxJ2T5.Location == new Point(659, 608 - (51))&& pcBoxJ2T5.Location == new Point(659, 608)) ||(pcBoxJ3T5.Location == new Point(639, 620 - (51 * 8))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 7))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 6))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 5))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 4))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 3))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 2))&& pcBoxJ3T5.Location == new Point(639, 620 - (51))&& pcBoxJ3T5.Location == new Point(639, 620)) ||(pcBoxJ4T5.Location == new Point(659, 620 - (51 * 8))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 7))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 6))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 5))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 4))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 3))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 2))&& pcBoxJ4T5.Location == new Point(659, 620 - (51))&& pcBoxJ4T5.Location == new Point(659, 620))||(pcBoxJ1T6.Location == new Point(705, (658 - 459) - 51)&& pcBoxJ1T6.Location == new Point(705, (658 - 408) - 51)&& pcBoxJ1T6.Location == new Point(705, (658 - 357) - 51)&&pcBoxJ1T6.Location == new Point(705, (658 - 306) - 51)&&pcBoxJ1T6.Location == new Point(705, (658 - 255) - 51)&&pcBoxJ1T6.Location == new Point(705, (658 - 204) - 51)&&pcBoxJ1T6.Location == new Point(705, (658 - 153) - 51) &&  pcBoxJ1T6.Location == new Point(705, (658 - 102) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 51) - 51)&&pcBoxJ1T6.Location == new Point(705, 658 - 51)&&pcBoxJ1T6.Location == new Point(705, 658) || (pcBoxJ2T6.Location == new Point(725, 658 - (51 * 10))&& pcBoxJ2T6.Location == new Point(725, 658 - (51 * 9))&& pcBoxJ2T6.Location == new Point(725, 658 - (51 * 8))&&pcBoxJ2T6.Location == new Point(725, 658 - (51 * 7))&& pcBoxJ2T6.Location == new Point(725, 658 - (51 * 6))&& pcBoxJ2T6.Location == new Point(725, 658 - (51 * 5))&&pcBoxJ2T6.Location == new Point(725, 658 - (51 * 4))&& pcBoxJ2T6.Location == new Point(725, 658 - (51 * 3))&&pcBoxJ2T6.Location == new Point(725, 658 - (51 * 2))&&pcBoxJ2T6.Location == new Point(725, 658 - (51))&& pcBoxJ2T6.Location == new Point(725, 658)) || (pcBoxJ3T6.Location == new Point(703, 671 - (51 * 10))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 9))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 8))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 7))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 6))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 5))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 4))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 3))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 2))&& pcBoxJ3T6.Location == new Point(703, 671 - (51))&& pcBoxJ3T6.Location == new Point(703, 671)) || (pcBoxJ4T6.Location == new Point(723, 671 - (51 * 10))&&pcBoxJ4T6.Location == new Point(723, 671 - (51 * 9))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 8))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 7))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 6))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 5))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 4))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 3))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 2))&& pcBoxJ4T6.Location == new Point(723, 671 - (51))&& pcBoxJ4T6.Location == new Point(723, 671))|| (pcBoxJ1T8.Location == new Point(837, (658 - 459) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 408) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 357) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 306) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 255) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 204) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 153) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 102) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 51) - 51) && pcBoxJ1T8.Location == new Point(837, 658 - 51) && pcBoxJ1T8.Location == new Point(837, 658)) || (pcBoxJ2T8.Location == new Point(857, 658 - (51 * 10)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 9)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 8)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 7)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 6)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 5)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 4)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 3)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 2)) && pcBoxJ2T8.Location == new Point(857, 658 - (51)) && pcBoxJ2T8.Location == new Point(857, 658)) || (pcBoxJ3T8.Location == new Point(836, 671 - (51 * 10)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 9)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 8)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 7)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 6)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 5)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 4)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 3)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 2)) && pcBoxJ3T8.Location == new Point(836, 671 - (51)) && pcBoxJ3T8.Location == new Point(836, 671)) || (pcBoxJ4T8.Location == new Point(856, 671 - (51 * 10)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 9)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 8)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 7)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 6)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 5)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 4)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 3)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 2)) && pcBoxJ4T8.Location == new Point(856, 671 - (51)) && pcBoxJ4T8.Location == new Point(856, 671)) || (pcBoxJ1T9.Location == new Point(900, (608 - 357) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 306) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 255) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 204) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 153) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 102) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 51) - 51) && pcBoxJ1T9.Location == new Point(900, 608 - 51) && pcBoxJ1T9.Location == new Point(900, 608)) || (pcBoxJ2T9.Location == new Point(920, 608 - (51 * 8)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 7)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 6)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 5)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 4)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 3)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 2)) && pcBoxJ2T9.Location == new Point(920, 608 - (51)) && pcBoxJ2T9.Location == new Point(920, 608)) || (pcBoxJ3T9.Location == new Point(897, 618 - (51 * 8)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 7)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 6)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 5)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 4)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 3)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 2)) && pcBoxJ3T9.Location == new Point(897, 618 - (51)) && pcBoxJ3T9.Location == new Point(897, 618)) || (pcBoxJ4T9.Location == new Point(917, 618 - (51 * 8)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 7)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 6)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 5)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 4)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 3)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 2)) && pcBoxJ4T9.Location == new Point(917, 618 - (51)) && pcBoxJ4T9.Location == new Point(917, 618)) || (pcBoxJ1T10.Location == new Point(967, (559 - 255) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 204) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 153) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 102) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 51) - 51) && pcBoxJ1T10.Location == new Point(967, 559 - 51) && pcBoxJ1T10.Location == new Point(967, 559)) || (pcBoxJ2T10.Location == new Point(987, 559 - (51 * 6)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 5)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 4)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 3)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 2)) && pcBoxJ2T10.Location == new Point(987, 559 - (51)) && pcBoxJ2T10.Location == new Point(987, 559)) || (pcBoxJ3T10.Location == new Point(966, 572 - (51 * 6)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 5)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 4)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 3)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 2)) && pcBoxJ3T10.Location == new Point(966, 572 - (51)) && pcBoxJ3T10.Location == new Point(966, 572)) || (pcBoxJ4T10.Location == new Point(986, 572 - (51 * 6)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 5)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 4)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 3)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 2)) && pcBoxJ4T10.Location == new Point(986, 572 - (51)) && pcBoxJ4T10.Location == new Point(986, 572)) || (pcBoxJ1T11.Location == new Point(1031, (504 - 153) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 102) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 51) - 51) && pcBoxJ1T11.Location == new Point(1031, 504 - 51) && pcBoxJ1T11.Location == new Point(1031, 504)) || (pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 4)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 3)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 2)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51)) && pcBoxJ2T11.Location == new Point(1051, 504)) || (pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 4)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 3)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 2)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51)) && pcBoxJ3T11.Location == new Point(1036, 518))) || (pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 4)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 3)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 2)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51)) && pcBoxJ4T11.Location == new Point(1056, 518)) || (pcBoxJ1T12.Location == new Point(1097, (455 - 51) - 51) && pcBoxJ1T12.Location == new Point(1097, 455 - 51) && pcBoxJ1T12.Location == new Point(1097, 455)) || (pcBoxJ2T12.Location == new Point(1117, 455 - (51 * 2)) && pcBoxJ2T12.Location == new Point(1117, 455 - (51)) && pcBoxJ2T12.Location == new Point(1117, 455)) || (pcBoxJ3T12.Location == new Point(1097, 470 - (51 * 2)) && pcBoxJ3T12.Location == new Point(1097, 470 - (51)) && pcBoxJ3T12.Location == new Point(1097, 470)) || (pcBoxJ4T12.Location == new Point(1117, 470 - (51 * 2)) && pcBoxJ4T12.Location == new Point(1117, 470 - (51)) && pcBoxJ4T12.Location == new Point(1117, 470))))))
                        //{

                        //    //if ((pcBoxJ1T2.Location == new Point(446, 455) && pcBoxJ1T2.Location == new Point(446, 455 - 51) && pcBoxJ1T2.Location == new Point(446, (455 - 51) - 51) || (pcBoxJ2T2.Location == new Point(461, 455 - (51 * 2)) && pcBoxJ2T2.Location == new Point(461, 455 - 51) && pcBoxJ2T2.Location == new Point(461, 455)) || (pcBoxJ3T2.Location == new Point(446, 471 - (51 * 2)) && pcBoxJ3T2.Location == new Point(446, 471 - (51)) && pcBoxJ3T2.Location == new Point(446, 471)) || (pcBoxJ4T2.Location == new Point(466, 471 - (51 * 2)) && pcBoxJ4T2.Location == new Point(466, 471 - (51)) && pcBoxJ4T2.Location == new Point(466, 471))) || (pcBoxJ1T3.Location == new Point(507, (504 - 153) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 102) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 51) - 51) && pcBoxJ1T3.Location == new Point(507, 504 - 51) && pcBoxJ1T3.Location == new Point(507, 504) || (pcBoxJ2T3.Location == new Point(527, 504 - (51 * 4)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 3)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 2)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 1)) && pcBoxJ2T3.Location == new Point(527, 504)) || (pcBoxJ3T3.Location == new Point(506, 521 - (51 * 4)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 3)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 2)) && pcBoxJ3T3.Location == new Point(506, 521 - (51)) && pcBoxJ3T3.Location == new Point(506, 521)) || (pcBoxJ1T4.Location == new Point(574, (559 - 255) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 204) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 153) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 102) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 51) - 51) && pcBoxJ1T4.Location == new Point(574, 559 - 51) && pcBoxJ1T4.Location == new Point(574, 559) || (pcBoxJ2T4.Location == new Point(594, 559 - (51 * 6)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 5)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 4)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 3)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 2)) && pcBoxJ2T4.Location == new Point(594, 559 - 51) && pcBoxJ2T4.Location == new Point(594, 559)) || (pcBoxJ3T4.Location == new Point(574, 570 - (51 * 6)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 5)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 4)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 3)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 2)) && pcBoxJ3T4.Location == new Point(574, 570 - (51)) && pcBoxJ3T4.Location == new Point(574, 570)) || (pcBoxJ4T4.Location == new Point(594, 570 - (51 * 6)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 5)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 4)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 3)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 2)) && pcBoxJ4T4.Location == new Point(594, 570 - (51)) && pcBoxJ4T4.Location == new Point(594, 570))) || (pcBoxJ1T5.Location == new Point(639, (608 - 357) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 306) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 255) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 204) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 153) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 102) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 51) - 51) && pcBoxJ1T5.Location == new Point(639, 608 - 51) && pcBoxJ1T5.Location == new Point(639, 608) || (pcBoxJ2T5.Location == new Point(659, 608 - (51 * 8))&&pcBoxJ2T5.Location == new Point(659, 608 - (51 * 7))&&pcBoxJ2T5.Location == new Point(659, 608 - (51 * 6))&&pcBoxJ2T5.Location == new Point(659, 608 - (51 * 5))&& pcBoxJ2T5.Location == new Point(659, 608 - (51 * 4))&&pcBoxJ2T5.Location == new Point(659, 608 - (51 * 3))&& pcBoxJ2T5.Location == new Point(659, 608 - (51 * 2))&&pcBoxJ2T5.Location == new Point(659, 608 - (51))&& pcBoxJ2T5.Location == new Point(659, 608)) ||(pcBoxJ3T5.Location == new Point(639, 620 - (51 * 8))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 7))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 6))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 5))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 4))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 3))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 2))&& pcBoxJ3T5.Location == new Point(639, 620 - (51))&& pcBoxJ3T5.Location == new Point(639, 620)) ||(pcBoxJ4T5.Location == new Point(659, 620 - (51 * 8))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 7))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 6))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 5))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 4))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 3))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 2))&& pcBoxJ4T5.Location == new Point(659, 620 - (51))&& pcBoxJ4T5.Location == new Point(659, 620)) || (pcBoxJ1T6.Location == new Point(705, (658 - 459) - 51)&& pcBoxJ1T6.Location == new Point(705, (658 - 408) - 51)&& pcBoxJ1T6.Location == new Point(705, (658 - 357) - 51)&&pcBoxJ1T6.Location == new Point(705, (658 - 306) - 51)&&pcBoxJ1T6.Location == new Point(705, (658 - 255) - 51)&&pcBoxJ1T6.Location == new Point(705, (658 - 204) - 51)&&pcBoxJ1T6.Location == new Point(705, (658 - 153) - 51) &&  pcBoxJ1T6.Location == new Point(705, (658 - 102) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 51) - 51)&&pcBoxJ1T6.Location == new Point(705, 658 - 51)&&pcBoxJ1T6.Location == new Point(705, 658) || (pcBoxJ2T6.Location == new Point(725, 658 - (51 * 10))&& pcBoxJ2T6.Location == new Point(725, 658 - (51 * 9))&& pcBoxJ2T6.Location == new Point(725, 658 - (51 * 8))&&pcBoxJ2T6.Location == new Point(725, 658 - (51 * 7))&& pcBoxJ2T6.Location == new Point(725, 658 - (51 * 6))&& pcBoxJ2T6.Location == new Point(725, 658 - (51 * 5))&&pcBoxJ2T6.Location == new Point(725, 658 - (51 * 4))&& pcBoxJ2T6.Location == new Point(725, 658 - (51 * 3))&&pcBoxJ2T6.Location == new Point(725, 658 - (51 * 2))&&pcBoxJ2T6.Location == new Point(725, 658 - (51))&& pcBoxJ2T6.Location == new Point(725, 658)) || (pcBoxJ3T6.Location == new Point(703, 671 - (51 * 10))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 9))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 8))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 7))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 6))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 5))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 4))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 3))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 2))&& pcBoxJ3T6.Location == new Point(703, 671 - (51))&& pcBoxJ3T6.Location == new Point(703, 671)) || (pcBoxJ4T6.Location == new Point(723, 671 - (51 * 10))&&pcBoxJ4T6.Location == new Point(723, 671 - (51 * 9))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 8))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 7))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 6))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 5))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 4))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 3))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 2))&& pcBoxJ4T6.Location == new Point(723, 671 - (51))&& pcBoxJ4T6.Location == new Point(723, 671)))|| (pcBoxJ1T8.Location == new Point(837, (658 - 459) - 51)&& pcBoxJ1T8.Location == new Point(837, (658 - 408) - 51)&&pcBoxJ1T8.Location == new Point(837, (658 - 357) - 51)&& pcBoxJ1T8.Location == new Point(837, (658 - 306) - 51)&& pcBoxJ1T8.Location == new Point(837, (658 - 255) - 51)&&pcBoxJ1T8.Location == new Point(837, (658 - 204) - 51)&&pcBoxJ1T8.Location == new Point(837, (658 - 153) - 51)&& pcBoxJ1T8.Location == new Point(837, (658 - 102) - 51)&&pcBoxJ1T8.Location == new Point(837, (658 - 51) - 51)&& pcBoxJ1T8.Location == new Point(837, 658 - 51)&&pcBoxJ1T8.Location == new Point(837, 658) || (pcBoxJ2T8.Location == new Point(857, 658 - (51 * 10))&&pcBoxJ2T8.Location == new Point(857, 658 - (51 * 9))&&pcBoxJ2T8.Location == new Point(857, 658 - (51 * 8))&&pcBoxJ2T8.Location == new Point(857, 658 - (51 * 7))&&pcBoxJ2T8.Location == new Point(857, 658 - (51 * 6))&& pcBoxJ2T8.Location == new Point(857, 658 - (51 * 5))&&pcBoxJ2T8.Location == new Point(857, 658 - (51 * 4))&&pcBoxJ2T8.Location == new Point(857, 658 - (51 * 3))&&pcBoxJ2T8.Location == new Point(857, 658 - (51 * 2))&&pcBoxJ2T8.Location == new Point(857, 658 - (51))&& pcBoxJ2T8.Location == new Point(857, 658)) || (pcBoxJ3T8.Location == new Point(836, 671 - (51 * 10)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 9))&& pcBoxJ3T8.Location == new Point(836, 671 - (51 * 8))&& pcBoxJ3T8.Location == new Point(836, 671 - (51 * 7))&& pcBoxJ3T8.Location == new Point(836, 671 - (51 * 6))&& pcBoxJ3T8.Location == new Point(836, 671 - (51 * 5)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 4))&&pcBoxJ3T8.Location == new Point(836, 671 - (51 * 3))&& pcBoxJ3T8.Location == new Point(836, 671 - (51 * 2))&& pcBoxJ3T8.Location == new Point(836, 671 - (51))&& pcBoxJ3T8.Location == new Point(836, 671)) || (pcBoxJ4T8.Location == new Point(856, 671 - (51 * 10)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 9))&& pcBoxJ4T8.Location == new Point(856, 671 - (51 * 8))&& pcBoxJ4T8.Location == new Point(856, 671 - (51 * 7)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 6)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 5))&& pcBoxJ4T8.Location == new Point(856, 671 - (51 * 4)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 3)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 2)) && pcBoxJ4T8.Location == new Point(856, 671 - (51)) && pcBoxJ4T8.Location == new Point(856, 671))) || (pcBoxJ1T9.Location == new Point(900, (608 - 357) - 51)&& pcBoxJ1T9.Location == new Point(900, (608 - 306) - 51)&& pcBoxJ1T9.Location == new Point(900, (608 - 255) - 51)&& pcBoxJ1T9.Location == new Point(900, (608 - 204) - 51)&& pcBoxJ1T9.Location == new Point(900, (608 - 153) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 102) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 51) - 51)&& pcBoxJ1T9.Location == new Point(900, 608 - 51)&& pcBoxJ1T9.Location == new Point(900, 608) || (pcBoxJ2T9.Location == new Point(920, 608 - (51 * 8))&& pcBoxJ2T9.Location == new Point(920, 608 - (51 * 7))&&pcBoxJ2T9.Location == new Point(920, 608 - (51 * 6))&&pcBoxJ2T9.Location == new Point(920, 608 - (51 * 5))&&pcBoxJ2T9.Location == new Point(920, 608 - (51 * 4))&& pcBoxJ2T9.Location == new Point(920, 608 - (51 * 3))&& pcBoxJ2T9.Location == new Point(920, 608 - (51 * 2))&& pcBoxJ2T9.Location == new Point(920, 608 - (51))&&pcBoxJ2T9.Location == new Point(920, 608)) || (pcBoxJ3T9.Location == new Point(897, 618 - (51 * 8))&&pcBoxJ3T9.Location == new Point(897, 618 - (51 * 7))&&pcBoxJ3T9.Location == new Point(897, 618 - (51 * 6))&&pcBoxJ3T9.Location == new Point(897, 618 - (51 * 5))&&pcBoxJ3T9.Location == new Point(897, 618 - (51 * 4))&&pcBoxJ3T9.Location == new Point(897, 618 - (51 * 3))&&pcBoxJ3T9.Location == new Point(897, 618 - (51 * 2))&&pcBoxJ3T9.Location == new Point(897, 618 - (51))&& pcBoxJ3T9.Location == new Point(897, 618)) ||(pcBoxJ4T9.Location == new Point(917, 618 - (51 * 8)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 7))&& pcBoxJ4T9.Location == new Point(917, 618 - (51 * 6)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 5)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 4))&& pcBoxJ4T9.Location == new Point(917, 618 - (51 * 3)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 2)) && pcBoxJ4T9.Location == new Point(917, 618 - (51))&& pcBoxJ4T9.Location == new Point(917, 618))) || (pcBoxJ1T10.Location == new Point(967, (559 - 255) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 204) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 153) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 102) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 51) - 51) && pcBoxJ1T10.Location == new Point(967, 559 - 51) && pcBoxJ1T10.Location == new Point(967, 559) || (pcBoxJ2T10.Location == new Point(987, 559 - (51 * 6))&& pcBoxJ2T10.Location == new Point(987, 559 - (51 * 5))&& pcBoxJ2T10.Location == new Point(987, 559 - (51 * 4))&& pcBoxJ2T10.Location == new Point(987, 559 - (51 * 3))&& pcBoxJ2T10.Location == new Point(987, 559 - (51 * 2))&&pcBoxJ2T10.Location == new Point(987, 559 - (51))&&pcBoxJ2T10.Location == new Point(987, 559)) || (pcBoxJ3T10.Location == new Point(966, 572 - (51 * 6))&&pcBoxJ3T10.Location == new Point(966, 572 - (51 * 5))&& pcBoxJ3T10.Location == new Point(966, 572 - (51 * 4))&& pcBoxJ3T10.Location == new Point(966, 572 - (51 * 3))&&pcBoxJ3T10.Location == new Point(966, 572 - (51 * 2))&&pcBoxJ3T10.Location == new Point(966, 572 - (51))&& pcBoxJ3T10.Location == new Point(966, 572)) || (pcBoxJ4T10.Location == new Point(986, 572 - (51 * 6))&& pcBoxJ4T10.Location == new Point(986, 572 - (51 * 5))&& pcBoxJ4T10.Location == new Point(986, 572 - (51 * 4))&& pcBoxJ4T10.Location == new Point(986, 572 - (51 * 3))&& pcBoxJ4T10.Location == new Point(986, 572 - (51 * 2))&& pcBoxJ4T10.Location == new Point(986, 572 - (51))&& pcBoxJ4T10.Location == new Point(986, 572))) || (pcBoxJ1T11.Location == new Point(1031, (504 - 153) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 102) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 51) - 51) && pcBoxJ1T11.Location == new Point(1031, 504 - 51) && pcBoxJ1T11.Location == new Point(1031, 504) || (pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 4))&&pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 3))&& pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 2))&& pcBoxJ2T11.Location == new Point(1051, 504 - (51))&&pcBoxJ2T11.Location == new Point(1051, 504))|| (pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 4))&& pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 3))&& pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 2))&& pcBoxJ3T11.Location == new Point(1036, 518 - (51))&& pcBoxJ3T11.Location == new Point(1036, 518)) || (pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 4))&& pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 3))&& pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 2))&& pcBoxJ4T11.Location == new Point(1056, 518 - (51))&& pcBoxJ4T11.Location == new Point(1056, 518))) || (pcBoxJ1T12.Location == new Point(1097, (455 - 51) - 51) && pcBoxJ1T12.Location == new Point(1097, 455 - 51) && pcBoxJ1T12.Location == new Point(1097, 455) || (pcBoxJ2T12.Location == new Point(1117, 455 - (51 * 2))&& pcBoxJ2T12.Location == new Point(1117, 455 - (51))&& pcBoxJ2T12.Location == new Point(1117, 455)) || (pcBoxJ3T12.Location == new Point(1097, 470 - (51 * 2))&& pcBoxJ3T12.Location == new Point(1097, 470 - (51))&& pcBoxJ3T12.Location == new Point(1097, 470)) || (pcBoxJ4T12.Location == new Point(1117, 470 - (51 * 2))&& pcBoxJ4T12.Location == new Point(1117, 470 - (51))&& pcBoxJ4T12.Location == new Point(1117, 470))))))
                        //    //{
                        //    //    //if (pcBoxJ1T7.Location == new Point(771, (710 - 561) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 510) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 459) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 408) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 357) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 306) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 255) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 204) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 153) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 102) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 51) - 51)&&pcBoxJ1T7.Location == new Point(771, 710 - 51)&&pcBoxJ1T7.Location == new Point(771, 710) || (pcBoxJ2T7.Location == new Point(791, 710 - (51 * 12))&&pcBoxJ2T7.Location == new Point(791, 710 - (51 * 11))&&pcBoxJ2T7.Location == new Point(791, 710 - (51 * 10))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 9))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 8))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 7))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 6))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 5))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 4))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 3))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 2))&&pcBoxJ2T7.Location == new Point(791, 710 - (51))&&pcBoxJ2T7.Location == new Point(791, 710)) ||(pcBoxJ3T7.Location == new Point(770, 723 - (51 * 12))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 11))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 10))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 9))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 8))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 7))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 6))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 5))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 4))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 3))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 2))&& pcBoxJ3T7.Location == new Point(770, 723 - (51))&& pcBoxJ3T7.Location == new Point(770, 723) || (pcBoxJ4T7.Location == new Point(787, 723 - (51 * 12))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 11))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 10))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 9))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 8))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 7))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 6))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 5))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 4))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 3))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 2))&& pcBoxJ4T7.Location == new Point(787, 723 - (51))&& pcBoxJ4T7.Location == new Point(787, 723))))
                        //    //{
                        //    if (dado.Dado1 + dado.Dado3 == 7 || dado.Dado2 + dado.Dado4 == 7)
                        //    {
                        //        string ordem = "1324";
                        //        int R1 = dado.Dado1 + dado.Dado3;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado1 + dado.Dado4 == 7 || dado.Dado2 + dado.Dado3 == 7)
                        //    {
                        //        string ordem = "1423";
                        //        int R1 = dado.Dado1 + dado.Dado4;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado1 + dado.Dado2 == 7 || dado.Dado3 + dado.Dado4 == 7)
                        //    {
                        //        string ordem = "1234";
                        //        int R1 = dado.Dado1 + dado.Dado2;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado2 + dado.Dado3 == 7 || dado.Dado1 + dado.Dado4 == 7)
                        //    {
                        //        string ordem = "2314";
                        //        int R1 = dado.Dado2 + dado.Dado3;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado2 + dado.Dado4 == 7 || dado.Dado1 + dado.Dado3 == 7)
                        //    {
                        //        string ordem = "2413";
                        //        int R1 = dado.Dado2 + dado.Dado4;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado3 + dado.Dado4 == 7 || dado.Dado1 + dado.Dado2 == 7)
                        //    {
                        //        string ordem = "3412";
                        //        int R1 = dado.Dado3 + dado.Dado4;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //}

                       
                        //if (dado.Dado1 + dado.Dado4 == 7 || dado.Dado2 + dado.Dado3 == 7)
                        //{

                        //    string ordem = "1423";
                        //    int R1 = dado.Dado1 + dado.Dado4;
                        //    int R2 = dado.Dado2 + dado.Dado3;
                        //    string v1 = R1.ToString();
                        //    string v2 = R2.ToString();
                        //    if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //    if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //    string linha3 = v1 + v2;
                        //    string result = Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //    if (result.Substring(0, 4) == "ERRO")
                        //    {
                        //        Jogo.Mover(IdJogador, senhajogador, "2413", linha3);
                        //    }
                        //    Jogo.Parar(IdJogador, senhajogador);
                        //    goto Fim;
                        //}

                        //if (dado.Dado1 + dado.Dado2 == 7 || dado.Dado3 + dado.Dado4 == 7)
                        //{

                        //    string ordem = "1234";
                        //    int R1 = dado.Dado1 + dado.Dado2;
                        //    int R2 = dado.Dado3 + dado.Dado4;
                        //    string v1 = R1.ToString();
                        //    string v2 = R2.ToString();
                        //    if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //    if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //    string linha3 = v1 + v2;
                        //    string result = Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //    if (result.Substring(0, 4) == "ERRO")
                        //    {
                        //        Jogo.Mover(IdJogador, senhajogador, "2413", linha3);
                        //    }
                        //    Jogo.Parar(IdJogador, senhajogador);
                        //    goto Fim;
                        //}

                        //trilha 8
                        //if ((pcBoxJ1T2.Location == new Point(446, 455) && pcBoxJ1T2.Location == new Point(446, 455 - 51) && pcBoxJ1T2.Location == new Point(446, (455 - 51) - 51) || (pcBoxJ2T2.Location == new Point(461, 455 - (51 * 2)) && pcBoxJ2T2.Location == new Point(461, 455 - 51) && pcBoxJ2T2.Location == new Point(461, 455)) || (pcBoxJ3T2.Location == new Point(446, 471 - (51 * 2)) && pcBoxJ3T2.Location == new Point(446, 471 - (51)) && pcBoxJ3T2.Location == new Point(446, 471)) || (pcBoxJ4T2.Location == new Point(466, 471 - (51 * 2)) && pcBoxJ4T2.Location == new Point(466, 471 - (51)) && pcBoxJ4T2.Location == new Point(466, 471))) || (pcBoxJ1T3.Location == new Point(507, (504 - 153) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 102) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 51) - 51) && pcBoxJ1T3.Location == new Point(507, 504 - 51) && pcBoxJ1T3.Location == new Point(507, 504) || (pcBoxJ2T3.Location == new Point(527, 504 - (51 * 4)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 3)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 2)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 1)) && pcBoxJ2T3.Location == new Point(527, 504)) || (pcBoxJ3T3.Location == new Point(506, 521 - (51 * 4)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 3)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 2)) && pcBoxJ3T3.Location == new Point(506, 521 - (51)) && pcBoxJ3T3.Location == new Point(506, 521)) || (pcBoxJ1T4.Location == new Point(574, (559 - 255) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 204) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 153) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 102) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 51) - 51) && pcBoxJ1T4.Location == new Point(574, 559 - 51) && pcBoxJ1T4.Location == new Point(574, 559) || (pcBoxJ2T4.Location == new Point(594, 559 - (51 * 6)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 5)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 4)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 3)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 2)) && pcBoxJ2T4.Location == new Point(594, 559 - 51) && pcBoxJ2T4.Location == new Point(594, 559)) || (pcBoxJ3T4.Location == new Point(574, 570 - (51 * 6)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 5)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 4)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 3)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 2)) && pcBoxJ3T4.Location == new Point(574, 570 - (51)) && pcBoxJ3T4.Location == new Point(574, 570)) || (pcBoxJ4T4.Location == new Point(594, 570 - (51 * 6)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 5)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 4)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 3)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 2)) && pcBoxJ4T4.Location == new Point(594, 570 - (51)) && pcBoxJ4T4.Location == new Point(594, 570))) || (pcBoxJ1T5.Location == new Point(639, (608 - 357) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 306) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 255) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 204) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 153) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 102) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 51) - 51) && pcBoxJ1T5.Location == new Point(639, 608 - 51) && pcBoxJ1T5.Location == new Point(639, 608) || (pcBoxJ2T5.Location == new Point(659, 608 - (51 * 8))&&pcBoxJ2T5.Location == new Point(659, 608 - (51 * 7))&&pcBoxJ2T5.Location == new Point(659, 608 - (51 * 6))&&pcBoxJ2T5.Location == new Point(659, 608 - (51 * 5))&& pcBoxJ2T5.Location == new Point(659, 608 - (51 * 4))&&pcBoxJ2T5.Location == new Point(659, 608 - (51 * 3))&& pcBoxJ2T5.Location == new Point(659, 608 - (51 * 2))&&pcBoxJ2T5.Location == new Point(659, 608 - (51))&& pcBoxJ2T5.Location == new Point(659, 608)) ||(pcBoxJ3T5.Location == new Point(639, 620 - (51 * 8))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 7))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 6))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 5))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 4))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 3))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 2))&& pcBoxJ3T5.Location == new Point(639, 620 - (51))&& pcBoxJ3T5.Location == new Point(639, 620)) ||(pcBoxJ4T5.Location == new Point(659, 620 - (51 * 8))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 7))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 6))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 5))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 4))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 3))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 2))&& pcBoxJ4T5.Location == new Point(659, 620 - (51))&& pcBoxJ4T5.Location == new Point(659, 620)) || (pcBoxJ1T6.Location == new Point(705, (658 - 459) - 51)&& pcBoxJ1T6.Location == new Point(705, (658 - 408) - 51)&& pcBoxJ1T6.Location == new Point(705, (658 - 357) - 51)&&pcBoxJ1T6.Location == new Point(705, (658 - 306) - 51)&&pcBoxJ1T6.Location == new Point(705, (658 - 255) - 51)&&pcBoxJ1T6.Location == new Point(705, (658 - 204) - 51)&&pcBoxJ1T6.Location == new Point(705, (658 - 153) - 51) &&  pcBoxJ1T6.Location == new Point(705, (658 - 102) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 51) - 51)&&pcBoxJ1T6.Location == new Point(705, 658 - 51)&&pcBoxJ1T6.Location == new Point(705, 658) || (pcBoxJ2T6.Location == new Point(725, 658 - (51 * 10))&& pcBoxJ2T6.Location == new Point(725, 658 - (51 * 9))&& pcBoxJ2T6.Location == new Point(725, 658 - (51 * 8))&&pcBoxJ2T6.Location == new Point(725, 658 - (51 * 7))&& pcBoxJ2T6.Location == new Point(725, 658 - (51 * 6))&& pcBoxJ2T6.Location == new Point(725, 658 - (51 * 5))&&pcBoxJ2T6.Location == new Point(725, 658 - (51 * 4))&& pcBoxJ2T6.Location == new Point(725, 658 - (51 * 3))&&pcBoxJ2T6.Location == new Point(725, 658 - (51 * 2))&&pcBoxJ2T6.Location == new Point(725, 658 - (51))&& pcBoxJ2T6.Location == new Point(725, 658)) || (pcBoxJ3T6.Location == new Point(703, 671 - (51 * 10))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 9))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 8))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 7))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 6))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 5))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 4))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 3))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 2))&& pcBoxJ3T6.Location == new Point(703, 671 - (51))&& pcBoxJ3T6.Location == new Point(703, 671)) || (pcBoxJ4T6.Location == new Point(723, 671 - (51 * 10))&&pcBoxJ4T6.Location == new Point(723, 671 - (51 * 9))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 8))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 7))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 6))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 5))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 4))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 3))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 2))&& pcBoxJ4T6.Location == new Point(723, 671 - (51))&& pcBoxJ4T6.Location == new Point(723, 671))) || (pcBoxJ1T7.Location == new Point(771, (710 - 561) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 510) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 459) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 408) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 357) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 306) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 255) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 204) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 153) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 102) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 51) - 51)&&pcBoxJ1T7.Location == new Point(771, 710 - 51)&&pcBoxJ1T7.Location == new Point(771, 710) || (pcBoxJ2T7.Location == new Point(791, 710 - (51 * 12))&&pcBoxJ2T7.Location == new Point(791, 710 - (51 * 11))&&pcBoxJ2T7.Location == new Point(791, 710 - (51 * 10))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 9))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 8))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 7))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 6))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 5))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 4))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 3))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 2))&&pcBoxJ2T7.Location == new Point(791, 710 - (51))&&pcBoxJ2T7.Location == new Point(791, 710)) ||(pcBoxJ3T7.Location == new Point(770, 723 - (51 * 12))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 11))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 10))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 9))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 8))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 7))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 6))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 5))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 4))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 3))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 2))&& pcBoxJ3T7.Location == new Point(770, 723 - (51))&& pcBoxJ3T7.Location == new Point(770, 723) || (pcBoxJ4T7.Location == new Point(787, 723 - (51 * 12))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 11))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 10))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 9))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 8))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 7))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 6))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 5))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 4))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 3))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 2))&& pcBoxJ4T7.Location == new Point(787, 723 - (51))&& pcBoxJ4T7.Location == new Point(787, 723))|| (pcBoxJ1T9.Location == new Point(900, (608 - 357) - 51)&& pcBoxJ1T9.Location == new Point(900, (608 - 306) - 51)&& pcBoxJ1T9.Location == new Point(900, (608 - 255) - 51)&& pcBoxJ1T9.Location == new Point(900, (608 - 204) - 51)&& pcBoxJ1T9.Location == new Point(900, (608 - 153) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 102) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 51) - 51)&& pcBoxJ1T9.Location == new Point(900, 608 - 51)&& pcBoxJ1T9.Location == new Point(900, 608) || (pcBoxJ2T9.Location == new Point(920, 608 - (51 * 8))&& pcBoxJ2T9.Location == new Point(920, 608 - (51 * 7))&&pcBoxJ2T9.Location == new Point(920, 608 - (51 * 6))&&pcBoxJ2T9.Location == new Point(920, 608 - (51 * 5))&&pcBoxJ2T9.Location == new Point(920, 608 - (51 * 4))&& pcBoxJ2T9.Location == new Point(920, 608 - (51 * 3))&& pcBoxJ2T9.Location == new Point(920, 608 - (51 * 2))&& pcBoxJ2T9.Location == new Point(920, 608 - (51))&&pcBoxJ2T9.Location == new Point(920, 608)) || (pcBoxJ3T9.Location == new Point(897, 618 - (51 * 8))&&pcBoxJ3T9.Location == new Point(897, 618 - (51 * 7))&&pcBoxJ3T9.Location == new Point(897, 618 - (51 * 6))&&pcBoxJ3T9.Location == new Point(897, 618 - (51 * 5))&&pcBoxJ3T9.Location == new Point(897, 618 - (51 * 4))&&pcBoxJ3T9.Location == new Point(897, 618 - (51 * 3))&&pcBoxJ3T9.Location == new Point(897, 618 - (51 * 2))&&pcBoxJ3T9.Location == new Point(897, 618 - (51))&& pcBoxJ3T9.Location == new Point(897, 618)) ||(pcBoxJ4T9.Location == new Point(917, 618 - (51 * 8)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 7))&& pcBoxJ4T9.Location == new Point(917, 618 - (51 * 6)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 5)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 4))&& pcBoxJ4T9.Location == new Point(917, 618 - (51 * 3)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 2)) && pcBoxJ4T9.Location == new Point(917, 618 - (51))&& pcBoxJ4T9.Location == new Point(917, 618))) || (pcBoxJ1T10.Location == new Point(967, (559 - 255) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 204) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 153) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 102) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 51) - 51) && pcBoxJ1T10.Location == new Point(967, 559 - 51) && pcBoxJ1T10.Location == new Point(967, 559) || (pcBoxJ2T10.Location == new Point(987, 559 - (51 * 6))&& pcBoxJ2T10.Location == new Point(987, 559 - (51 * 5))&& pcBoxJ2T10.Location == new Point(987, 559 - (51 * 4))&& pcBoxJ2T10.Location == new Point(987, 559 - (51 * 3))&& pcBoxJ2T10.Location == new Point(987, 559 - (51 * 2))&&pcBoxJ2T10.Location == new Point(987, 559 - (51))&&pcBoxJ2T10.Location == new Point(987, 559)) || (pcBoxJ3T10.Location == new Point(966, 572 - (51 * 6))&&pcBoxJ3T10.Location == new Point(966, 572 - (51 * 5))&& pcBoxJ3T10.Location == new Point(966, 572 - (51 * 4))&& pcBoxJ3T10.Location == new Point(966, 572 - (51 * 3))&&pcBoxJ3T10.Location == new Point(966, 572 - (51 * 2))&&pcBoxJ3T10.Location == new Point(966, 572 - (51))&& pcBoxJ3T10.Location == new Point(966, 572)) || (pcBoxJ4T10.Location == new Point(986, 572 - (51 * 6))&& pcBoxJ4T10.Location == new Point(986, 572 - (51 * 5))&& pcBoxJ4T10.Location == new Point(986, 572 - (51 * 4))&& pcBoxJ4T10.Location == new Point(986, 572 - (51 * 3))&& pcBoxJ4T10.Location == new Point(986, 572 - (51 * 2))&& pcBoxJ4T10.Location == new Point(986, 572 - (51))&& pcBoxJ4T10.Location == new Point(986, 572))) || (pcBoxJ1T11.Location == new Point(1031, (504 - 153) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 102) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 51) - 51) && pcBoxJ1T11.Location == new Point(1031, 504 - 51) && pcBoxJ1T11.Location == new Point(1031, 504) || (pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 4))&&pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 3))&& pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 2))&& pcBoxJ2T11.Location == new Point(1051, 504 - (51))&&pcBoxJ2T11.Location == new Point(1051, 504))|| (pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 4))&& pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 3))&& pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 2))&& pcBoxJ3T11.Location == new Point(1036, 518 - (51))&& pcBoxJ3T11.Location == new Point(1036, 518)) || (pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 4))&& pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 3))&& pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 2))&& pcBoxJ4T11.Location == new Point(1056, 518 - (51))&& pcBoxJ4T11.Location == new Point(1056, 518))) || (pcBoxJ1T12.Location == new Point(1097, (455 - 51) - 51) && pcBoxJ1T12.Location == new Point(1097, 455 - 51) && pcBoxJ1T12.Location == new Point(1097, 455) || (pcBoxJ2T12.Location == new Point(1117, 455 - (51 * 2))&& pcBoxJ2T12.Location == new Point(1117, 455 - (51))&& pcBoxJ2T12.Location == new Point(1117, 455)) || (pcBoxJ3T12.Location == new Point(1097, 470 - (51 * 2))&& pcBoxJ3T12.Location == new Point(1097, 470 - (51))&& pcBoxJ3T12.Location == new Point(1097, 470)) || (pcBoxJ4T12.Location == new Point(1117, 470 - (51 * 2))&& pcBoxJ4T12.Location == new Point(1117, 470 - (51))&& pcBoxJ4T12.Location == new Point(1117, 470))))))))
                        //{

                        //if ((pcBoxJ1T2.Location == new Point(446, 455) && pcBoxJ1T2.Location == new Point(446, 455 - 51) && pcBoxJ1T2.Location == new Point(446, (455 - 51) - 51) || (pcBoxJ2T2.Location == new Point(461, 455 - (51 * 2)) && pcBoxJ2T2.Location == new Point(461, 455 - 51) && pcBoxJ2T2.Location == new Point(461, 455)) || (pcBoxJ3T2.Location == new Point(446, 471 - (51 * 2)) && pcBoxJ3T2.Location == new Point(446, 471 - (51)) && pcBoxJ3T2.Location == new Point(446, 471)) || (pcBoxJ4T2.Location == new Point(466, 471 - (51 * 2)) && pcBoxJ4T2.Location == new Point(466, 471 - (51)) && pcBoxJ4T2.Location == new Point(466, 471)) || (pcBoxJ1T3.Location == new Point(507, (504 - 153) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 102) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 51) - 51) && pcBoxJ1T3.Location == new Point(507, 504 - 51) && pcBoxJ1T3.Location == new Point(507, 504)) || (pcBoxJ2T3.Location == new Point(527, 504 - (51 * 4)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 3)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 2)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 1)) && pcBoxJ2T3.Location == new Point(527, 504)) || (pcBoxJ3T3.Location == new Point(506, 521 - (51 * 4)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 3)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 2)) && pcBoxJ3T3.Location == new Point(506, 521 - (51)) && pcBoxJ3T3.Location == new Point(506, 521)) || (pcBoxJ4T3.Location == new Point(526, 521 - (51 * 4)) && pcBoxJ4T3.Location == new Point(526, 521 - (51 * 3)) && pcBoxJ4T3.Location == new Point(526, 521 - (51 * 2)) && pcBoxJ4T3.Location == new Point(526, 521 - (51)) && pcBoxJ4T3.Location == new Point(526, 521)) || (pcBoxJ1T4.Location == new Point(574, (559 - 255) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 204) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 153) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 102) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 51) - 51) && pcBoxJ1T4.Location == new Point(574, 559 - 51) && pcBoxJ1T4.Location == new Point(574, 559) || (pcBoxJ2T4.Location == new Point(594, 559 - (51 * 6)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 5)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 4)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 3)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 2)) && pcBoxJ2T4.Location == new Point(594, 559 - 51) && pcBoxJ2T4.Location == new Point(594, 559)) || (pcBoxJ3T4.Location == new Point(574, 570 - (51 * 6)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 5)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 4)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 3)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 2)) && pcBoxJ3T4.Location == new Point(574, 570 - (51)) && pcBoxJ3T4.Location == new Point(574, 570)) || (pcBoxJ4T4.Location == new Point(594, 570 - (51 * 6)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 5)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 4)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 3)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 2)) && pcBoxJ4T4.Location == new Point(594, 570 - (51)) && pcBoxJ4T4.Location == new Point(594, 570)) || (pcBoxJ1T5.Location == new Point(639, (608 - 357) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 306) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 255) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 204) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 153) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 102) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 51) - 51) && pcBoxJ1T5.Location == new Point(639, 608 - 51) && pcBoxJ1T5.Location == new Point(639, 608) || (pcBoxJ2T5.Location == new Point(659, 608 - (51 * 8))&&pcBoxJ2T5.Location == new Point(659, 608 - (51 * 7))&&pcBoxJ2T5.Location == new Point(659, 608 - (51 * 6))&&pcBoxJ2T5.Location == new Point(659, 608 - (51 * 5))&& pcBoxJ2T5.Location == new Point(659, 608 - (51 * 4))&&pcBoxJ2T5.Location == new Point(659, 608 - (51 * 3))&& pcBoxJ2T5.Location == new Point(659, 608 - (51 * 2))&&pcBoxJ2T5.Location == new Point(659, 608 - (51))&& pcBoxJ2T5.Location == new Point(659, 608)) ||(pcBoxJ3T5.Location == new Point(639, 620 - (51 * 8))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 7))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 6))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 5))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 4))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 3))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 2))&& pcBoxJ3T5.Location == new Point(639, 620 - (51))&& pcBoxJ3T5.Location == new Point(639, 620)) ||(pcBoxJ4T5.Location == new Point(659, 620 - (51 * 8))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 7))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 6))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 5))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 4))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 3))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 2))&& pcBoxJ4T5.Location == new Point(659, 620 - (51))&& pcBoxJ4T5.Location == new Point(659, 620))||(pcBoxJ1T6.Location == new Point(705, (658 - 459) - 51)&& pcBoxJ1T6.Location == new Point(705, (658 - 408) - 51)&& pcBoxJ1T6.Location == new Point(705, (658 - 357) - 51)&&pcBoxJ1T6.Location == new Point(705, (658 - 306) - 51)&&pcBoxJ1T6.Location == new Point(705, (658 - 255) - 51)&&pcBoxJ1T6.Location == new Point(705, (658 - 204) - 51)&&pcBoxJ1T6.Location == new Point(705, (658 - 153) - 51) &&  pcBoxJ1T6.Location == new Point(705, (658 - 102) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 51) - 51)&&pcBoxJ1T6.Location == new Point(705, 658 - 51)&&pcBoxJ1T6.Location == new Point(705, 658) || (pcBoxJ2T6.Location == new Point(725, 658 - (51 * 10))&& pcBoxJ2T6.Location == new Point(725, 658 - (51 * 9))&& pcBoxJ2T6.Location == new Point(725, 658 - (51 * 8))&&pcBoxJ2T6.Location == new Point(725, 658 - (51 * 7))&& pcBoxJ2T6.Location == new Point(725, 658 - (51 * 6))&& pcBoxJ2T6.Location == new Point(725, 658 - (51 * 5))&&pcBoxJ2T6.Location == new Point(725, 658 - (51 * 4))&& pcBoxJ2T6.Location == new Point(725, 658 - (51 * 3))&&pcBoxJ2T6.Location == new Point(725, 658 - (51 * 2))&&pcBoxJ2T6.Location == new Point(725, 658 - (51))&& pcBoxJ2T6.Location == new Point(725, 658)) || (pcBoxJ3T6.Location == new Point(703, 671 - (51 * 10))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 9))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 8))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 7))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 6))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 5))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 4))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 3))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 2))&& pcBoxJ3T6.Location == new Point(703, 671 - (51))&& pcBoxJ3T6.Location == new Point(703, 671)) || (pcBoxJ4T6.Location == new Point(723, 671 - (51 * 10))&&pcBoxJ4T6.Location == new Point(723, 671 - (51 * 9))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 8))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 7))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 6))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 5))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 4))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 3))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 2))&& pcBoxJ4T6.Location == new Point(723, 671 - (51))&& pcBoxJ4T6.Location == new Point(723, 671))|| (pcBoxJ1T7.Location == new Point(771, (710 - 561) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 510) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 459) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 408) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 357) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 306) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 255) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 204) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 153) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 102) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 51) - 51)&&pcBoxJ1T7.Location == new Point(771, 710 - 51)&&pcBoxJ1T7.Location == new Point(771, 710) || (pcBoxJ2T7.Location == new Point(791, 710 - (51 * 12))&&pcBoxJ2T7.Location == new Point(791, 710 - (51 * 11))&&pcBoxJ2T7.Location == new Point(791, 710 - (51 * 10))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 9))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 8))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 7))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 6))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 5))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 4))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 3))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 2))&&pcBoxJ2T7.Location == new Point(791, 710 - (51))&&pcBoxJ2T7.Location == new Point(791, 710)) ||(pcBoxJ3T7.Location == new Point(770, 723 - (51 * 12))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 11))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 10))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 9))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 8))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 7))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 6))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 5))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 4))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 3))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 2))&& pcBoxJ3T7.Location == new Point(770, 723 - (51))&& pcBoxJ3T7.Location == new Point(770, 723) || (pcBoxJ4T7.Location == new Point(787, 723 - (51 * 12))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 11))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 10))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 9))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 8))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 7))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 6))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 5))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 4))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 3))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 2))&& pcBoxJ4T7.Location == new Point(787, 723 - (51))&& pcBoxJ4T7.Location == new Point(787, 723))|| (pcBoxJ1T9.Location == new Point(900, (608 - 357) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 306) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 255) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 204) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 153) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 102) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 51) - 51) && pcBoxJ1T9.Location == new Point(900, 608 - 51) && pcBoxJ1T9.Location == new Point(900, 608)) || (pcBoxJ2T9.Location == new Point(920, 608 - (51 * 8)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 7)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 6)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 5)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 4)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 3)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 2)) && pcBoxJ2T9.Location == new Point(920, 608 - (51)) && pcBoxJ2T9.Location == new Point(920, 608)) || (pcBoxJ3T9.Location == new Point(897, 618 - (51 * 8)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 7)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 6)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 5)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 4)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 3)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 2)) && pcBoxJ3T9.Location == new Point(897, 618 - (51)) && pcBoxJ3T9.Location == new Point(897, 618)) || (pcBoxJ4T9.Location == new Point(917, 618 - (51 * 8)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 7)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 6)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 5)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 4)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 3)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 2)) && pcBoxJ4T9.Location == new Point(917, 618 - (51)) && pcBoxJ4T9.Location == new Point(917, 618)) || (pcBoxJ1T10.Location == new Point(967, (559 - 255) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 204) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 153) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 102) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 51) - 51) && pcBoxJ1T10.Location == new Point(967, 559 - 51) && pcBoxJ1T10.Location == new Point(967, 559)) || (pcBoxJ2T10.Location == new Point(987, 559 - (51 * 6)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 5)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 4)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 3)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 2)) && pcBoxJ2T10.Location == new Point(987, 559 - (51)) && pcBoxJ2T10.Location == new Point(987, 559)) || (pcBoxJ3T10.Location == new Point(966, 572 - (51 * 6)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 5)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 4)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 3)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 2)) && pcBoxJ3T10.Location == new Point(966, 572 - (51)) && pcBoxJ3T10.Location == new Point(966, 572)) || (pcBoxJ4T10.Location == new Point(986, 572 - (51 * 6)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 5)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 4)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 3)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 2)) && pcBoxJ4T10.Location == new Point(986, 572 - (51)) && pcBoxJ4T10.Location == new Point(986, 572)) || (pcBoxJ1T11.Location == new Point(1031, (504 - 153) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 102) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 51) - 51) && pcBoxJ1T11.Location == new Point(1031, 504 - 51) && pcBoxJ1T11.Location == new Point(1031, 504)) || (pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 4)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 3)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 2)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51)) && pcBoxJ2T11.Location == new Point(1051, 504)) || (pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 4)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 3)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 2)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51)) && pcBoxJ3T11.Location == new Point(1036, 518))) || (pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 4)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 3)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 2)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51)) && pcBoxJ4T11.Location == new Point(1056, 518)) || (pcBoxJ1T12.Location == new Point(1097, (455 - 51) - 51) && pcBoxJ1T12.Location == new Point(1097, 455 - 51) && pcBoxJ1T12.Location == new Point(1097, 455)) || (pcBoxJ2T12.Location == new Point(1117, 455 - (51 * 2)) && pcBoxJ2T12.Location == new Point(1117, 455 - (51)) && pcBoxJ2T12.Location == new Point(1117, 455)) || (pcBoxJ3T12.Location == new Point(1097, 470 - (51 * 2)) && pcBoxJ3T12.Location == new Point(1097, 470 - (51)) && pcBoxJ3T12.Location == new Point(1097, 470)) || (pcBoxJ4T12.Location == new Point(1117, 470 - (51 * 2)) && pcBoxJ4T12.Location == new Point(1117, 470 - (51)) && pcBoxJ4T12.Location == new Point(1117, 470))))))))
                        //{

                        //if ((pcBoxJ1T2.Location == new Point(446, 455) && pcBoxJ1T2.Location == new Point(446, 455 - 51) && pcBoxJ1T2.Location == new Point(446, (455 - 51) - 51)) || (pcBoxJ2T2.Location == new Point(461, 455 - (51 * 2)) && pcBoxJ2T2.Location == new Point(461, 455 - 51) && pcBoxJ2T2.Location == new Point(461, 455)) || (pcBoxJ3T2.Location == new Point(446, 471 - (51 * 2)) && pcBoxJ3T2.Location == new Point(446, 471 - (51)) && pcBoxJ3T2.Location == new Point(446, 471)) || (pcBoxJ4T2.Location == new Point(466, 471 - (51 * 2)) && pcBoxJ4T2.Location == new Point(466, 471 - (51)) && pcBoxJ4T2.Location == new Point(466, 471)) || (pcBoxJ1T3.Location == new Point(507, (504 - 153) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 102) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 51) - 51) && pcBoxJ1T3.Location == new Point(507, 504 - 51) && pcBoxJ1T3.Location == new Point(507, 504)) || (pcBoxJ2T3.Location == new Point(527, 504 - (51 * 4)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 3)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 2)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 1)) && pcBoxJ2T3.Location == new Point(527, 504)) || (pcBoxJ3T3.Location == new Point(506, 521 - (51 * 4)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 3)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 2)) && pcBoxJ3T3.Location == new Point(506, 521 - (51)) && pcBoxJ3T3.Location == new Point(506, 521)) || (pcBoxJ4T3.Location == new Point(526, 521 - (51 * 4)) && pcBoxJ4T3.Location == new Point(526, 521 - (51 * 3)) && pcBoxJ4T3.Location == new Point(526, 521 - (51 * 2)) && pcBoxJ4T3.Location == new Point(526, 521 - (51)) && pcBoxJ4T3.Location == new Point(526, 521)) || (pcBoxJ1T4.Location == new Point(574, (559 - 255) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 204) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 153) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 102) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 51) - 51) && pcBoxJ1T4.Location == new Point(574, 559 - 51) && pcBoxJ1T4.Location == new Point(574, 559)) || (pcBoxJ2T4.Location == new Point(594, 559 - (51 * 6)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 5)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 4)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 3)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 2)) && pcBoxJ2T4.Location == new Point(594, 559 - 51) && pcBoxJ2T4.Location == new Point(594, 559)) || (pcBoxJ3T4.Location == new Point(574, 570 - (51 * 6)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 5)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 4)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 3)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 2)) && pcBoxJ3T4.Location == new Point(574, 570 - (51)) && pcBoxJ3T4.Location == new Point(574, 570)) || (pcBoxJ4T4.Location == new Point(594, 570 - (51 * 6)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 5)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 4)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 3)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 2)) && pcBoxJ4T4.Location == new Point(594, 570 - (51)) && pcBoxJ4T4.Location == new Point(594, 570)) || (pcBoxJ1T5.Location == new Point(639, (608 - 357) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 306) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 255) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 204) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 153) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 102) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 51) - 51) && pcBoxJ1T5.Location == new Point(639, 608 - 51) && pcBoxJ1T5.Location == new Point(639, 608)) || (pcBoxJ2T5.Location == new Point(659, 608 - (51 * 8)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 7)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 6)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 5)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 4)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 3)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 2)) && pcBoxJ2T5.Location == new Point(659, 608 - (51)) && pcBoxJ2T5.Location == new Point(659, 608)) || (pcBoxJ3T5.Location == new Point(639, 620 - (51 * 8)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 7)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 6)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 5)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 4)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 3)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 2)) && pcBoxJ3T5.Location == new Point(639, 620 - (51)) && pcBoxJ3T5.Location == new Point(639, 620)) || (pcBoxJ4T5.Location == new Point(659, 620 - (51 * 8)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 7)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 6)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 5)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 4)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 3)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 2)) && pcBoxJ4T5.Location == new Point(659, 620 - (51)) && pcBoxJ4T5.Location == new Point(659, 620)) || (pcBoxJ1T6.Location == new Point(705, (658 - 459) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 408) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 357) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 306) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 255) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 204) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 153) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 102) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 51) - 51) && pcBoxJ1T6.Location == new Point(705, 658 - 51) && pcBoxJ1T6.Location == new Point(705, 658)) || (pcBoxJ2T6.Location == new Point(725, 658 - (51 * 10)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 9)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 8)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 7)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 6)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 5)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 4)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 3)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 2)) && pcBoxJ2T6.Location == new Point(725, 658 - (51)) && pcBoxJ2T6.Location == new Point(725, 658)) || (pcBoxJ3T6.Location == new Point(703, 671 - (51 * 10)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 9)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 8)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 7)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 6)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 5)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 4)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 3)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 2)) && pcBoxJ3T6.Location == new Point(703, 671 - (51)) && pcBoxJ3T6.Location == new Point(703, 671)) || (pcBoxJ4T6.Location == new Point(723, 671 - (51 * 10)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 9)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 8)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 7)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 6)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 5)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 4)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 3)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 2)) && pcBoxJ4T6.Location == new Point(723, 671 - (51)) && pcBoxJ4T6.Location == new Point(723, 671)) || (pcBoxJ1T7.Location == new Point(771, (710 - 561) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 510) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 459) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 408) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 357) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 306) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 255) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 204) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 153) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 102) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 51) - 51) && pcBoxJ1T7.Location == new Point(771, 710 - 51) && pcBoxJ1T7.Location == new Point(771, 710)) || (pcBoxJ2T7.Location == new Point(791, 710 - (51 * 12)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 11)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 10)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 9)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 8)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 7)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 6)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 5)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 4)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 3)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 2)) && pcBoxJ2T7.Location == new Point(791, 710 - (51)) && pcBoxJ2T7.Location == new Point(791, 710)) || (pcBoxJ3T7.Location == new Point(770, 723 - (51 * 12)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 11)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 10)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 9)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 8)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 7)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 6)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 5)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 4)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 3)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 2)) && pcBoxJ3T7.Location == new Point(770, 723 - (51)) && pcBoxJ3T7.Location == new Point(770, 723)) || (pcBoxJ4T7.Location == new Point(787, 723 - (51 * 12)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 11)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 10)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 9)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 8)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 7)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 6)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 5)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 4)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 3)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 2)) && pcBoxJ4T7.Location == new Point(787, 723 - (51)) && pcBoxJ4T7.Location == new Point(787, 723)) || (pcBoxJ1T9.Location == new Point(900, (608 - 357) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 306) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 255) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 204) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 153) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 102) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 51) - 51) && pcBoxJ1T9.Location == new Point(900, 608 - 51) && pcBoxJ1T9.Location == new Point(900, 608)) || (pcBoxJ2T9.Location == new Point(920, 608 - (51 * 8)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 7)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 6)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 5)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 4)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 3)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 2)) && pcBoxJ2T9.Location == new Point(920, 608 - (51)) && pcBoxJ2T9.Location == new Point(920, 608)) || (pcBoxJ3T9.Location == new Point(897, 618 - (51 * 8)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 7)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 6)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 5)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 4)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 3)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 2)) && pcBoxJ3T9.Location == new Point(897, 618 - (51)) && pcBoxJ3T9.Location == new Point(897, 618)) || (pcBoxJ4T9.Location == new Point(917, 618 - (51 * 8)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 7)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 6)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 5)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 4)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 3)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 2)) && pcBoxJ4T9.Location == new Point(917, 618 - (51)) && pcBoxJ4T9.Location == new Point(917, 618)) || (pcBoxJ1T10.Location == new Point(967, (559 - 255) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 204) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 153) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 102) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 51) - 51) && pcBoxJ1T10.Location == new Point(967, 559 - 51) && pcBoxJ1T10.Location == new Point(967, 559)) || (pcBoxJ2T10.Location == new Point(987, 559 - (51 * 6)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 5)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 4)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 3)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 2)) && pcBoxJ2T10.Location == new Point(987, 559 - (51)) && pcBoxJ2T10.Location == new Point(987, 559)) || (pcBoxJ3T10.Location == new Point(966, 572 - (51 * 6)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 5)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 4)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 3)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 2)) && pcBoxJ3T10.Location == new Point(966, 572 - (51)) && pcBoxJ3T10.Location == new Point(966, 572)) || (pcBoxJ4T10.Location == new Point(986, 572 - (51 * 6)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 5)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 4)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 3)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 2)) && pcBoxJ4T10.Location == new Point(986, 572 - (51)) && pcBoxJ4T10.Location == new Point(986, 572)) || (pcBoxJ1T11.Location == new Point(1031, (504 - 153) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 102) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 51) - 51) && pcBoxJ1T11.Location == new Point(1031, 504 - 51) && pcBoxJ1T11.Location == new Point(1031, 504)) || (pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 4)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 3)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 2)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51)) && pcBoxJ2T11.Location == new Point(1051, 504)) || (pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 4)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 3)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 2)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51)) && pcBoxJ3T11.Location == new Point(1036, 518)) || (pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 4)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 3)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 2)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51)) && pcBoxJ4T11.Location == new Point(1056, 518)) || (pcBoxJ1T12.Location == new Point(1097, (455 - 51) - 51) && pcBoxJ1T12.Location == new Point(1097, 455 - 51) && pcBoxJ1T12.Location == new Point(1097, 455)) || (pcBoxJ2T12.Location == new Point(1117, 455 - (51 * 2)) && pcBoxJ2T12.Location == new Point(1117, 455 - (51)) && pcBoxJ2T12.Location == new Point(1117, 455)) || (pcBoxJ3T12.Location == new Point(1097, 470 - (51 * 2)) && pcBoxJ3T12.Location == new Point(1097, 470 - (51)) && pcBoxJ3T12.Location == new Point(1097, 470)) || (pcBoxJ4T12.Location == new Point(1117, 470 - (51 * 2)) && pcBoxJ4T12.Location == new Point(1117, 470 - (51)) && pcBoxJ4T12.Location == new Point(1117, 470)))
                        //{



                        //    //if (pcBoxJ1T8.Location == new Point(837, (658 - 459) - 51)&& pcBoxJ1T8.Location == new Point(837, (658 - 408) - 51)&&pcBoxJ1T8.Location == new Point(837, (658 - 357) - 51)&& pcBoxJ1T8.Location == new Point(837, (658 - 306) - 51)&& pcBoxJ1T8.Location == new Point(837, (658 - 255) - 51)&&pcBoxJ1T8.Location == new Point(837, (658 - 204) - 51)&&pcBoxJ1T8.Location == new Point(837, (658 - 153) - 51)&& pcBoxJ1T8.Location == new Point(837, (658 - 102) - 51)&&pcBoxJ1T8.Location == new Point(837, (658 - 51) - 51)&& pcBoxJ1T8.Location == new Point(837, 658 - 51)&&pcBoxJ1T8.Location == new Point(837, 658) || (pcBoxJ2T8.Location == new Point(857, 658 - (51 * 10))&&pcBoxJ2T8.Location == new Point(857, 658 - (51 * 9))&&pcBoxJ2T8.Location == new Point(857, 658 - (51 * 8))&&pcBoxJ2T8.Location == new Point(857, 658 - (51 * 7))&&pcBoxJ2T8.Location == new Point(857, 658 - (51 * 6))&& pcBoxJ2T8.Location == new Point(857, 658 - (51 * 5))&&pcBoxJ2T8.Location == new Point(857, 658 - (51 * 4))&&pcBoxJ2T8.Location == new Point(857, 658 - (51 * 3))&&pcBoxJ2T8.Location == new Point(857, 658 - (51 * 2))&&pcBoxJ2T8.Location == new Point(857, 658 - (51))&& pcBoxJ2T8.Location == new Point(857, 658)) || (pcBoxJ3T8.Location == new Point(836, 671 - (51 * 10)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 9))&& pcBoxJ3T8.Location == new Point(836, 671 - (51 * 8))&& pcBoxJ3T8.Location == new Point(836, 671 - (51 * 7))&& pcBoxJ3T8.Location == new Point(836, 671 - (51 * 6))&& pcBoxJ3T8.Location == new Point(836, 671 - (51 * 5)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 4))&&pcBoxJ3T8.Location == new Point(836, 671 - (51 * 3))&& pcBoxJ3T8.Location == new Point(836, 671 - (51 * 2))&& pcBoxJ3T8.Location == new Point(836, 671 - (51))&& pcBoxJ3T8.Location == new Point(836, 671)) || (pcBoxJ4T8.Location == new Point(856, 671 - (51 * 10)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 9))&& pcBoxJ4T8.Location == new Point(856, 671 - (51 * 8))&& pcBoxJ4T8.Location == new Point(856, 671 - (51 * 7)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 6)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 5))&& pcBoxJ4T8.Location == new Point(856, 671 - (51 * 4)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 3)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 2)) && pcBoxJ4T8.Location == new Point(856, 671 - (51)) && pcBoxJ4T8.Location == new Point(856, 671)))
                        //    //{
                        //    if (dado.Dado1 + dado.Dado3 == 8 || dado.Dado2 + dado.Dado4 == 8)
                        //    {
                        //        string ordem = "1324";
                        //        int R1 = dado.Dado1 + dado.Dado3;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado1 + dado.Dado4 == 8 || dado.Dado2 + dado.Dado3 == 8)
                        //    {
                        //        string ordem = "1423";
                        //        int R1 = dado.Dado1 + dado.Dado4;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado1 + dado.Dado2 == 8 || dado.Dado3 + dado.Dado4 == 8)
                        //    {
                        //        string ordem = "1234";
                        //        int R1 = dado.Dado1 + dado.Dado2;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado2 + dado.Dado3 == 8 || dado.Dado1 + dado.Dado4 == 8)
                        //    {
                        //        string ordem = "2314";
                        //        int R1 = dado.Dado2 + dado.Dado3;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado2 + dado.Dado4 == 8 || dado.Dado1 + dado.Dado3 == 8)
                        //    {
                        //        string ordem = "2413";
                        //        int R1 = dado.Dado2 + dado.Dado4;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado3 + dado.Dado4 == 8 || dado.Dado1 + dado.Dado2 == 8)
                        //    {
                        //        string ordem = "3412";
                        //        int R1 = dado.Dado3 + dado.Dado4;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //}

                        

                        //if (dado.Dado1 + dado.Dado4 == 8 || dado.Dado2 + dado.Dado3 == 8)
                        //{

                        //    string ordem = "1423";
                        //    int R1 = dado.Dado1 + dado.Dado4;
                        //    int R2 = dado.Dado2 + dado.Dado3;
                        //    string v1 = R1.ToString();
                        //    string v2 = R2.ToString();
                        //    if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //    if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //    string linha3 = v1 + v2;
                        //    string result = Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //    if (result.Substring(0, 4) == "ERRO")
                        //    {
                        //        Jogo.Mover(IdJogador, senhajogador, "2413", linha3);
                        //    }
                        //    Jogo.Parar(IdJogador, senhajogador);
                        //    goto Fim;
                        //}

                        //if (dado.Dado1 + dado.Dado2 == 8 || dado.Dado3 + dado.Dado4 == 8)
                        //{

                        //    string ordem = "1234";
                        //    int R1 = dado.Dado1 + dado.Dado2;
                        //    int R2 = dado.Dado3 + dado.Dado4;
                        //    string v1 = R1.ToString();
                        //    string v2 = R2.ToString();
                        //    if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //    if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //    string linha3 = v1 + v2;
                        //    string result = Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //    if (result.Substring(0, 4) == "ERRO")
                        //    {
                        //        Jogo.Mover(IdJogador, senhajogador, "2413", linha3);
                        //    }
                        //    Jogo.Parar(IdJogador, senhajogador);
                        //    goto Fim;
                        //}
                        //trilha 9

                        //if ((pcBoxJ1T2.Location == new Point(446, 455) && pcBoxJ1T2.Location == new Point(446, 455 - 51) && pcBoxJ1T2.Location == new Point(446, (455 - 51) - 51) || (pcBoxJ2T2.Location == new Point(461, 455 - (51 * 2)) && pcBoxJ2T2.Location == new Point(461, 455 - 51) && pcBoxJ2T2.Location == new Point(461, 455)) || (pcBoxJ3T2.Location == new Point(446, 471 - (51 * 2)) && pcBoxJ3T2.Location == new Point(446, 471 - (51)) && pcBoxJ3T2.Location == new Point(446, 471)) || (pcBoxJ4T2.Location == new Point(466, 471 - (51 * 2)) && pcBoxJ4T2.Location == new Point(466, 471 - (51)) && pcBoxJ4T2.Location == new Point(466, 471)) || (pcBoxJ1T3.Location == new Point(507, (504 - 153) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 102) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 51) - 51) && pcBoxJ1T3.Location == new Point(507, 504 - 51) && pcBoxJ1T3.Location == new Point(507, 504)) || (pcBoxJ2T3.Location == new Point(527, 504 - (51 * 4)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 3)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 2)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 1)) && pcBoxJ2T3.Location == new Point(527, 504)) || (pcBoxJ3T3.Location == new Point(506, 521 - (51 * 4)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 3)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 2)) && pcBoxJ3T3.Location == new Point(506, 521 - (51)) && pcBoxJ3T3.Location == new Point(506, 521)) || (pcBoxJ4T3.Location == new Point(526, 521 - (51 * 4)) && pcBoxJ4T3.Location == new Point(526, 521 - (51 * 3)) && pcBoxJ4T3.Location == new Point(526, 521 - (51 * 2)) && pcBoxJ4T3.Location == new Point(526, 521 - (51)) && pcBoxJ4T3.Location == new Point(526, 521)) || (pcBoxJ1T4.Location == new Point(574, (559 - 255) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 204) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 153) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 102) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 51) - 51) && pcBoxJ1T4.Location == new Point(574, 559 - 51) && pcBoxJ1T4.Location == new Point(574, 559) || (pcBoxJ2T4.Location == new Point(594, 559 - (51 * 6)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 5)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 4)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 3)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 2)) && pcBoxJ2T4.Location == new Point(594, 559 - 51) && pcBoxJ2T4.Location == new Point(594, 559)) || (pcBoxJ3T4.Location == new Point(574, 570 - (51 * 6)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 5)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 4)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 3)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 2)) && pcBoxJ3T4.Location == new Point(574, 570 - (51)) && pcBoxJ3T4.Location == new Point(574, 570)) || (pcBoxJ4T4.Location == new Point(594, 570 - (51 * 6)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 5)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 4)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 3)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 2)) && pcBoxJ4T4.Location == new Point(594, 570 - (51)) && pcBoxJ4T4.Location == new Point(594, 570)) || (pcBoxJ1T5.Location == new Point(639, (608 - 357) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 306) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 255) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 204) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 153) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 102) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 51) - 51) && pcBoxJ1T5.Location == new Point(639, 608 - 51) && pcBoxJ1T5.Location == new Point(639, 608) || (pcBoxJ2T5.Location == new Point(659, 608 - (51 * 8))&&pcBoxJ2T5.Location == new Point(659, 608 - (51 * 7))&&pcBoxJ2T5.Location == new Point(659, 608 - (51 * 6))&&pcBoxJ2T5.Location == new Point(659, 608 - (51 * 5))&& pcBoxJ2T5.Location == new Point(659, 608 - (51 * 4))&&pcBoxJ2T5.Location == new Point(659, 608 - (51 * 3))&& pcBoxJ2T5.Location == new Point(659, 608 - (51 * 2))&&pcBoxJ2T5.Location == new Point(659, 608 - (51))&& pcBoxJ2T5.Location == new Point(659, 608)) ||(pcBoxJ3T5.Location == new Point(639, 620 - (51 * 8))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 7))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 6))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 5))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 4))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 3))&& pcBoxJ3T5.Location == new Point(639, 620 - (51 * 2))&& pcBoxJ3T5.Location == new Point(639, 620 - (51))&& pcBoxJ3T5.Location == new Point(639, 620)) ||(pcBoxJ4T5.Location == new Point(659, 620 - (51 * 8))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 7))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 6))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 5))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 4))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 3))&& pcBoxJ4T5.Location == new Point(659, 620 - (51 * 2))&& pcBoxJ4T5.Location == new Point(659, 620 - (51))&& pcBoxJ4T5.Location == new Point(659, 620))||(pcBoxJ1T6.Location == new Point(705, (658 - 459) - 51)&& pcBoxJ1T6.Location == new Point(705, (658 - 408) - 51)&& pcBoxJ1T6.Location == new Point(705, (658 - 357) - 51)&&pcBoxJ1T6.Location == new Point(705, (658 - 306) - 51)&&pcBoxJ1T6.Location == new Point(705, (658 - 255) - 51)&&pcBoxJ1T6.Location == new Point(705, (658 - 204) - 51)&&pcBoxJ1T6.Location == new Point(705, (658 - 153) - 51) &&  pcBoxJ1T6.Location == new Point(705, (658 - 102) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 51) - 51)&&pcBoxJ1T6.Location == new Point(705, 658 - 51)&&pcBoxJ1T6.Location == new Point(705, 658) || (pcBoxJ2T6.Location == new Point(725, 658 - (51 * 10))&& pcBoxJ2T6.Location == new Point(725, 658 - (51 * 9))&& pcBoxJ2T6.Location == new Point(725, 658 - (51 * 8))&&pcBoxJ2T6.Location == new Point(725, 658 - (51 * 7))&& pcBoxJ2T6.Location == new Point(725, 658 - (51 * 6))&& pcBoxJ2T6.Location == new Point(725, 658 - (51 * 5))&&pcBoxJ2T6.Location == new Point(725, 658 - (51 * 4))&& pcBoxJ2T6.Location == new Point(725, 658 - (51 * 3))&&pcBoxJ2T6.Location == new Point(725, 658 - (51 * 2))&&pcBoxJ2T6.Location == new Point(725, 658 - (51))&& pcBoxJ2T6.Location == new Point(725, 658)) || (pcBoxJ3T6.Location == new Point(703, 671 - (51 * 10))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 9))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 8))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 7))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 6))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 5))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 4))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 3))&& pcBoxJ3T6.Location == new Point(703, 671 - (51 * 2))&& pcBoxJ3T6.Location == new Point(703, 671 - (51))&& pcBoxJ3T6.Location == new Point(703, 671)) || (pcBoxJ4T6.Location == new Point(723, 671 - (51 * 10))&&pcBoxJ4T6.Location == new Point(723, 671 - (51 * 9))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 8))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 7))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 6))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 5))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 4))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 3))&& pcBoxJ4T6.Location == new Point(723, 671 - (51 * 2))&& pcBoxJ4T6.Location == new Point(723, 671 - (51))&& pcBoxJ4T6.Location == new Point(723, 671))|| (pcBoxJ1T7.Location == new Point(771, (710 - 561) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 510) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 459) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 408) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 357) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 306) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 255) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 204) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 153) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 102) - 51)&&pcBoxJ1T7.Location == new Point(771, (710 - 51) - 51)&&pcBoxJ1T7.Location == new Point(771, 710 - 51)&&pcBoxJ1T7.Location == new Point(771, 710) || (pcBoxJ2T7.Location == new Point(791, 710 - (51 * 12))&&pcBoxJ2T7.Location == new Point(791, 710 - (51 * 11))&&pcBoxJ2T7.Location == new Point(791, 710 - (51 * 10))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 9))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 8))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 7))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 6))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 5))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 4))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 3))&& pcBoxJ2T7.Location == new Point(791, 710 - (51 * 2))&&pcBoxJ2T7.Location == new Point(791, 710 - (51))&&pcBoxJ2T7.Location == new Point(791, 710)) ||(pcBoxJ3T7.Location == new Point(770, 723 - (51 * 12))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 11))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 10))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 9))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 8))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 7))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 6))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 5))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 4))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 3))&& pcBoxJ3T7.Location == new Point(770, 723 - (51 * 2))&& pcBoxJ3T7.Location == new Point(770, 723 - (51))&& pcBoxJ3T7.Location == new Point(770, 723) || (pcBoxJ4T7.Location == new Point(787, 723 - (51 * 12))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 11))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 10))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 9))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 8))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 7))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 6))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 5))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 4))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 3))&& pcBoxJ4T7.Location == new Point(787, 723 - (51 * 2))&& pcBoxJ4T7.Location == new Point(787, 723 - (51))&& pcBoxJ4T7.Location == new Point(787, 723))|| (pcBoxJ1T8.Location == new Point(837, (658 - 459) - 51)&& pcBoxJ1T8.Location == new Point(837, (658 - 408) - 51)&&pcBoxJ1T8.Location == new Point(837, (658 - 357) - 51)&& pcBoxJ1T8.Location == new Point(837, (658 - 306) - 51)&& pcBoxJ1T8.Location == new Point(837, (658 - 255) - 51)&&pcBoxJ1T8.Location == new Point(837, (658 - 204) - 51)&&pcBoxJ1T8.Location == new Point(837, (658 - 153) - 51)&& pcBoxJ1T8.Location == new Point(837, (658 - 102) - 51)&&pcBoxJ1T8.Location == new Point(837, (658 - 51) - 51)&& pcBoxJ1T8.Location == new Point(837, 658 - 51)&&pcBoxJ1T8.Location == new Point(837, 658) || (pcBoxJ2T8.Location == new Point(857, 658 - (51 * 10))&&pcBoxJ2T8.Location == new Point(857, 658 - (51 * 9))&&pcBoxJ2T8.Location == new Point(857, 658 - (51 * 8))&&pcBoxJ2T8.Location == new Point(857, 658 - (51 * 7))&&pcBoxJ2T8.Location == new Point(857, 658 - (51 * 6))&& pcBoxJ2T8.Location == new Point(857, 658 - (51 * 5))&&pcBoxJ2T8.Location == new Point(857, 658 - (51 * 4))&&pcBoxJ2T8.Location == new Point(857, 658 - (51 * 3))&&pcBoxJ2T8.Location == new Point(857, 658 - (51 * 2))&&pcBoxJ2T8.Location == new Point(857, 658 - (51))&& pcBoxJ2T8.Location == new Point(857, 658)) || (pcBoxJ3T8.Location == new Point(836, 671 - (51 * 10)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 9))&& pcBoxJ3T8.Location == new Point(836, 671 - (51 * 8))&& pcBoxJ3T8.Location == new Point(836, 671 - (51 * 7))&& pcBoxJ3T8.Location == new Point(836, 671 - (51 * 6))&& pcBoxJ3T8.Location == new Point(836, 671 - (51 * 5)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 4))&&pcBoxJ3T8.Location == new Point(836, 671 - (51 * 3))&& pcBoxJ3T8.Location == new Point(836, 671 - (51 * 2))&& pcBoxJ3T8.Location == new Point(836, 671 - (51))&& pcBoxJ3T8.Location == new Point(836, 671)) || (pcBoxJ4T8.Location == new Point(856, 671 - (51 * 10)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 9))&& pcBoxJ4T8.Location == new Point(856, 671 - (51 * 8))&& pcBoxJ4T8.Location == new Point(856, 671 - (51 * 7)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 6)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 5))&& pcBoxJ4T8.Location == new Point(856, 671 - (51 * 4)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 3)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 2)) && pcBoxJ4T8.Location == new Point(856, 671 - (51)) && pcBoxJ4T8.Location == new Point(856, 671))|| (pcBoxJ1T10.Location == new Point(967, (559 - 255) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 204) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 153) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 102) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 51) - 51) && pcBoxJ1T10.Location == new Point(967, 559 - 51) && pcBoxJ1T10.Location == new Point(967, 559)) || (pcBoxJ2T10.Location == new Point(987, 559 - (51 * 6)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 5)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 4)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 3)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 2)) && pcBoxJ2T10.Location == new Point(987, 559 - (51)) && pcBoxJ2T10.Location == new Point(987, 559)) || (pcBoxJ3T10.Location == new Point(966, 572 - (51 * 6)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 5)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 4)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 3)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 2)) && pcBoxJ3T10.Location == new Point(966, 572 - (51)) && pcBoxJ3T10.Location == new Point(966, 572)) || (pcBoxJ4T10.Location == new Point(986, 572 - (51 * 6)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 5)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 4)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 3)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 2)) && pcBoxJ4T10.Location == new Point(986, 572 - (51)) && pcBoxJ4T10.Location == new Point(986, 572)) || (pcBoxJ1T11.Location == new Point(1031, (504 - 153) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 102) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 51) - 51) && pcBoxJ1T11.Location == new Point(1031, 504 - 51) && pcBoxJ1T11.Location == new Point(1031, 504)) || (pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 4)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 3)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 2)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51)) && pcBoxJ2T11.Location == new Point(1051, 504)) || (pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 4)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 3)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 2)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51)) && pcBoxJ3T11.Location == new Point(1036, 518))) || (pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 4)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 3)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 2)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51)) && pcBoxJ4T11.Location == new Point(1056, 518)) || (pcBoxJ1T12.Location == new Point(1097, (455 - 51) - 51) && pcBoxJ1T12.Location == new Point(1097, 455 - 51) && pcBoxJ1T12.Location == new Point(1097, 455)) || (pcBoxJ2T12.Location == new Point(1117, 455 - (51 * 2)) && pcBoxJ2T12.Location == new Point(1117, 455 - (51)) && pcBoxJ2T12.Location == new Point(1117, 455)) || (pcBoxJ3T12.Location == new Point(1097, 470 - (51 * 2)) && pcBoxJ3T12.Location == new Point(1097, 470 - (51)) && pcBoxJ3T12.Location == new Point(1097, 470)) || (pcBoxJ4T12.Location == new Point(1117, 470 - (51 * 2)) && pcBoxJ4T12.Location == new Point(1117, 470 - (51)) && pcBoxJ4T12.Location == new Point(1117, 470)))))))))
                        //{

                        //    //if ((pcBoxJ1T2.Location == new Point(446, 455) && pcBoxJ1T2.Location == new Point(446, 455 - 51) && pcBoxJ1T2.Location == new Point(446, (455 - 51) - 51) || (pcBoxJ2T2.Location == new Point(461, 455 - (51 * 2)) && pcBoxJ2T2.Location == new Point(461, 455 - 51) && pcBoxJ2T2.Location == new Point(461, 455)) || (pcBoxJ3T2.Location == new Point(446, 471 - (51 * 2)) && pcBoxJ3T2.Location == new Point(446, 471 - (51)) && pcBoxJ3T2.Location == new Point(446, 471)) || (pcBoxJ4T2.Location == new Point(466, 471 - (51 * 2)) && pcBoxJ4T2.Location == new Point(466, 471 - (51)) && pcBoxJ4T2.Location == new Point(466, 471))) || (pcBoxJ1T3.Location == new Point(507, (504 - 153) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 102) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 51) - 51) && pcBoxJ1T3.Location == new Point(507, 504 - 51) && pcBoxJ1T3.Location == new Point(507, 504) || (pcBoxJ2T3.Location == new Point(527, 504 - (51 * 4)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 3)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 2)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 1)) && pcBoxJ2T3.Location == new Point(527, 504)) || (pcBoxJ3T3.Location == new Point(506, 521 - (51 * 4)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 3)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 2)) && pcBoxJ3T3.Location == new Point(506, 521 - (51)) && pcBoxJ3T3.Location == new Point(506, 521)) || (pcBoxJ1T4.Location == new Point(574, (559 - 255) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 204) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 153) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 102) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 51) - 51) && pcBoxJ1T4.Location == new Point(574, 559 - 51) && pcBoxJ1T4.Location == new Point(574, 559) || (pcBoxJ2T4.Location == new Point(594, 559 - (51 * 6)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 5)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 4)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 3)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 2)) && pcBoxJ2T4.Location == new Point(594, 559 - 51) && pcBoxJ2T4.Location == new Point(594, 559)) || (pcBoxJ3T4.Location == new Point(574, 570 - (51 * 6)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 5)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 4)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 3)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 2)) && pcBoxJ3T4.Location == new Point(574, 570 - (51)) && pcBoxJ3T4.Location == new Point(574, 570)) || (pcBoxJ4T4.Location == new Point(594, 570 - (51 * 6)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 5)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 4)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 3)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 2)) && pcBoxJ4T4.Location == new Point(594, 570 - (51)) && pcBoxJ4T4.Location == new Point(594, 570))) || (pcBoxJ1T5.Location == new Point(639, (608 - 357) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 306) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 255) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 204) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 153) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 102) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 51) - 51) && pcBoxJ1T5.Location == new Point(639, 608 - 51) && pcBoxJ1T5.Location == new Point(639, 608) || (pcBoxJ2T5.Location == new Point(659, 608 - (51 * 8)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 7)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 6)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 5)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 4)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 3)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 2)) && pcBoxJ2T5.Location == new Point(659, 608 - (51)) && pcBoxJ2T5.Location == new Point(659, 608)) || (pcBoxJ3T5.Location == new Point(639, 620 - (51 * 8)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 7)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 6)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 5)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 4)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 3)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 2)) && pcBoxJ3T5.Location == new Point(639, 620 - (51)) && pcBoxJ3T5.Location == new Point(639, 620)) || (pcBoxJ4T5.Location == new Point(659, 620 - (51 * 8)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 7)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 6)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 5)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 4)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 3)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 2)) && pcBoxJ4T5.Location == new Point(659, 620 - (51)) && pcBoxJ4T5.Location == new Point(659, 620)) || (pcBoxJ1T6.Location == new Point(705, (658 - 459) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 408) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 357) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 306) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 255) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 204) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 153) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 102) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 51) - 51) && pcBoxJ1T6.Location == new Point(705, 658 - 51) && pcBoxJ1T6.Location == new Point(705, 658) || (pcBoxJ2T6.Location == new Point(725, 658 - (51 * 10)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 9)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 8)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 7)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 6)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 5)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 4)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 3)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 2)) && pcBoxJ2T6.Location == new Point(725, 658 - (51)) && pcBoxJ2T6.Location == new Point(725, 658)) || (pcBoxJ3T6.Location == new Point(703, 671 - (51 * 10)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 9)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 8)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 7)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 6)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 5)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 4)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 3)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 2)) && pcBoxJ3T6.Location == new Point(703, 671 - (51)) && pcBoxJ3T6.Location == new Point(703, 671)) || (pcBoxJ4T6.Location == new Point(723, 671 - (51 * 10)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 9)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 8)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 7)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 6)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 5)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 4)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 3)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 2)) && pcBoxJ4T6.Location == new Point(723, 671 - (51)) && pcBoxJ4T6.Location == new Point(723, 671))) || (pcBoxJ1T7.Location == new Point(771, (710 - 561) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 510) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 459) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 408) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 357) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 306) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 255) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 204) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 153) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 102) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 51) - 51) && pcBoxJ1T7.Location == new Point(771, 710 - 51) && pcBoxJ1T7.Location == new Point(771, 710) || (pcBoxJ2T7.Location == new Point(791, 710 - (51 * 12)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 11)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 10)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 9)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 8)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 7)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 6)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 5)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 4)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 3)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 2)) && pcBoxJ2T7.Location == new Point(791, 710 - (51)) && pcBoxJ2T7.Location == new Point(791, 710)) || (pcBoxJ3T7.Location == new Point(770, 723 - (51 * 12)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 11)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 10)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 9)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 8)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 7)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 6)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 5)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 4)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 3)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 2)) && pcBoxJ3T7.Location == new Point(770, 723 - (51)) && pcBoxJ3T7.Location == new Point(770, 723) || (pcBoxJ4T7.Location == new Point(787, 723 - (51 * 12)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 11)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 10)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 9)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 8)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 7)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 6)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 5)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 4)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 3)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 2)) && pcBoxJ4T7.Location == new Point(787, 723 - (51)) && pcBoxJ4T7.Location == new Point(787, 723)) || (pcBoxJ1T8.Location == new Point(837, (658 - 459) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 408) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 357) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 306) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 255) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 204) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 153) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 102) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 51) - 51) && pcBoxJ1T8.Location == new Point(837, 658 - 51) && pcBoxJ1T8.Location == new Point(837, 658) || (pcBoxJ2T8.Location == new Point(857, 658 - (51 * 10)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 9)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 8)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 7)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 6)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 5)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 4)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 3)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 2)) && pcBoxJ2T8.Location == new Point(857, 658 - (51)) && pcBoxJ2T8.Location == new Point(857, 658)) || (pcBoxJ3T8.Location == new Point(836, 671 - (51 * 10)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 9)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 8)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 7)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 6)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 5)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 4)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 3)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 2)) && pcBoxJ3T8.Location == new Point(836, 671 - (51)) && pcBoxJ3T8.Location == new Point(836, 671)) || (pcBoxJ4T8.Location == new Point(856, 671 - (51 * 10)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 9)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 8)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 7)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 6)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 5)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 4)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 3)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 2)) && pcBoxJ4T8.Location == new Point(856, 671 - (51)) && pcBoxJ4T8.Location == new Point(856, 671))) || (pcBoxJ1T10.Location == new Point(967, (559 - 255) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 204) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 153) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 102) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 51) - 51) && pcBoxJ1T10.Location == new Point(967, 559 - 51) && pcBoxJ1T10.Location == new Point(967, 559) || (pcBoxJ2T10.Location == new Point(987, 559 - (51 * 6)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 5)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 4)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 3)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 2)) && pcBoxJ2T10.Location == new Point(987, 559 - (51)) && pcBoxJ2T10.Location == new Point(987, 559)) || (pcBoxJ3T10.Location == new Point(966, 572 - (51 * 6)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 5)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 4)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 3)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 2)) && pcBoxJ3T10.Location == new Point(966, 572 - (51)) && pcBoxJ3T10.Location == new Point(966, 572)) || (pcBoxJ4T10.Location == new Point(986, 572 - (51 * 6)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 5)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 4)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 3)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 2)) && pcBoxJ4T10.Location == new Point(986, 572 - (51)) && pcBoxJ4T10.Location == new Point(986, 572))) || (pcBoxJ1T11.Location == new Point(1031, (504 - 153) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 102) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 51) - 51) && pcBoxJ1T11.Location == new Point(1031, 504 - 51) && pcBoxJ1T11.Location == new Point(1031, 504) || (pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 4)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 3)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 2)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51)) && pcBoxJ2T11.Location == new Point(1051, 504)) || (pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 4)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 3)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 2)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51)) && pcBoxJ3T11.Location == new Point(1036, 518)) || (pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 4)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 3)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 2)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51)) && pcBoxJ4T11.Location == new Point(1056, 518))) || (pcBoxJ1T12.Location == new Point(1097, (455 - 51) - 51) && pcBoxJ1T12.Location == new Point(1097, 455 - 51) && pcBoxJ1T12.Location == new Point(1097, 455) || (pcBoxJ2T12.Location == new Point(1117, 455 - (51 * 2)) && pcBoxJ2T12.Location == new Point(1117, 455 - (51)) && pcBoxJ2T12.Location == new Point(1117, 455)) || (pcBoxJ3T12.Location == new Point(1097, 470 - (51 * 2)) && pcBoxJ3T12.Location == new Point(1097, 470 - (51)) && pcBoxJ3T12.Location == new Point(1097, 470)) || (pcBoxJ4T12.Location == new Point(1117, 470 - (51 * 2)) && pcBoxJ4T12.Location == new Point(1117, 470 - (51)) && pcBoxJ4T12.Location == new Point(1117, 470))))))))
                        //    //{
                        //    //if (pcBoxJ1T9.Location == new Point(900, (608 - 357) - 51)&& pcBoxJ1T9.Location == new Point(900, (608 - 306) - 51)&& pcBoxJ1T9.Location == new Point(900, (608 - 255) - 51)&& pcBoxJ1T9.Location == new Point(900, (608 - 204) - 51)&& pcBoxJ1T9.Location == new Point(900, (608 - 153) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 102) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 51) - 51)&& pcBoxJ1T9.Location == new Point(900, 608 - 51)&& pcBoxJ1T9.Location == new Point(900, 608) || (pcBoxJ2T9.Location == new Point(920, 608 - (51 * 8))&& pcBoxJ2T9.Location == new Point(920, 608 - (51 * 7))&&pcBoxJ2T9.Location == new Point(920, 608 - (51 * 6))&&pcBoxJ2T9.Location == new Point(920, 608 - (51 * 5))&&pcBoxJ2T9.Location == new Point(920, 608 - (51 * 4))&& pcBoxJ2T9.Location == new Point(920, 608 - (51 * 3))&& pcBoxJ2T9.Location == new Point(920, 608 - (51 * 2))&& pcBoxJ2T9.Location == new Point(920, 608 - (51))&&pcBoxJ2T9.Location == new Point(920, 608)) || (pcBoxJ3T9.Location == new Point(897, 618 - (51 * 8))&&pcBoxJ3T9.Location == new Point(897, 618 - (51 * 7))&&pcBoxJ3T9.Location == new Point(897, 618 - (51 * 6))&&pcBoxJ3T9.Location == new Point(897, 618 - (51 * 5))&&pcBoxJ3T9.Location == new Point(897, 618 - (51 * 4))&&pcBoxJ3T9.Location == new Point(897, 618 - (51 * 3))&&pcBoxJ3T9.Location == new Point(897, 618 - (51 * 2))&&pcBoxJ3T9.Location == new Point(897, 618 - (51))&& pcBoxJ3T9.Location == new Point(897, 618)) ||(pcBoxJ4T9.Location == new Point(917, 618 - (51 * 8)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 7))&& pcBoxJ4T9.Location == new Point(917, 618 - (51 * 6)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 5)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 4))&& pcBoxJ4T9.Location == new Point(917, 618 - (51 * 3)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 2)) && pcBoxJ4T9.Location == new Point(917, 618 - (51))&& pcBoxJ4T9.Location == new Point(917, 618)))
                        //    //{
                        //    if (dado.Dado1 + dado.Dado3 == 9 || dado.Dado2 + dado.Dado4 == 9)
                        //    {
                        //        string ordem = "1324";
                        //        int R1 = dado.Dado1 + dado.Dado3;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado1 + dado.Dado4 == 9 || dado.Dado2 + dado.Dado3 == 9)
                        //    {
                        //        string ordem = "1423";
                        //        int R1 = dado.Dado1 + dado.Dado4;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado1 + dado.Dado2 == 9 || dado.Dado3 + dado.Dado4 == 9)
                        //    {
                        //        string ordem = "1234";
                        //        int R1 = dado.Dado1 + dado.Dado2;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado2 + dado.Dado3 == 9 || dado.Dado1 + dado.Dado4 == 9)
                        //    {
                        //        string ordem = "2314";
                        //        int R1 = dado.Dado2 + dado.Dado3;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado2 + dado.Dado4 == 9 || dado.Dado1 + dado.Dado3 == 9)
                        //    {
                        //        string ordem = "2413";
                        //        int R1 = dado.Dado2 + dado.Dado4;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado3 + dado.Dado4 == 9 || dado.Dado1 + dado.Dado2 == 9)
                        //    {
                        //        string ordem = "3412";
                        //        int R1 = dado.Dado3 + dado.Dado4;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //}


                        //if (dado.Dado1 + dado.Dado4 == 9 || dado.Dado2 + dado.Dado3 == 9)
                        //{

                        //    string ordem = "1423";
                        //    int R1 = dado.Dado1 + dado.Dado4;
                        //    int R2 = dado.Dado2 + dado.Dado3;
                        //    string v1 = R1.ToString();
                        //    string v2 = R2.ToString();
                        //    if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //    if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //    string linha3 = v1 + v2;
                        //    string result = Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //    if (result.Substring(0, 4) == "ERRO")
                        //    {
                        //        Jogo.Mover(IdJogador, senhajogador, "2413", linha3);
                        //    }
                        //    Jogo.Parar(IdJogador, senhajogador);
                        //    goto Fim;
                        //}

                        //if (dado.Dado1 + dado.Dado2 == 9 || dado.Dado3 + dado.Dado4 == 9)
                        //{

                        //    string ordem = "1234";
                        //    int R1 = dado.Dado1 + dado.Dado2;
                        //    int R2 = dado.Dado3 + dado.Dado4;
                        //    string v1 = R1.ToString();
                        //    string v2 = R2.ToString();
                        //    if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //    if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //    string linha3 = v1 + v2;
                        //    string result = Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //    if (result.Substring(0, 4) == "ERRO")
                        //    {
                        //        Jogo.Mover(IdJogador, senhajogador, "2413", linha3);
                        //    }
                        //    Jogo.Parar(IdJogador, senhajogador);
                        //    goto Fim;
                        //}

                        ////trilha 10
                        //if ((pcBoxJ1T2.Location == new Point(446, 455) && pcBoxJ1T2.Location == new Point(446, 455 - 51) && pcBoxJ1T2.Location == new Point(446, (455 - 51) - 51) || (pcBoxJ2T2.Location == new Point(461, 455 - (51 * 2)) && pcBoxJ2T2.Location == new Point(461, 455 - 51) && pcBoxJ2T2.Location == new Point(461, 455)) || (pcBoxJ3T2.Location == new Point(446, 471 - (51 * 2)) && pcBoxJ3T2.Location == new Point(446, 471 - (51)) && pcBoxJ3T2.Location == new Point(446, 471)) || (pcBoxJ4T2.Location == new Point(466, 471 - (51 * 2)) && pcBoxJ4T2.Location == new Point(466, 471 - (51)) && pcBoxJ4T2.Location == new Point(466, 471)) || (pcBoxJ1T3.Location == new Point(507, (504 - 153) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 102) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 51) - 51) && pcBoxJ1T3.Location == new Point(507, 504 - 51) && pcBoxJ1T3.Location == new Point(507, 504)) || (pcBoxJ2T3.Location == new Point(527, 504 - (51 * 4)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 3)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 2)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 1)) && pcBoxJ2T3.Location == new Point(527, 504)) || (pcBoxJ3T3.Location == new Point(506, 521 - (51 * 4)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 3)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 2)) && pcBoxJ3T3.Location == new Point(506, 521 - (51)) && pcBoxJ3T3.Location == new Point(506, 521)) || (pcBoxJ4T3.Location == new Point(526, 521 - (51 * 4)) && pcBoxJ4T3.Location == new Point(526, 521 - (51 * 3)) && pcBoxJ4T3.Location == new Point(526, 521 - (51 * 2)) && pcBoxJ4T3.Location == new Point(526, 521 - (51)) && pcBoxJ4T3.Location == new Point(526, 521)) || (pcBoxJ1T4.Location == new Point(574, (559 - 255) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 204) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 153) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 102) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 51) - 51) && pcBoxJ1T4.Location == new Point(574, 559 - 51) && pcBoxJ1T4.Location == new Point(574, 559) || (pcBoxJ2T4.Location == new Point(594, 559 - (51 * 6)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 5)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 4)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 3)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 2)) && pcBoxJ2T4.Location == new Point(594, 559 - 51) && pcBoxJ2T4.Location == new Point(594, 559)) || (pcBoxJ3T4.Location == new Point(574, 570 - (51 * 6)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 5)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 4)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 3)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 2)) && pcBoxJ3T4.Location == new Point(574, 570 - (51)) && pcBoxJ3T4.Location == new Point(574, 570)) || (pcBoxJ4T4.Location == new Point(594, 570 - (51 * 6)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 5)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 4)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 3)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 2)) && pcBoxJ4T4.Location == new Point(594, 570 - (51)) && pcBoxJ4T4.Location == new Point(594, 570)) || (pcBoxJ1T5.Location == new Point(639, (608 - 357) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 306) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 255) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 204) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 153) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 102) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 51) - 51) && pcBoxJ1T5.Location == new Point(639, 608 - 51) && pcBoxJ1T5.Location == new Point(639, 608) || (pcBoxJ2T5.Location == new Point(659, 608 - (51 * 8)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 7)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 6)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 5)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 4)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 3)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 2)) && pcBoxJ2T5.Location == new Point(659, 608 - (51)) && pcBoxJ2T5.Location == new Point(659, 608)) || (pcBoxJ3T5.Location == new Point(639, 620 - (51 * 8)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 7)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 6)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 5)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 4)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 3)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 2)) && pcBoxJ3T5.Location == new Point(639, 620 - (51)) && pcBoxJ3T5.Location == new Point(639, 620)) || (pcBoxJ4T5.Location == new Point(659, 620 - (51 * 8)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 7)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 6)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 5)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 4)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 3)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 2)) && pcBoxJ4T5.Location == new Point(659, 620 - (51)) && pcBoxJ4T5.Location == new Point(659, 620)) || (pcBoxJ1T6.Location == new Point(705, (658 - 459) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 408) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 357) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 306) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 255) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 204) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 153) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 102) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 51) - 51) && pcBoxJ1T6.Location == new Point(705, 658 - 51) && pcBoxJ1T6.Location == new Point(705, 658) || (pcBoxJ2T6.Location == new Point(725, 658 - (51 * 10)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 9)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 8)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 7)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 6)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 5)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 4)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 3)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 2)) && pcBoxJ2T6.Location == new Point(725, 658 - (51)) && pcBoxJ2T6.Location == new Point(725, 658)) || (pcBoxJ3T6.Location == new Point(703, 671 - (51 * 10)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 9)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 8)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 7)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 6)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 5)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 4)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 3)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 2)) && pcBoxJ3T6.Location == new Point(703, 671 - (51)) && pcBoxJ3T6.Location == new Point(703, 671)) || (pcBoxJ4T6.Location == new Point(723, 671 - (51 * 10)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 9)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 8)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 7)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 6)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 5)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 4)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 3)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 2)) && pcBoxJ4T6.Location == new Point(723, 671 - (51)) && pcBoxJ4T6.Location == new Point(723, 671)) || (pcBoxJ1T7.Location == new Point(771, (710 - 561) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 510) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 459) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 408) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 357) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 306) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 255) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 204) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 153) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 102) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 51) - 51) && pcBoxJ1T7.Location == new Point(771, 710 - 51) && pcBoxJ1T7.Location == new Point(771, 710) || (pcBoxJ2T7.Location == new Point(791, 710 - (51 * 12)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 11)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 10)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 9)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 8)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 7)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 6)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 5)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 4)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 3)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 2)) && pcBoxJ2T7.Location == new Point(791, 710 - (51)) && pcBoxJ2T7.Location == new Point(791, 710)) || (pcBoxJ3T7.Location == new Point(770, 723 - (51 * 12)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 11)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 10)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 9)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 8)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 7)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 6)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 5)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 4)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 3)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 2)) && pcBoxJ3T7.Location == new Point(770, 723 - (51)) && pcBoxJ3T7.Location == new Point(770, 723) || (pcBoxJ4T7.Location == new Point(787, 723 - (51 * 12)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 11)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 10)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 9)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 8)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 7)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 6)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 5)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 4)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 3)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 2)) && pcBoxJ4T7.Location == new Point(787, 723 - (51)) && pcBoxJ4T7.Location == new Point(787, 723)) || (pcBoxJ1T8.Location == new Point(837, (658 - 459) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 408) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 357) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 306) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 255) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 204) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 153) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 102) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 51) - 51) && pcBoxJ1T8.Location == new Point(837, 658 - 51) && pcBoxJ1T8.Location == new Point(837, 658) || (pcBoxJ2T8.Location == new Point(857, 658 - (51 * 10)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 9)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 8)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 7)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 6)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 5)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 4)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 3)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 2)) && pcBoxJ2T8.Location == new Point(857, 658 - (51)) && pcBoxJ2T8.Location == new Point(857, 658)) || (pcBoxJ3T8.Location == new Point(836, 671 - (51 * 10)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 9)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 8)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 7)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 6)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 5)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 4)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 3)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 2)) && pcBoxJ3T8.Location == new Point(836, 671 - (51)) && pcBoxJ3T8.Location == new Point(836, 671)) || (pcBoxJ4T8.Location == new Point(856, 671 - (51 * 10)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 9)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 8)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 7)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 6)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 5)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 4)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 3)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 2)) && pcBoxJ4T8.Location == new Point(856, 671 - (51)) && pcBoxJ4T8.Location == new Point(856, 671)) || (pcBoxJ1T9.Location == new Point(900, (608 - 357) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 306) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 255) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 204) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 153) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 102) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 51) - 51) && pcBoxJ1T9.Location == new Point(900, 608 - 51) && pcBoxJ1T9.Location == new Point(900, 608) || (pcBoxJ2T9.Location == new Point(920, 608 - (51 * 8)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 7)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 6)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 5)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 4)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 3)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 2)) && pcBoxJ2T9.Location == new Point(920, 608 - (51)) && pcBoxJ2T9.Location == new Point(920, 608)) || (pcBoxJ3T9.Location == new Point(897, 618 - (51 * 8)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 7)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 6)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 5)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 4)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 3)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 2)) && pcBoxJ3T9.Location == new Point(897, 618 - (51)) && pcBoxJ3T9.Location == new Point(897, 618)) || (pcBoxJ4T9.Location == new Point(917, 618 - (51 * 8)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 7)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 6)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 5)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 4)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 3)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 2)) && pcBoxJ4T9.Location == new Point(917, 618 - (51)) && pcBoxJ4T9.Location == new Point(917, 618)) || (pcBoxJ1T11.Location == new Point(1031, (504 - 153) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 102) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 51) - 51) && pcBoxJ1T11.Location == new Point(1031, 504 - 51) && pcBoxJ1T11.Location == new Point(1031, 504)) || (pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 4)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 3)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 2)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51)) && pcBoxJ2T11.Location == new Point(1051, 504)) || (pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 4)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 3)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 2)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51)) && pcBoxJ3T11.Location == new Point(1036, 518))) || (pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 4)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 3)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 2)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51)) && pcBoxJ4T11.Location == new Point(1056, 518)) || (pcBoxJ1T12.Location == new Point(1097, (455 - 51) - 51) && pcBoxJ1T12.Location == new Point(1097, 455 - 51) && pcBoxJ1T12.Location == new Point(1097, 455)) || (pcBoxJ2T12.Location == new Point(1117, 455 - (51 * 2)) && pcBoxJ2T12.Location == new Point(1117, 455 - (51)) && pcBoxJ2T12.Location == new Point(1117, 455)) || (pcBoxJ3T12.Location == new Point(1097, 470 - (51 * 2)) && pcBoxJ3T12.Location == new Point(1097, 470 - (51)) && pcBoxJ3T12.Location == new Point(1097, 470)) || (pcBoxJ4T12.Location == new Point(1117, 470 - (51 * 2)) && pcBoxJ4T12.Location == new Point(1117, 470 - (51)) && pcBoxJ4T12.Location == new Point(1117, 470))))))))))
                        //{

                        //    //if ((pcBoxJ1T2.Location == new Point(446, 455) && pcBoxJ1T2.Location == new Point(446, 455 - 51) && pcBoxJ1T2.Location == new Point(446, (455 - 51) - 51) || (pcBoxJ2T2.Location == new Point(461, 455 - (51 * 2)) && pcBoxJ2T2.Location == new Point(461, 455 - 51) && pcBoxJ2T2.Location == new Point(461, 455)) || (pcBoxJ3T2.Location == new Point(446, 471 - (51 * 2)) && pcBoxJ3T2.Location == new Point(446, 471 - (51)) && pcBoxJ3T2.Location == new Point(446, 471)) || (pcBoxJ4T2.Location == new Point(466, 471 - (51 * 2)) && pcBoxJ4T2.Location == new Point(466, 471 - (51)) && pcBoxJ4T2.Location == new Point(466, 471))) || (pcBoxJ1T3.Location == new Point(507, (504 - 153) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 102) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 51) - 51) && pcBoxJ1T3.Location == new Point(507, 504 - 51) && pcBoxJ1T3.Location == new Point(507, 504) || (pcBoxJ2T3.Location == new Point(527, 504 - (51 * 4)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 3)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 2)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 1)) && pcBoxJ2T3.Location == new Point(527, 504)) || (pcBoxJ3T3.Location == new Point(506, 521 - (51 * 4)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 3)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 2)) && pcBoxJ3T3.Location == new Point(506, 521 - (51)) && pcBoxJ3T3.Location == new Point(506, 521)) || (pcBoxJ1T4.Location == new Point(574, (559 - 255) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 204) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 153) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 102) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 51) - 51) && pcBoxJ1T4.Location == new Point(574, 559 - 51) && pcBoxJ1T4.Location == new Point(574, 559) || (pcBoxJ2T4.Location == new Point(594, 559 - (51 * 6)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 5)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 4)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 3)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 2)) && pcBoxJ2T4.Location == new Point(594, 559 - 51) && pcBoxJ2T4.Location == new Point(594, 559)) || (pcBoxJ3T4.Location == new Point(574, 570 - (51 * 6)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 5)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 4)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 3)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 2)) && pcBoxJ3T4.Location == new Point(574, 570 - (51)) && pcBoxJ3T4.Location == new Point(574, 570)) || (pcBoxJ4T4.Location == new Point(594, 570 - (51 * 6)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 5)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 4)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 3)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 2)) && pcBoxJ4T4.Location == new Point(594, 570 - (51)) && pcBoxJ4T4.Location == new Point(594, 570))) || (pcBoxJ1T5.Location == new Point(639, (608 - 357) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 306) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 255) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 204) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 153) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 102) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 51) - 51) && pcBoxJ1T5.Location == new Point(639, 608 - 51) && pcBoxJ1T5.Location == new Point(639, 608) || (pcBoxJ2T5.Location == new Point(659, 608 - (51 * 8)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 7)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 6)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 5)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 4)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 3)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 2)) && pcBoxJ2T5.Location == new Point(659, 608 - (51)) && pcBoxJ2T5.Location == new Point(659, 608)) || (pcBoxJ3T5.Location == new Point(639, 620 - (51 * 8)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 7)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 6)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 5)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 4)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 3)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 2)) && pcBoxJ3T5.Location == new Point(639, 620 - (51)) && pcBoxJ3T5.Location == new Point(639, 620)) || (pcBoxJ4T5.Location == new Point(659, 620 - (51 * 8)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 7)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 6)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 5)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 4)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 3)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 2)) && pcBoxJ4T5.Location == new Point(659, 620 - (51)) && pcBoxJ4T5.Location == new Point(659, 620)) || (pcBoxJ1T6.Location == new Point(705, (658 - 459) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 408) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 357) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 306) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 255) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 204) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 153) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 102) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 51) - 51) && pcBoxJ1T6.Location == new Point(705, 658 - 51) && pcBoxJ1T6.Location == new Point(705, 658) || (pcBoxJ2T6.Location == new Point(725, 658 - (51 * 10)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 9)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 8)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 7)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 6)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 5)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 4)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 3)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 2)) && pcBoxJ2T6.Location == new Point(725, 658 - (51)) && pcBoxJ2T6.Location == new Point(725, 658)) || (pcBoxJ3T6.Location == new Point(703, 671 - (51 * 10)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 9)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 8)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 7)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 6)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 5)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 4)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 3)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 2)) && pcBoxJ3T6.Location == new Point(703, 671 - (51)) && pcBoxJ3T6.Location == new Point(703, 671)) || (pcBoxJ4T6.Location == new Point(723, 671 - (51 * 10)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 9)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 8)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 7)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 6)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 5)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 4)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 3)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 2)) && pcBoxJ4T6.Location == new Point(723, 671 - (51)) && pcBoxJ4T6.Location == new Point(723, 671))) || (pcBoxJ1T7.Location == new Point(771, (710 - 561) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 510) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 459) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 408) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 357) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 306) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 255) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 204) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 153) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 102) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 51) - 51) && pcBoxJ1T7.Location == new Point(771, 710 - 51) && pcBoxJ1T7.Location == new Point(771, 710) || (pcBoxJ2T7.Location == new Point(791, 710 - (51 * 12)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 11)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 10)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 9)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 8)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 7)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 6)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 5)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 4)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 3)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 2)) && pcBoxJ2T7.Location == new Point(791, 710 - (51)) && pcBoxJ2T7.Location == new Point(791, 710)) || (pcBoxJ3T7.Location == new Point(770, 723 - (51 * 12)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 11)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 10)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 9)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 8)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 7)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 6)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 5)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 4)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 3)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 2)) && pcBoxJ3T7.Location == new Point(770, 723 - (51)) && pcBoxJ3T7.Location == new Point(770, 723) || (pcBoxJ4T7.Location == new Point(787, 723 - (51 * 12)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 11)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 10)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 9)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 8)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 7)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 6)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 5)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 4)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 3)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 2)) && pcBoxJ4T7.Location == new Point(787, 723 - (51)) && pcBoxJ4T7.Location == new Point(787, 723)) || (pcBoxJ1T8.Location == new Point(837, (658 - 459) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 408) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 357) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 306) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 255) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 204) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 153) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 102) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 51) - 51) && pcBoxJ1T8.Location == new Point(837, 658 - 51) && pcBoxJ1T8.Location == new Point(837, 658) || (pcBoxJ2T8.Location == new Point(857, 658 - (51 * 10)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 9)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 8)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 7)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 6)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 5)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 4)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 3)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 2)) && pcBoxJ2T8.Location == new Point(857, 658 - (51)) && pcBoxJ2T8.Location == new Point(857, 658)) || (pcBoxJ3T8.Location == new Point(836, 671 - (51 * 10)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 9)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 8)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 7)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 6)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 5)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 4)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 3)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 2)) && pcBoxJ3T8.Location == new Point(836, 671 - (51)) && pcBoxJ3T8.Location == new Point(836, 671)) || (pcBoxJ4T8.Location == new Point(856, 671 - (51 * 10)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 9)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 8)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 7)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 6)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 5)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 4)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 3)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 2)) && pcBoxJ4T8.Location == new Point(856, 671 - (51)) && pcBoxJ4T8.Location == new Point(856, 671))) || (pcBoxJ1T9.Location == new Point(900, (608 - 357) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 306) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 255) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 204) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 153) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 102) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 51) - 51) && pcBoxJ1T9.Location == new Point(900, 608 - 51) && pcBoxJ1T9.Location == new Point(900, 608) || (pcBoxJ2T9.Location == new Point(920, 608 - (51 * 8)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 7)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 6)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 5)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 4)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 3)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 2)) && pcBoxJ2T9.Location == new Point(920, 608 - (51)) && pcBoxJ2T9.Location == new Point(920, 608)) || (pcBoxJ3T9.Location == new Point(897, 618 - (51 * 8)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 7)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 6)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 5)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 4)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 3)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 2)) && pcBoxJ3T9.Location == new Point(897, 618 - (51)) && pcBoxJ3T9.Location == new Point(897, 618)) || (pcBoxJ4T9.Location == new Point(917, 618 - (51 * 8)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 7)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 6)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 5)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 4)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 3)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 2)) && pcBoxJ4T9.Location == new Point(917, 618 - (51)) && pcBoxJ4T9.Location == new Point(917, 618))) || (pcBoxJ1T11.Location == new Point(1031, (504 - 153) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 102) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 51) - 51) && pcBoxJ1T11.Location == new Point(1031, 504 - 51) && pcBoxJ1T11.Location == new Point(1031, 504) || (pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 4)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 3)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 2)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51)) && pcBoxJ2T11.Location == new Point(1051, 504)) || (pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 4)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 3)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 2)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51)) && pcBoxJ3T11.Location == new Point(1036, 518)) || (pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 4)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 3)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 2)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51)) && pcBoxJ4T11.Location == new Point(1056, 518))) || (pcBoxJ1T12.Location == new Point(1097, (455 - 51) - 51) && pcBoxJ1T12.Location == new Point(1097, 455 - 51) && pcBoxJ1T12.Location == new Point(1097, 455) || (pcBoxJ2T12.Location == new Point(1117, 455 - (51 * 2)) && pcBoxJ2T12.Location == new Point(1117, 455 - (51)) && pcBoxJ2T12.Location == new Point(1117, 455)) || (pcBoxJ3T12.Location == new Point(1097, 470 - (51 * 2)) && pcBoxJ3T12.Location == new Point(1097, 470 - (51)) && pcBoxJ3T12.Location == new Point(1097, 470)) || (pcBoxJ4T12.Location == new Point(1117, 470 - (51 * 2)) && pcBoxJ4T12.Location == new Point(1117, 470 - (51)) && pcBoxJ4T12.Location == new Point(1117, 470))))))))
                        //    //{
                        //    //if (pcBoxJ1T10.Location == new Point(967, (559 - 255) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 204) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 153) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 102) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 51) - 51) && pcBoxJ1T10.Location == new Point(967, 559 - 51) && pcBoxJ1T10.Location == new Point(967, 559) || (pcBoxJ2T10.Location == new Point(987, 559 - (51 * 6))&& pcBoxJ2T10.Location == new Point(987, 559 - (51 * 5))&& pcBoxJ2T10.Location == new Point(987, 559 - (51 * 4))&& pcBoxJ2T10.Location == new Point(987, 559 - (51 * 3))&& pcBoxJ2T10.Location == new Point(987, 559 - (51 * 2))&&pcBoxJ2T10.Location == new Point(987, 559 - (51))&&pcBoxJ2T10.Location == new Point(987, 559)) || (pcBoxJ3T10.Location == new Point(966, 572 - (51 * 6))&&pcBoxJ3T10.Location == new Point(966, 572 - (51 * 5))&& pcBoxJ3T10.Location == new Point(966, 572 - (51 * 4))&& pcBoxJ3T10.Location == new Point(966, 572 - (51 * 3))&&pcBoxJ3T10.Location == new Point(966, 572 - (51 * 2))&&pcBoxJ3T10.Location == new Point(966, 572 - (51))&& pcBoxJ3T10.Location == new Point(966, 572)) || (pcBoxJ4T10.Location == new Point(986, 572 - (51 * 6))&& pcBoxJ4T10.Location == new Point(986, 572 - (51 * 5))&& pcBoxJ4T10.Location == new Point(986, 572 - (51 * 4))&& pcBoxJ4T10.Location == new Point(986, 572 - (51 * 3))&& pcBoxJ4T10.Location == new Point(986, 572 - (51 * 2))&& pcBoxJ4T10.Location == new Point(986, 572 - (51))&& pcBoxJ4T10.Location == new Point(986, 572)))
                        //    //{
                        //    if (dado.Dado1 + dado.Dado3 == 10 || dado.Dado2 + dado.Dado4 == 10)
                        //    {
                        //        string ordem = "1324";
                        //        int R1 = dado.Dado1 + dado.Dado3;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado1 + dado.Dado4 == 10 || dado.Dado2 + dado.Dado3 == 10)
                        //    {
                        //        string ordem = "1423";
                        //        int R1 = dado.Dado1 + dado.Dado4;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado1 + dado.Dado2 == 10 || dado.Dado3 + dado.Dado4 == 10)
                        //    {
                        //        string ordem = "1234";
                        //        int R1 = dado.Dado1 + dado.Dado2;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado2 + dado.Dado3 == 10 || dado.Dado1 + dado.Dado4 == 10)
                        //    {
                        //        string ordem = "2314";
                        //        int R1 = dado.Dado2 + dado.Dado3;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado2 + dado.Dado4 == 10 || dado.Dado1 + dado.Dado3 == 10)
                        //    {
                        //        string ordem = "2413";
                        //        int R1 = dado.Dado2 + dado.Dado4;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado3 + dado.Dado4 == 10 || dado.Dado1 + dado.Dado2 == 10)
                        //    {
                        //        string ordem = "3412";
                        //        int R1 = dado.Dado3 + dado.Dado4;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //}


                       

                        //if (dado.Dado1 + dado.Dado4 == 10 || dado.Dado2 + dado.Dado3 == 10)
                        //{

                        //    string ordem = "1423";
                        //    int R1 = dado.Dado1 + dado.Dado4;
                        //    int R2 = dado.Dado2 + dado.Dado3;
                        //    string v1 = R1.ToString();
                        //    string v2 = R2.ToString();
                        //    if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //    if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //    string linha3 = v1 + v2;
                        //    string result = Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //    if (result.Substring(0, 4) == "ERRO")
                        //    {
                        //        Jogo.Mover(IdJogador, senhajogador, "2413", linha3);
                        //    }
                        //    Jogo.Parar(IdJogador, senhajogador);
                        //    goto Fim;
                        //}

                        //if (dado.Dado1 + dado.Dado2 == 10 || dado.Dado3 + dado.Dado4 == 10)
                        //{

                        //    string ordem = "1234";
                        //    int R1 = dado.Dado1 + dado.Dado2;
                        //    int R2 = dado.Dado3 + dado.Dado4;
                        //    string v1 = R1.ToString();
                        //    string v2 = R2.ToString();
                        //    if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //    if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //    string linha3 = v1 + v2;
                        //    string result = Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //    if (result.Substring(0, 4) == "ERRO")
                        //    {
                        //        Jogo.Mover(IdJogador, senhajogador, "2413", linha3);
                        //    }
                        //    Jogo.Parar(IdJogador, senhajogador);
                        //    //goto Fim;
                        //}

                        //trilha 11
                        //if ((pcBoxJ1T2.Location == new Point(446, 455) && pcBoxJ1T2.Location == new Point(446, 455 - 51) && pcBoxJ1T2.Location == new Point(446, (455 - 51) - 51) || (pcBoxJ2T2.Location == new Point(461, 455 - (51 * 2)) && pcBoxJ2T2.Location == new Point(461, 455 - 51) && pcBoxJ2T2.Location == new Point(461, 455)) || (pcBoxJ3T2.Location == new Point(446, 471 - (51 * 2)) && pcBoxJ3T2.Location == new Point(446, 471 - (51)) && pcBoxJ3T2.Location == new Point(446, 471)) || (pcBoxJ4T2.Location == new Point(466, 471 - (51 * 2)) && pcBoxJ4T2.Location == new Point(466, 471 - (51)) && pcBoxJ4T2.Location == new Point(466, 471)) || (pcBoxJ1T3.Location == new Point(507, (504 - 153) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 102) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 51) - 51) && pcBoxJ1T3.Location == new Point(507, 504 - 51) && pcBoxJ1T3.Location == new Point(507, 504)) || (pcBoxJ2T3.Location == new Point(527, 504 - (51 * 4)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 3)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 2)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 1)) && pcBoxJ2T3.Location == new Point(527, 504)) || (pcBoxJ3T3.Location == new Point(506, 521 - (51 * 4)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 3)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 2)) && pcBoxJ3T3.Location == new Point(506, 521 - (51)) && pcBoxJ3T3.Location == new Point(506, 521)) || (pcBoxJ4T3.Location == new Point(526, 521 - (51 * 4)) && pcBoxJ4T3.Location == new Point(526, 521 - (51 * 3)) && pcBoxJ4T3.Location == new Point(526, 521 - (51 * 2)) && pcBoxJ4T3.Location == new Point(526, 521 - (51)) && pcBoxJ4T3.Location == new Point(526, 521)) || (pcBoxJ1T4.Location == new Point(574, (559 - 255) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 204) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 153) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 102) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 51) - 51) && pcBoxJ1T4.Location == new Point(574, 559 - 51) && pcBoxJ1T4.Location == new Point(574, 559) || (pcBoxJ2T4.Location == new Point(594, 559 - (51 * 6)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 5)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 4)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 3)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 2)) && pcBoxJ2T4.Location == new Point(594, 559 - 51) && pcBoxJ2T4.Location == new Point(594, 559)) || (pcBoxJ3T4.Location == new Point(574, 570 - (51 * 6)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 5)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 4)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 3)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 2)) && pcBoxJ3T4.Location == new Point(574, 570 - (51)) && pcBoxJ3T4.Location == new Point(574, 570)) || (pcBoxJ4T4.Location == new Point(594, 570 - (51 * 6)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 5)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 4)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 3)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 2)) && pcBoxJ4T4.Location == new Point(594, 570 - (51)) && pcBoxJ4T4.Location == new Point(594, 570)) || (pcBoxJ1T5.Location == new Point(639, (608 - 357) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 306) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 255) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 204) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 153) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 102) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 51) - 51) && pcBoxJ1T5.Location == new Point(639, 608 - 51) && pcBoxJ1T5.Location == new Point(639, 608) || (pcBoxJ2T5.Location == new Point(659, 608 - (51 * 8)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 7)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 6)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 5)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 4)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 3)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 2)) && pcBoxJ2T5.Location == new Point(659, 608 - (51)) && pcBoxJ2T5.Location == new Point(659, 608)) || (pcBoxJ3T5.Location == new Point(639, 620 - (51 * 8)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 7)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 6)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 5)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 4)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 3)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 2)) && pcBoxJ3T5.Location == new Point(639, 620 - (51)) && pcBoxJ3T5.Location == new Point(639, 620)) || (pcBoxJ4T5.Location == new Point(659, 620 - (51 * 8)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 7)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 6)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 5)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 4)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 3)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 2)) && pcBoxJ4T5.Location == new Point(659, 620 - (51)) && pcBoxJ4T5.Location == new Point(659, 620)) || (pcBoxJ1T6.Location == new Point(705, (658 - 459) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 408) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 357) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 306) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 255) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 204) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 153) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 102) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 51) - 51) && pcBoxJ1T6.Location == new Point(705, 658 - 51) && pcBoxJ1T6.Location == new Point(705, 658) || (pcBoxJ2T6.Location == new Point(725, 658 - (51 * 10)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 9)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 8)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 7)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 6)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 5)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 4)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 3)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 2)) && pcBoxJ2T6.Location == new Point(725, 658 - (51)) && pcBoxJ2T6.Location == new Point(725, 658)) || (pcBoxJ3T6.Location == new Point(703, 671 - (51 * 10)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 9)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 8)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 7)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 6)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 5)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 4)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 3)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 2)) && pcBoxJ3T6.Location == new Point(703, 671 - (51)) && pcBoxJ3T6.Location == new Point(703, 671)) || (pcBoxJ4T6.Location == new Point(723, 671 - (51 * 10)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 9)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 8)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 7)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 6)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 5)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 4)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 3)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 2)) && pcBoxJ4T6.Location == new Point(723, 671 - (51)) && pcBoxJ4T6.Location == new Point(723, 671)) || (pcBoxJ1T7.Location == new Point(771, (710 - 561) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 510) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 459) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 408) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 357) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 306) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 255) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 204) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 153) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 102) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 51) - 51) && pcBoxJ1T7.Location == new Point(771, 710 - 51) && pcBoxJ1T7.Location == new Point(771, 710) || (pcBoxJ2T7.Location == new Point(791, 710 - (51 * 12)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 11)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 10)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 9)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 8)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 7)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 6)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 5)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 4)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 3)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 2)) && pcBoxJ2T7.Location == new Point(791, 710 - (51)) && pcBoxJ2T7.Location == new Point(791, 710)) || (pcBoxJ3T7.Location == new Point(770, 723 - (51 * 12)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 11)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 10)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 9)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 8)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 7)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 6)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 5)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 4)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 3)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 2)) && pcBoxJ3T7.Location == new Point(770, 723 - (51)) && pcBoxJ3T7.Location == new Point(770, 723) || (pcBoxJ4T7.Location == new Point(787, 723 - (51 * 12)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 11)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 10)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 9)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 8)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 7)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 6)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 5)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 4)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 3)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 2)) && pcBoxJ4T7.Location == new Point(787, 723 - (51)) && pcBoxJ4T7.Location == new Point(787, 723)) || (pcBoxJ1T8.Location == new Point(837, (658 - 459) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 408) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 357) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 306) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 255) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 204) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 153) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 102) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 51) - 51) && pcBoxJ1T8.Location == new Point(837, 658 - 51) && pcBoxJ1T8.Location == new Point(837, 658) || (pcBoxJ2T8.Location == new Point(857, 658 - (51 * 10)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 9)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 8)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 7)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 6)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 5)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 4)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 3)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 2)) && pcBoxJ2T8.Location == new Point(857, 658 - (51)) && pcBoxJ2T8.Location == new Point(857, 658)) || (pcBoxJ3T8.Location == new Point(836, 671 - (51 * 10)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 9)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 8)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 7)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 6)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 5)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 4)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 3)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 2)) && pcBoxJ3T8.Location == new Point(836, 671 - (51)) && pcBoxJ3T8.Location == new Point(836, 671)) || (pcBoxJ4T8.Location == new Point(856, 671 - (51 * 10)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 9)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 8)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 7)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 6)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 5)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 4)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 3)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 2)) && pcBoxJ4T8.Location == new Point(856, 671 - (51)) && pcBoxJ4T8.Location == new Point(856, 671)) || (pcBoxJ1T9.Location == new Point(900, (608 - 357) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 306) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 255) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 204) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 153) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 102) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 51) - 51) && pcBoxJ1T9.Location == new Point(900, 608 - 51) && pcBoxJ1T9.Location == new Point(900, 608) || (pcBoxJ2T9.Location == new Point(920, 608 - (51 * 8)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 7)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 6)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 5)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 4)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 3)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 2)) && pcBoxJ2T9.Location == new Point(920, 608 - (51)) && pcBoxJ2T9.Location == new Point(920, 608)) || (pcBoxJ3T9.Location == new Point(897, 618 - (51 * 8)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 7)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 6)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 5)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 4)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 3)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 2)) && pcBoxJ3T9.Location == new Point(897, 618 - (51)) && pcBoxJ3T9.Location == new Point(897, 618)) || (pcBoxJ4T9.Location == new Point(917, 618 - (51 * 8)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 7)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 6)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 5)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 4)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 3)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 2)) && pcBoxJ4T9.Location == new Point(917, 618 - (51)) && pcBoxJ4T9.Location == new Point(917, 618)) || (pcBoxJ1T10.Location == new Point(967, (559 - 255) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 204) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 153) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 102) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 51) - 51) && pcBoxJ1T10.Location == new Point(967, 559 - 51) && pcBoxJ1T10.Location == new Point(967, 559) || (pcBoxJ2T10.Location == new Point(987, 559 - (51 * 6)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 5)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 4)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 3)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 2)) && pcBoxJ2T10.Location == new Point(987, 559 - (51)) && pcBoxJ2T10.Location == new Point(987, 559)) || (pcBoxJ3T10.Location == new Point(966, 572 - (51 * 6)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 5)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 4)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 3)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 2)) && pcBoxJ3T10.Location == new Point(966, 572 - (51)) && pcBoxJ3T10.Location == new Point(966, 572)) || (pcBoxJ4T10.Location == new Point(986, 572 - (51 * 6)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 5)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 4)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 3)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 2)) && pcBoxJ4T10.Location == new Point(986, 572 - (51)) && pcBoxJ4T10.Location == new Point(986, 572)) || (pcBoxJ1T12.Location == new Point(1097, (455 - 51) - 51) && pcBoxJ1T12.Location == new Point(1097, 455 - 51) && pcBoxJ1T12.Location == new Point(1097, 455)) || (pcBoxJ2T12.Location == new Point(1117, 455 - (51 * 2)) && pcBoxJ2T12.Location == new Point(1117, 455 - (51)) && pcBoxJ2T12.Location == new Point(1117, 455)) || (pcBoxJ3T12.Location == new Point(1097, 470 - (51 * 2)) && pcBoxJ3T12.Location == new Point(1097, 470 - (51)) && pcBoxJ3T12.Location == new Point(1097, 470)) || (pcBoxJ4T12.Location == new Point(1117, 470 - (51 * 2)) && pcBoxJ4T12.Location == new Point(1117, 470 - (51)) && pcBoxJ4T12.Location == new Point(1117, 470))))))))))))
                        //{

                        //    //if ((pcBoxJ1T2.Location == new Point(446, 455) && pcBoxJ1T2.Location == new Point(446, 455 - 51) && pcBoxJ1T2.Location == new Point(446, (455 - 51) - 51) || (pcBoxJ2T2.Location == new Point(461, 455 - (51 * 2)) && pcBoxJ2T2.Location == new Point(461, 455 - 51) && pcBoxJ2T2.Location == new Point(461, 455)) || (pcBoxJ3T2.Location == new Point(446, 471 - (51 * 2)) && pcBoxJ3T2.Location == new Point(446, 471 - (51)) && pcBoxJ3T2.Location == new Point(446, 471)) || (pcBoxJ4T2.Location == new Point(466, 471 - (51 * 2)) && pcBoxJ4T2.Location == new Point(466, 471 - (51)) && pcBoxJ4T2.Location == new Point(466, 471))) || (pcBoxJ1T3.Location == new Point(507, (504 - 153) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 102) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 51) - 51) && pcBoxJ1T3.Location == new Point(507, 504 - 51) && pcBoxJ1T3.Location == new Point(507, 504) || (pcBoxJ2T3.Location == new Point(527, 504 - (51 * 4)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 3)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 2)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 1)) && pcBoxJ2T3.Location == new Point(527, 504)) || (pcBoxJ3T3.Location == new Point(506, 521 - (51 * 4)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 3)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 2)) && pcBoxJ3T3.Location == new Point(506, 521 - (51)) && pcBoxJ3T3.Location == new Point(506, 521)) || (pcBoxJ1T4.Location == new Point(574, (559 - 255) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 204) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 153) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 102) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 51) - 51) && pcBoxJ1T4.Location == new Point(574, 559 - 51) && pcBoxJ1T4.Location == new Point(574, 559) || (pcBoxJ2T4.Location == new Point(594, 559 - (51 * 6)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 5)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 4)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 3)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 2)) && pcBoxJ2T4.Location == new Point(594, 559 - 51) && pcBoxJ2T4.Location == new Point(594, 559)) || (pcBoxJ3T4.Location == new Point(574, 570 - (51 * 6)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 5)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 4)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 3)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 2)) && pcBoxJ3T4.Location == new Point(574, 570 - (51)) && pcBoxJ3T4.Location == new Point(574, 570)) || (pcBoxJ4T4.Location == new Point(594, 570 - (51 * 6)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 5)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 4)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 3)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 2)) && pcBoxJ4T4.Location == new Point(594, 570 - (51)) && pcBoxJ4T4.Location == new Point(594, 570))) || (pcBoxJ1T5.Location == new Point(639, (608 - 357) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 306) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 255) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 204) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 153) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 102) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 51) - 51) && pcBoxJ1T5.Location == new Point(639, 608 - 51) && pcBoxJ1T5.Location == new Point(639, 608) || (pcBoxJ2T5.Location == new Point(659, 608 - (51 * 8)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 7)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 6)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 5)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 4)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 3)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 2)) && pcBoxJ2T5.Location == new Point(659, 608 - (51)) && pcBoxJ2T5.Location == new Point(659, 608)) || (pcBoxJ3T5.Location == new Point(639, 620 - (51 * 8)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 7)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 6)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 5)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 4)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 3)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 2)) && pcBoxJ3T5.Location == new Point(639, 620 - (51)) && pcBoxJ3T5.Location == new Point(639, 620)) || (pcBoxJ4T5.Location == new Point(659, 620 - (51 * 8)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 7)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 6)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 5)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 4)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 3)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 2)) && pcBoxJ4T5.Location == new Point(659, 620 - (51)) && pcBoxJ4T5.Location == new Point(659, 620)) || (pcBoxJ1T6.Location == new Point(705, (658 - 459) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 408) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 357) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 306) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 255) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 204) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 153) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 102) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 51) - 51) && pcBoxJ1T6.Location == new Point(705, 658 - 51) && pcBoxJ1T6.Location == new Point(705, 658) || (pcBoxJ2T6.Location == new Point(725, 658 - (51 * 10)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 9)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 8)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 7)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 6)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 5)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 4)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 3)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 2)) && pcBoxJ2T6.Location == new Point(725, 658 - (51)) && pcBoxJ2T6.Location == new Point(725, 658)) || (pcBoxJ3T6.Location == new Point(703, 671 - (51 * 10)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 9)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 8)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 7)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 6)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 5)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 4)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 3)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 2)) && pcBoxJ3T6.Location == new Point(703, 671 - (51)) && pcBoxJ3T6.Location == new Point(703, 671)) || (pcBoxJ4T6.Location == new Point(723, 671 - (51 * 10)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 9)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 8)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 7)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 6)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 5)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 4)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 3)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 2)) && pcBoxJ4T6.Location == new Point(723, 671 - (51)) && pcBoxJ4T6.Location == new Point(723, 671))) || (pcBoxJ1T7.Location == new Point(771, (710 - 561) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 510) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 459) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 408) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 357) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 306) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 255) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 204) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 153) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 102) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 51) - 51) && pcBoxJ1T7.Location == new Point(771, 710 - 51) && pcBoxJ1T7.Location == new Point(771, 710) || (pcBoxJ2T7.Location == new Point(791, 710 - (51 * 12)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 11)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 10)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 9)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 8)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 7)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 6)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 5)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 4)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 3)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 2)) && pcBoxJ2T7.Location == new Point(791, 710 - (51)) && pcBoxJ2T7.Location == new Point(791, 710)) || (pcBoxJ3T7.Location == new Point(770, 723 - (51 * 12)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 11)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 10)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 9)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 8)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 7)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 6)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 5)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 4)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 3)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 2)) && pcBoxJ3T7.Location == new Point(770, 723 - (51)) && pcBoxJ3T7.Location == new Point(770, 723) || (pcBoxJ4T7.Location == new Point(787, 723 - (51 * 12)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 11)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 10)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 9)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 8)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 7)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 6)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 5)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 4)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 3)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 2)) && pcBoxJ4T7.Location == new Point(787, 723 - (51)) && pcBoxJ4T7.Location == new Point(787, 723)) || (pcBoxJ1T8.Location == new Point(837, (658 - 459) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 408) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 357) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 306) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 255) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 204) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 153) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 102) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 51) - 51) && pcBoxJ1T8.Location == new Point(837, 658 - 51) && pcBoxJ1T8.Location == new Point(837, 658) || (pcBoxJ2T8.Location == new Point(857, 658 - (51 * 10)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 9)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 8)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 7)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 6)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 5)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 4)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 3)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 2)) && pcBoxJ2T8.Location == new Point(857, 658 - (51)) && pcBoxJ2T8.Location == new Point(857, 658)) || (pcBoxJ3T8.Location == new Point(836, 671 - (51 * 10)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 9)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 8)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 7)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 6)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 5)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 4)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 3)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 2)) && pcBoxJ3T8.Location == new Point(836, 671 - (51)) && pcBoxJ3T8.Location == new Point(836, 671)) || (pcBoxJ4T8.Location == new Point(856, 671 - (51 * 10)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 9)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 8)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 7)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 6)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 5)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 4)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 3)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 2)) && pcBoxJ4T8.Location == new Point(856, 671 - (51)) && pcBoxJ4T8.Location == new Point(856, 671))) || (pcBoxJ1T9.Location == new Point(900, (608 - 357) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 306) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 255) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 204) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 153) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 102) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 51) - 51) && pcBoxJ1T9.Location == new Point(900, 608 - 51) && pcBoxJ1T9.Location == new Point(900, 608) || (pcBoxJ2T9.Location == new Point(920, 608 - (51 * 8)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 7)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 6)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 5)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 4)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 3)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 2)) && pcBoxJ2T9.Location == new Point(920, 608 - (51)) && pcBoxJ2T9.Location == new Point(920, 608)) || (pcBoxJ3T9.Location == new Point(897, 618 - (51 * 8)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 7)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 6)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 5)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 4)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 3)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 2)) && pcBoxJ3T9.Location == new Point(897, 618 - (51)) && pcBoxJ3T9.Location == new Point(897, 618)) || (pcBoxJ4T9.Location == new Point(917, 618 - (51 * 8)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 7)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 6)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 5)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 4)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 3)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 2)) && pcBoxJ4T9.Location == new Point(917, 618 - (51)) && pcBoxJ4T9.Location == new Point(917, 618))) || (pcBoxJ1T10.Location == new Point(967, (559 - 255) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 204) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 153) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 102) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 51) - 51) && pcBoxJ1T10.Location == new Point(967, 559 - 51) && pcBoxJ1T10.Location == new Point(967, 559) || (pcBoxJ2T10.Location == new Point(987, 559 - (51 * 6)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 5)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 4)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 3)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 2)) && pcBoxJ2T10.Location == new Point(987, 559 - (51)) && pcBoxJ2T10.Location == new Point(987, 559)) || (pcBoxJ3T10.Location == new Point(966, 572 - (51 * 6)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 5)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 4)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 3)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 2)) && pcBoxJ3T10.Location == new Point(966, 572 - (51)) && pcBoxJ3T10.Location == new Point(966, 572)) || (pcBoxJ4T10.Location == new Point(986, 572 - (51 * 6)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 5)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 4)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 3)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 2)) && pcBoxJ4T10.Location == new Point(986, 572 - (51)) && pcBoxJ4T10.Location == new Point(986, 572))) || (pcBoxJ1T12.Location == new Point(1097, (455 - 51) - 51) && pcBoxJ1T12.Location == new Point(1097, 455 - 51) && pcBoxJ1T12.Location == new Point(1097, 455) || (pcBoxJ2T12.Location == new Point(1117, 455 - (51 * 2)) && pcBoxJ2T12.Location == new Point(1117, 455 - (51)) && pcBoxJ2T12.Location == new Point(1117, 455)) || (pcBoxJ3T12.Location == new Point(1097, 470 - (51 * 2)) && pcBoxJ3T12.Location == new Point(1097, 470 - (51)) && pcBoxJ3T12.Location == new Point(1097, 470)) || (pcBoxJ4T12.Location == new Point(1117, 470 - (51 * 2)) && pcBoxJ4T12.Location == new Point(1117, 470 - (51)) && pcBoxJ4T12.Location == new Point(1117, 470))))))))
                        //    //{

                        //    //if (pcBoxJ1T11.Location == new Point(1031, (504 - 153) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 102) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 51) - 51) && pcBoxJ1T11.Location == new Point(1031, 504 - 51) && pcBoxJ1T11.Location == new Point(1031, 504) || (pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 4))&&pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 3))&& pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 2))&& pcBoxJ2T11.Location == new Point(1051, 504 - (51))&&pcBoxJ2T11.Location == new Point(1051, 504))|| (pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 4))&& pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 3))&& pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 2))&& pcBoxJ3T11.Location == new Point(1036, 518 - (51))&& pcBoxJ3T11.Location == new Point(1036, 518)) || (pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 4))&& pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 3))&& pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 2))&& pcBoxJ4T11.Location == new Point(1056, 518 - (51))&& pcBoxJ4T11.Location == new Point(1056, 518)))
                        //    //{
                        //    if (dado.Dado1 + dado.Dado3 == 11 || dado.Dado2 + dado.Dado4 == 11)
                        //    {
                        //        string ordem = "1324";
                        //        int R1 = dado.Dado1 + dado.Dado3;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado1 + dado.Dado4 == 11 || dado.Dado2 + dado.Dado3 == 11)
                        //    {
                        //        string ordem = "1423";
                        //        int R1 = dado.Dado1 + dado.Dado4;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado1 + dado.Dado2 == 11 || dado.Dado3 + dado.Dado4 == 11)
                        //    {
                        //        string ordem = "1234";
                        //        int R1 = dado.Dado1 + dado.Dado2;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado2 + dado.Dado3 == 11 || dado.Dado1 + dado.Dado4 == 11)
                        //    {
                        //        string ordem = "2314";
                        //        int R1 = dado.Dado2 + dado.Dado3;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado2 + dado.Dado4 == 11 || dado.Dado1 + dado.Dado3 == 11)
                        //    {
                        //        string ordem = "2413";
                        //        int R1 = dado.Dado2 + dado.Dado4;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado3 + dado.Dado4 == 11 || dado.Dado1 + dado.Dado2 == 11)
                        //    {
                        //        string ordem = "3412";
                        //        int R1 = dado.Dado3 + dado.Dado4;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //}



                        //if (dado.Dado1 + dado.Dado4 == 11 || dado.Dado2 + dado.Dado3 == 11)
                        //{

                        //    string ordem = "1423";
                        //    int R1 = dado.Dado1 + dado.Dado4;
                        //    int R2 = dado.Dado2 + dado.Dado3;
                        //    string v1 = R1.ToString();
                        //    string v2 = R2.ToString();
                        //    if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //    if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //    string linha3 = v1 + v2;
                        //    string result = Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //    if (result.Substring(0, 4) == "ERRO")
                        //    {
                        //        Jogo.Mover(IdJogador, senhajogador, "2413", linha3);
                        //    }
                        //    Jogo.Parar(IdJogador, senhajogador);
                        //    goto Fim;
                        //}

                        //if (dado.Dado1 + dado.Dado2 == 11 || dado.Dado3 + dado.Dado4 == 11)
                        //{

                        //    string ordem = "1234";
                        //    int R1 = dado.Dado1 + dado.Dado2;
                        //    int R2 = dado.Dado3 + dado.Dado4;
                        //    string v1 = R1.ToString();
                        //    string v2 = R2.ToString();
                        //    if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //    if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //    string linha3 = v1 + v2;
                        //    string result = Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //    if (result.Substring(0, 4) == "ERRO")
                        //    {
                        //        Jogo.Mover(IdJogador, senhajogador, "2413", linha3);
                        //    }
                        //    Jogo.Parar(IdJogador, senhajogador);
                        //    goto Fim;
                        //}

                        //trilha 12

                        //if ((pcBoxJ1T2.Location == new Point(446, 455) && pcBoxJ1T2.Location == new Point(446, 455 - 51) && pcBoxJ1T2.Location == new Point(446, (455 - 51) - 51) || (pcBoxJ2T2.Location == new Point(461, 455 - (51 * 2)) && pcBoxJ2T2.Location == new Point(461, 455 - 51) && pcBoxJ2T2.Location == new Point(461, 455)) || (pcBoxJ3T2.Location == new Point(446, 471 - (51 * 2)) && pcBoxJ3T2.Location == new Point(446, 471 - (51)) && pcBoxJ3T2.Location == new Point(446, 471)) || (pcBoxJ4T2.Location == new Point(466, 471 - (51 * 2)) && pcBoxJ4T2.Location == new Point(466, 471 - (51)) && pcBoxJ4T2.Location == new Point(466, 471)) || (pcBoxJ1T3.Location == new Point(507, (504 - 153) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 102) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 51) - 51) && pcBoxJ1T3.Location == new Point(507, 504 - 51) && pcBoxJ1T3.Location == new Point(507, 504)) || (pcBoxJ2T3.Location == new Point(527, 504 - (51 * 4)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 3)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 2)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 1)) && pcBoxJ2T3.Location == new Point(527, 504)) || (pcBoxJ3T3.Location == new Point(506, 521 - (51 * 4)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 3)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 2)) && pcBoxJ3T3.Location == new Point(506, 521 - (51)) && pcBoxJ3T3.Location == new Point(506, 521)) || (pcBoxJ4T3.Location == new Point(526, 521 - (51 * 4)) && pcBoxJ4T3.Location == new Point(526, 521 - (51 * 3)) && pcBoxJ4T3.Location == new Point(526, 521 - (51 * 2)) && pcBoxJ4T3.Location == new Point(526, 521 - (51)) && pcBoxJ4T3.Location == new Point(526, 521)) || (pcBoxJ1T4.Location == new Point(574, (559 - 255) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 204) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 153) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 102) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 51) - 51) && pcBoxJ1T4.Location == new Point(574, 559 - 51) && pcBoxJ1T4.Location == new Point(574, 559) || (pcBoxJ2T4.Location == new Point(594, 559 - (51 * 6)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 5)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 4)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 3)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 2)) && pcBoxJ2T4.Location == new Point(594, 559 - 51) && pcBoxJ2T4.Location == new Point(594, 559)) || (pcBoxJ3T4.Location == new Point(574, 570 - (51 * 6)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 5)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 4)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 3)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 2)) && pcBoxJ3T4.Location == new Point(574, 570 - (51)) && pcBoxJ3T4.Location == new Point(574, 570)) || (pcBoxJ4T4.Location == new Point(594, 570 - (51 * 6)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 5)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 4)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 3)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 2)) && pcBoxJ4T4.Location == new Point(594, 570 - (51)) && pcBoxJ4T4.Location == new Point(594, 570)) || (pcBoxJ1T5.Location == new Point(639, (608 - 357) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 306) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 255) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 204) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 153) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 102) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 51) - 51) && pcBoxJ1T5.Location == new Point(639, 608 - 51) && pcBoxJ1T5.Location == new Point(639, 608) || (pcBoxJ2T5.Location == new Point(659, 608 - (51 * 8)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 7)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 6)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 5)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 4)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 3)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 2)) && pcBoxJ2T5.Location == new Point(659, 608 - (51)) && pcBoxJ2T5.Location == new Point(659, 608)) || (pcBoxJ3T5.Location == new Point(639, 620 - (51 * 8)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 7)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 6)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 5)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 4)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 3)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 2)) && pcBoxJ3T5.Location == new Point(639, 620 - (51)) && pcBoxJ3T5.Location == new Point(639, 620)) || (pcBoxJ4T5.Location == new Point(659, 620 - (51 * 8)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 7)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 6)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 5)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 4)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 3)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 2)) && pcBoxJ4T5.Location == new Point(659, 620 - (51)) && pcBoxJ4T5.Location == new Point(659, 620)) || (pcBoxJ1T6.Location == new Point(705, (658 - 459) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 408) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 357) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 306) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 255) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 204) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 153) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 102) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 51) - 51) && pcBoxJ1T6.Location == new Point(705, 658 - 51) && pcBoxJ1T6.Location == new Point(705, 658) || (pcBoxJ2T6.Location == new Point(725, 658 - (51 * 10)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 9)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 8)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 7)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 6)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 5)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 4)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 3)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 2)) && pcBoxJ2T6.Location == new Point(725, 658 - (51)) && pcBoxJ2T6.Location == new Point(725, 658)) || (pcBoxJ3T6.Location == new Point(703, 671 - (51 * 10)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 9)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 8)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 7)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 6)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 5)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 4)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 3)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 2)) && pcBoxJ3T6.Location == new Point(703, 671 - (51)) && pcBoxJ3T6.Location == new Point(703, 671)) || (pcBoxJ4T6.Location == new Point(723, 671 - (51 * 10)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 9)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 8)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 7)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 6)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 5)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 4)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 3)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 2)) && pcBoxJ4T6.Location == new Point(723, 671 - (51)) && pcBoxJ4T6.Location == new Point(723, 671)) || (pcBoxJ1T7.Location == new Point(771, (710 - 561) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 510) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 459) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 408) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 357) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 306) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 255) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 204) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 153) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 102) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 51) - 51) && pcBoxJ1T7.Location == new Point(771, 710 - 51) && pcBoxJ1T7.Location == new Point(771, 710) || (pcBoxJ2T7.Location == new Point(791, 710 - (51 * 12)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 11)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 10)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 9)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 8)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 7)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 6)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 5)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 4)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 3)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 2)) && pcBoxJ2T7.Location == new Point(791, 710 - (51)) && pcBoxJ2T7.Location == new Point(791, 710)) || (pcBoxJ3T7.Location == new Point(770, 723 - (51 * 12)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 11)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 10)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 9)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 8)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 7)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 6)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 5)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 4)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 3)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 2)) && pcBoxJ3T7.Location == new Point(770, 723 - (51)) && pcBoxJ3T7.Location == new Point(770, 723) || (pcBoxJ4T7.Location == new Point(787, 723 - (51 * 12)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 11)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 10)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 9)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 8)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 7)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 6)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 5)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 4)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 3)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 2)) && pcBoxJ4T7.Location == new Point(787, 723 - (51)) && pcBoxJ4T7.Location == new Point(787, 723)) || (pcBoxJ1T8.Location == new Point(837, (658 - 459) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 408) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 357) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 306) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 255) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 204) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 153) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 102) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 51) - 51) && pcBoxJ1T8.Location == new Point(837, 658 - 51) && pcBoxJ1T8.Location == new Point(837, 658) || (pcBoxJ2T8.Location == new Point(857, 658 - (51 * 10)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 9)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 8)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 7)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 6)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 5)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 4)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 3)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 2)) && pcBoxJ2T8.Location == new Point(857, 658 - (51)) && pcBoxJ2T8.Location == new Point(857, 658)) || (pcBoxJ3T8.Location == new Point(836, 671 - (51 * 10)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 9)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 8)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 7)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 6)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 5)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 4)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 3)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 2)) && pcBoxJ3T8.Location == new Point(836, 671 - (51)) && pcBoxJ3T8.Location == new Point(836, 671)) || (pcBoxJ4T8.Location == new Point(856, 671 - (51 * 10)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 9)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 8)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 7)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 6)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 5)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 4)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 3)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 2)) && pcBoxJ4T8.Location == new Point(856, 671 - (51)) && pcBoxJ4T8.Location == new Point(856, 671)) || (pcBoxJ1T9.Location == new Point(900, (608 - 357) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 306) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 255) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 204) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 153) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 102) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 51) - 51) && pcBoxJ1T9.Location == new Point(900, 608 - 51) && pcBoxJ1T9.Location == new Point(900, 608) || (pcBoxJ2T9.Location == new Point(920, 608 - (51 * 8)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 7)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 6)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 5)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 4)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 3)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 2)) && pcBoxJ2T9.Location == new Point(920, 608 - (51)) && pcBoxJ2T9.Location == new Point(920, 608)) || (pcBoxJ3T9.Location == new Point(897, 618 - (51 * 8)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 7)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 6)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 5)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 4)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 3)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 2)) && pcBoxJ3T9.Location == new Point(897, 618 - (51)) && pcBoxJ3T9.Location == new Point(897, 618)) || (pcBoxJ4T9.Location == new Point(917, 618 - (51 * 8)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 7)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 6)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 5)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 4)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 3)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 2)) && pcBoxJ4T9.Location == new Point(917, 618 - (51)) && pcBoxJ4T9.Location == new Point(917, 618)) || (pcBoxJ1T10.Location == new Point(967, (559 - 255) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 204) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 153) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 102) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 51) - 51) && pcBoxJ1T10.Location == new Point(967, 559 - 51) && pcBoxJ1T10.Location == new Point(967, 559) || (pcBoxJ2T10.Location == new Point(987, 559 - (51 * 6)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 5)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 4)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 3)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 2)) && pcBoxJ2T10.Location == new Point(987, 559 - (51)) && pcBoxJ2T10.Location == new Point(987, 559)) || (pcBoxJ3T10.Location == new Point(966, 572 - (51 * 6)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 5)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 4)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 3)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 2)) && pcBoxJ3T10.Location == new Point(966, 572 - (51)) && pcBoxJ3T10.Location == new Point(966, 572)) || (pcBoxJ4T10.Location == new Point(986, 572 - (51 * 6)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 5)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 4)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 3)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 2)) && pcBoxJ4T10.Location == new Point(986, 572 - (51)) && pcBoxJ4T10.Location == new Point(986, 572)) || (pcBoxJ1T11.Location == new Point(1031, (504 - 153) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 102) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 51) - 51) && pcBoxJ1T11.Location == new Point(1031, 504 - 51) && pcBoxJ1T11.Location == new Point(1031, 504) || (pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 4)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 3)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 2)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51)) && pcBoxJ2T11.Location == new Point(1051, 504)) || (pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 4)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 3)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 2)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51)) && pcBoxJ3T11.Location == new Point(1036, 518)) || (pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 4)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 3)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 2)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51)) && pcBoxJ4T11.Location == new Point(1056, 518)))))))))))))
                        //{

                        //    //if ((pcBoxJ1T2.Location == new Point(446, 455) && pcBoxJ1T2.Location == new Point(446, 455 - 51) && pcBoxJ1T2.Location == new Point(446, (455 - 51) - 51) || (pcBoxJ2T2.Location == new Point(461, 455 - (51 * 2)) && pcBoxJ2T2.Location == new Point(461, 455 - 51) && pcBoxJ2T2.Location == new Point(461, 455)) || (pcBoxJ3T2.Location == new Point(446, 471 - (51 * 2)) && pcBoxJ3T2.Location == new Point(446, 471 - (51)) && pcBoxJ3T2.Location == new Point(446, 471)) || (pcBoxJ4T2.Location == new Point(466, 471 - (51 * 2)) && pcBoxJ4T2.Location == new Point(466, 471 - (51)) && pcBoxJ4T2.Location == new Point(466, 471))) || (pcBoxJ1T3.Location == new Point(507, (504 - 153) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 102) - 51) && pcBoxJ1T3.Location == new Point(507, (504 - 51) - 51) && pcBoxJ1T3.Location == new Point(507, 504 - 51) && pcBoxJ1T3.Location == new Point(507, 504) || (pcBoxJ2T3.Location == new Point(527, 504 - (51 * 4)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 3)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 2)) && pcBoxJ2T3.Location == new Point(527, 504 - (51 * 1)) && pcBoxJ2T3.Location == new Point(527, 504)) || (pcBoxJ3T3.Location == new Point(506, 521 - (51 * 4)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 3)) && pcBoxJ3T3.Location == new Point(506, 521 - (51 * 2)) && pcBoxJ3T3.Location == new Point(506, 521 - (51)) && pcBoxJ3T3.Location == new Point(506, 521)) || (pcBoxJ1T4.Location == new Point(574, (559 - 255) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 204) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 153) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 102) - 51) && pcBoxJ1T4.Location == new Point(574, (559 - 51) - 51) && pcBoxJ1T4.Location == new Point(574, 559 - 51) && pcBoxJ1T4.Location == new Point(574, 559) || (pcBoxJ2T4.Location == new Point(594, 559 - (51 * 6)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 5)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 4)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 3)) && pcBoxJ2T4.Location == new Point(594, 559 - (51 * 2)) && pcBoxJ2T4.Location == new Point(594, 559 - 51) && pcBoxJ2T4.Location == new Point(594, 559)) || (pcBoxJ3T4.Location == new Point(574, 570 - (51 * 6)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 5)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 4)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 3)) && pcBoxJ3T4.Location == new Point(574, 570 - (51 * 2)) && pcBoxJ3T4.Location == new Point(574, 570 - (51)) && pcBoxJ3T4.Location == new Point(574, 570)) || (pcBoxJ4T4.Location == new Point(594, 570 - (51 * 6)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 5)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 4)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 3)) && pcBoxJ4T4.Location == new Point(594, 570 - (51 * 2)) && pcBoxJ4T4.Location == new Point(594, 570 - (51)) && pcBoxJ4T4.Location == new Point(594, 570))) || (pcBoxJ1T5.Location == new Point(639, (608 - 357) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 306) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 255) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 204) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 153) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 102) - 51) && pcBoxJ1T5.Location == new Point(639, (608 - 51) - 51) && pcBoxJ1T5.Location == new Point(639, 608 - 51) && pcBoxJ1T5.Location == new Point(639, 608) || (pcBoxJ2T5.Location == new Point(659, 608 - (51 * 8)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 7)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 6)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 5)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 4)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 3)) && pcBoxJ2T5.Location == new Point(659, 608 - (51 * 2)) && pcBoxJ2T5.Location == new Point(659, 608 - (51)) && pcBoxJ2T5.Location == new Point(659, 608)) || (pcBoxJ3T5.Location == new Point(639, 620 - (51 * 8)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 7)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 6)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 5)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 4)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 3)) && pcBoxJ3T5.Location == new Point(639, 620 - (51 * 2)) && pcBoxJ3T5.Location == new Point(639, 620 - (51)) && pcBoxJ3T5.Location == new Point(639, 620)) || (pcBoxJ4T5.Location == new Point(659, 620 - (51 * 8)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 7)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 6)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 5)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 4)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 3)) && pcBoxJ4T5.Location == new Point(659, 620 - (51 * 2)) && pcBoxJ4T5.Location == new Point(659, 620 - (51)) && pcBoxJ4T5.Location == new Point(659, 620)) || (pcBoxJ1T6.Location == new Point(705, (658 - 459) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 408) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 357) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 306) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 255) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 204) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 153) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 102) - 51) && pcBoxJ1T6.Location == new Point(705, (658 - 51) - 51) && pcBoxJ1T6.Location == new Point(705, 658 - 51) && pcBoxJ1T6.Location == new Point(705, 658) || (pcBoxJ2T6.Location == new Point(725, 658 - (51 * 10)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 9)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 8)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 7)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 6)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 5)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 4)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 3)) && pcBoxJ2T6.Location == new Point(725, 658 - (51 * 2)) && pcBoxJ2T6.Location == new Point(725, 658 - (51)) && pcBoxJ2T6.Location == new Point(725, 658)) || (pcBoxJ3T6.Location == new Point(703, 671 - (51 * 10)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 9)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 8)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 7)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 6)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 5)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 4)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 3)) && pcBoxJ3T6.Location == new Point(703, 671 - (51 * 2)) && pcBoxJ3T6.Location == new Point(703, 671 - (51)) && pcBoxJ3T6.Location == new Point(703, 671)) || (pcBoxJ4T6.Location == new Point(723, 671 - (51 * 10)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 9)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 8)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 7)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 6)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 5)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 4)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 3)) && pcBoxJ4T6.Location == new Point(723, 671 - (51 * 2)) && pcBoxJ4T6.Location == new Point(723, 671 - (51)) && pcBoxJ4T6.Location == new Point(723, 671))) || (pcBoxJ1T7.Location == new Point(771, (710 - 561) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 510) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 459) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 408) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 357) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 306) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 255) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 204) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 153) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 102) - 51) && pcBoxJ1T7.Location == new Point(771, (710 - 51) - 51) && pcBoxJ1T7.Location == new Point(771, 710 - 51) && pcBoxJ1T7.Location == new Point(771, 710) || (pcBoxJ2T7.Location == new Point(791, 710 - (51 * 12)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 11)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 10)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 9)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 8)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 7)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 6)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 5)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 4)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 3)) && pcBoxJ2T7.Location == new Point(791, 710 - (51 * 2)) && pcBoxJ2T7.Location == new Point(791, 710 - (51)) && pcBoxJ2T7.Location == new Point(791, 710)) || (pcBoxJ3T7.Location == new Point(770, 723 - (51 * 12)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 11)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 10)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 9)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 8)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 7)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 6)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 5)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 4)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 3)) && pcBoxJ3T7.Location == new Point(770, 723 - (51 * 2)) && pcBoxJ3T7.Location == new Point(770, 723 - (51)) && pcBoxJ3T7.Location == new Point(770, 723) || (pcBoxJ4T7.Location == new Point(787, 723 - (51 * 12)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 11)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 10)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 9)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 8)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 7)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 6)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 5)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 4)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 3)) && pcBoxJ4T7.Location == new Point(787, 723 - (51 * 2)) && pcBoxJ4T7.Location == new Point(787, 723 - (51)) && pcBoxJ4T7.Location == new Point(787, 723)) || (pcBoxJ1T8.Location == new Point(837, (658 - 459) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 408) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 357) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 306) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 255) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 204) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 153) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 102) - 51) && pcBoxJ1T8.Location == new Point(837, (658 - 51) - 51) && pcBoxJ1T8.Location == new Point(837, 658 - 51) && pcBoxJ1T8.Location == new Point(837, 658) || (pcBoxJ2T8.Location == new Point(857, 658 - (51 * 10)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 9)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 8)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 7)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 6)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 5)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 4)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 3)) && pcBoxJ2T8.Location == new Point(857, 658 - (51 * 2)) && pcBoxJ2T8.Location == new Point(857, 658 - (51)) && pcBoxJ2T8.Location == new Point(857, 658)) || (pcBoxJ3T8.Location == new Point(836, 671 - (51 * 10)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 9)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 8)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 7)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 6)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 5)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 4)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 3)) && pcBoxJ3T8.Location == new Point(836, 671 - (51 * 2)) && pcBoxJ3T8.Location == new Point(836, 671 - (51)) && pcBoxJ3T8.Location == new Point(836, 671)) || (pcBoxJ4T8.Location == new Point(856, 671 - (51 * 10)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 9)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 8)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 7)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 6)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 5)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 4)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 3)) && pcBoxJ4T8.Location == new Point(856, 671 - (51 * 2)) && pcBoxJ4T8.Location == new Point(856, 671 - (51)) && pcBoxJ4T8.Location == new Point(856, 671))) || (pcBoxJ1T9.Location == new Point(900, (608 - 357) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 306) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 255) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 204) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 153) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 102) - 51) && pcBoxJ1T9.Location == new Point(900, (608 - 51) - 51) && pcBoxJ1T9.Location == new Point(900, 608 - 51) && pcBoxJ1T9.Location == new Point(900, 608) || (pcBoxJ2T9.Location == new Point(920, 608 - (51 * 8)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 7)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 6)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 5)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 4)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 3)) && pcBoxJ2T9.Location == new Point(920, 608 - (51 * 2)) && pcBoxJ2T9.Location == new Point(920, 608 - (51)) && pcBoxJ2T9.Location == new Point(920, 608)) || (pcBoxJ3T9.Location == new Point(897, 618 - (51 * 8)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 7)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 6)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 5)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 4)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 3)) && pcBoxJ3T9.Location == new Point(897, 618 - (51 * 2)) && pcBoxJ3T9.Location == new Point(897, 618 - (51)) && pcBoxJ3T9.Location == new Point(897, 618)) || (pcBoxJ4T9.Location == new Point(917, 618 - (51 * 8)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 7)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 6)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 5)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 4)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 3)) && pcBoxJ4T9.Location == new Point(917, 618 - (51 * 2)) && pcBoxJ4T9.Location == new Point(917, 618 - (51)) && pcBoxJ4T9.Location == new Point(917, 618))) || (pcBoxJ1T10.Location == new Point(967, (559 - 255) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 204) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 153) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 102) - 51) && pcBoxJ1T10.Location == new Point(967, (559 - 51) - 51) && pcBoxJ1T10.Location == new Point(967, 559 - 51) && pcBoxJ1T10.Location == new Point(967, 559) || (pcBoxJ2T10.Location == new Point(987, 559 - (51 * 6)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 5)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 4)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 3)) && pcBoxJ2T10.Location == new Point(987, 559 - (51 * 2)) && pcBoxJ2T10.Location == new Point(987, 559 - (51)) && pcBoxJ2T10.Location == new Point(987, 559)) || (pcBoxJ3T10.Location == new Point(966, 572 - (51 * 6)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 5)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 4)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 3)) && pcBoxJ3T10.Location == new Point(966, 572 - (51 * 2)) && pcBoxJ3T10.Location == new Point(966, 572 - (51)) && pcBoxJ3T10.Location == new Point(966, 572)) || (pcBoxJ4T10.Location == new Point(986, 572 - (51 * 6)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 5)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 4)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 3)) && pcBoxJ4T10.Location == new Point(986, 572 - (51 * 2)) && pcBoxJ4T10.Location == new Point(986, 572 - (51)) && pcBoxJ4T10.Location == new Point(986, 572))) || (pcBoxJ1T11.Location == new Point(1031, (504 - 153) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 102) - 51) && pcBoxJ1T11.Location == new Point(1031, (504 - 51) - 51) && pcBoxJ1T11.Location == new Point(1031, 504 - 51) && pcBoxJ1T11.Location == new Point(1031, 504) || (pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 4)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 3)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51 * 2)) && pcBoxJ2T11.Location == new Point(1051, 504 - (51)) && pcBoxJ2T11.Location == new Point(1051, 504)) || (pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 4)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 3)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51 * 2)) && pcBoxJ3T11.Location == new Point(1036, 518 - (51)) && pcBoxJ3T11.Location == new Point(1036, 518)) || (pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 4)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 3)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51 * 2)) && pcBoxJ4T11.Location == new Point(1056, 518 - (51)) && pcBoxJ4T11.Location == new Point(1056, 518))))))))
                        //    //{
                        //    //if (pcBoxJ1T12.Location == new Point(1097, (455 - 51) - 51) && pcBoxJ1T12.Location == new Point(1097, 455 - 51) && pcBoxJ1T12.Location == new Point(1097, 455) || (pcBoxJ2T12.Location == new Point(1117, 455 - (51 * 2))&& pcBoxJ2T12.Location == new Point(1117, 455 - (51))&& pcBoxJ2T12.Location == new Point(1117, 455)) || (pcBoxJ3T12.Location == new Point(1097, 470 - (51 * 2))&& pcBoxJ3T12.Location == new Point(1097, 470 - (51))&& pcBoxJ3T12.Location == new Point(1097, 470)) || (pcBoxJ4T12.Location == new Point(1117, 470 - (51 * 2))&& pcBoxJ4T12.Location == new Point(1117, 470 - (51))&& pcBoxJ4T12.Location == new Point(1117, 470)))
                        //    //{
                        //    if (dado.Dado1 + dado.Dado3 == 12 || dado.Dado2 + dado.Dado4 == 12)
                        //    {
                        //        string ordem = "1324";
                        //        int R1 = dado.Dado1 + dado.Dado3;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado1 + dado.Dado4 == 12 || dado.Dado2 + dado.Dado3 == 12)
                        //    {
                        //        string ordem = "1423";
                        //        int R1 = dado.Dado1 + dado.Dado4;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado1 + dado.Dado2 == 12 || dado.Dado3 + dado.Dado4 == 12)
                        //    {
                        //        string ordem = "1234";
                        //        int R1 = dado.Dado1 + dado.Dado2;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado2 + dado.Dado3 == 12 || dado.Dado1 + dado.Dado4 == 12)
                        //    {
                        //        string ordem = "2314";
                        //        int R1 = dado.Dado2 + dado.Dado3;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado2 + dado.Dado4 == 12 || dado.Dado1 + dado.Dado3 == 12)
                        //    {
                        //        string ordem = "2413";
                        //        int R1 = dado.Dado2 + dado.Dado4;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //    if (dado.Dado3 + dado.Dado4 == 12 || dado.Dado1 + dado.Dado2 == 12)
                        //    {
                        //        string ordem = "3412";
                        //        int R1 = dado.Dado3 + dado.Dado4;
                        //        int R2 = 0;
                        //        string v1 = R1.ToString();
                        //        string v2 = R2.ToString();
                        //        if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //        if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //        string linha3 = v1 + v2;
                        //        Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //        Jogo.Parar(IdJogador, senhajogador);
                        //        goto Fim;
                        //    }
                        //}

                       
                        //if (dado.Dado1 + dado.Dado4 == 12 || dado.Dado2 + dado.Dado3 == 12)
                        //{

                        //    string ordem = "1423";
                        //    int R1 = dado.Dado1 + dado.Dado4;
                        //    int R2 = dado.Dado2 + dado.Dado3;
                        //    string v1 = R1.ToString();
                        //    string v2 = R2.ToString();
                        //    if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //    if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //    string linha3 = v1 + v2;
                        //    string result = Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //    if (result.Substring(0, 4) == "ERRO")
                        //    {
                        //        Jogo.Mover(IdJogador, senhajogador, "2413", linha3);
                        //    }
                        //    Jogo.Parar(IdJogador, senhajogador);
                        //    goto Fim;
                        //}

                        //if (dado.Dado1 + dado.Dado2 == 12 || dado.Dado3 + dado.Dado4 == 12)
                        //{

                        //    string ordem = "1234";
                        //    int R1 = dado.Dado1 + dado.Dado2;
                        //    int R2 = dado.Dado3 + dado.Dado4;
                        //    string v1 = R1.ToString();
                        //    string v2 = R2.ToString();
                        //    if (R1 == 10) v1 = "A"; if (R1 == 11) v1 = "B"; if (R1 == 12) v1 = "C";
                        //    if (R2 == 10) v2 = "A"; if (R2 == 11) v2 = "B"; if (R2 == 12) v2 = "C";
                        //    string linha3 = v1 + v2;
                        //    string result = Jogo.Mover(IdJogador, senhajogador, ordem, linha3);
                        //    if (result.Substring(0, 4) == "ERRO")
                        //    {
                        //        Jogo.Mover(IdJogador, senhajogador, "2413", linha3);
                        //    }
                        //    Jogo.Parar(IdJogador, senhajogador);
                        //    goto Fim;
                        //}

                    Fim:
                        label7.Text = "Foi";
                    }

                    //}




                    /* if (textBox6.Text != Dados)
                     {
                         textBox8.Text = "Jogador " + textBox5.Text + "Cor " + textBox7.Text;
                         return;
                     }
                     else
                     {
                         lblERRO.Text = "É a vez do outro jogador";
                         return;
                     }
                     */
                }
            }
        }
        

        private void listarPartidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Jogador jog1 = new Jogador();
            string retorno = Jogo.ListarPartidas("T");
            retorno = retorno.Replace("\r", "");
            string[] linha = retorno.Split('\n');

            for (int i = 0; i < linha.Length; i++)
            {
                listBox1.Items.Add(linha[i]);             
            }

        }       

        private void listarJogadoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            listBox2.Items.Clear();
            Jogador jog1 = new Jogador();

            string linha = listBox1.SelectedItem.ToString();
            string[] itens = linha.Split(',');
            jog1.IdJogador = Convert.ToInt32(itens[0]);

            string retorno = Jogo.ListarJogadores(jog1.IdJogador);

            retorno = retorno.Replace("\r", "");
            string[] linha2 = retorno.Split('\n');
            for (int i = 0; i < linha2.Length; i++)
            {
                listBox2.Items.Add(linha2[i]);

            }


            ExibirHistorico(jog1.IdJogador);



        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size = new Size(808, 481);
        }

        private void maximizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MaximumSize = this.Size;
        }

        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.MinimumSize = this.Size;
        }

        public void parametro(int id)
        {
            Jogador jog = new Jogador();
            jog.IdJogador = id;
        }

        private void criarPartidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Jogador jog1 = new Jogador();
            jog1.Nome = textBox5.Text;
            jog1.Senha = textBox4.Text;

            List<Partida> partida = new List<Partida>();
            for (int i = 0; i < 2; i++)
            {
                Partida p = new Partida();
                int[] items = new int[1];
                p.idPartida = Convert.ToInt32(items[0]);
                partida.Add(p);
            }


            if (jog1.Nome == Jogo.ListarJogadores(idPartida))
            {
                lblERRO.Text = "Jogador já existe";
            }

            string criar = Jogo.CriarPartida(jog1.Nome, jog1.Senha);

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.ShowDialog();
        }

        private void entrarEmUmaPartidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                lblERRO.Text = "Bem-Vindo ao Can't Stop!";
            }
            Jogador jog1 = new Jogador();

            jog1.Nome = textBox5.Text;
            jog1.Senha = textBox4.Text;

            string linha = listBox1.SelectedItem.ToString();
            string[] itens = linha.Split(',');
            jog1.IdJogador = Convert.ToInt32(itens[0]);

            string entrar = Jogo.EntrarPartida(jog1.IdJogador, jog1.Nome, jog1.Senha);

            ExibirHistorico(jog1.IdJogador);


            if (entrar.Substring(0, 4) == "ERRO")
            {

                lblERRO.Text = entrar;

            }
            else
            {
                entrar = entrar.Replace("\r", "");
                string[] intens2 = entrar.Split('\n');
                intens2 = entrar.Split(',');
                string senhajogador = intens2[1];
                string idjogador = intens2[0];
                string corjogador = intens2[2];

                textBox6.Text = idjogador;
                textBox1.Text = senhajogador;
                textBox7.Text = corjogador;

               

            }

        }


        private void versãoDLLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblDLL.Text = Jogo.Versao;

        }

        private void iniciarPartidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Jogador jog1 = new Jogador();
            jog1.IdJogador = Convert.ToInt32(textBox6.Text);
            string senhajogador = textBox1.Text;

            string iniciar = Jogo.IniciarPartida(jog1.IdJogador, senhajogador);

            timer1.Enabled = true;

            ExibirHistorico(jog1.IdJogador);

        }

        
        public void exibirTabuleiro(int Idpartida)
        {
            textBox9.Clear();
            Jogador jog1 = new Jogador();
            Tabuleiro tab = new Tabuleiro();
            string linha = listBox1.SelectedItem.ToString();
            string[] itens = linha.Split(',');
            Idpartida = Convert.ToInt32(itens[0]);

            string exibir = Jogo.ExibirTabuleiro(Idpartida);
            textBox9.Text = exibir;

            int j = 0;

            exibir = exibir.Replace("\r", "");
            string[] linha4 = exibir.Split('\n');
            string lista = textBox6.Text;
            string[] jogadorId = lista.Split(',');

            


            while (linha4[j] != "")
            {
                string linhas = linha4[j];
                string[] dados = linhas.Split(',');


                Tabuleiro statustabu = new Tabuleiro();
                statustabu.Trilha = Convert.ToInt32(dados[0]);
                statustabu.Posicao = Convert.ToInt32(dados[1]);
                statustabu.idJogador = Convert.ToInt32(dados[2]);
                statustabu.Tipo = dados[3];


                if (statustabu.idJogador == Convert.ToInt32(jogadorId[0]))
                {

                    if (statustabu.Trilha == 2)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ1T2.Visible = true;
                                pcBoxJ1T2.BackColor = Color.Red;
                                pcBoxJ1T2.Location = new Point(446, 455);

                            }
                            else
                            {
                                pcBoxJ1T2.Visible = true;
                                pcBoxJ1T2.BackColor = Color.Black;
                                pcBoxJ1T2.Location = new Point(446, 455);
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ1T2.Visible = true;
                                pcBoxJ1T2.BackColor = Color.Red;
                                pcBoxJ1T2.Location = new Point(446, 455 - 51);

                            }
                            else
                            {
                                pcBoxJ1T2.Visible = true;
                                pcBoxJ1T2.BackColor = Color.Black;
                                pcBoxJ1T2.Location = new Point(446, 455 - 51);
                            }
                        }

                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {

                                pcBoxJ1T2.Visible = true;
                                pcBoxJ1T2.BackColor = Color.Red;
                                pcBoxJ1T2.Location = new Point(446, (455 - 51) - 51);
                                pcBoxJ1T2.Visible = true;
                                pcBoxJ1T2.BackColor = Color.Red;
                                pcBoxJ1T2.Location = new Point(446, 455 - 51);
                                pcBoxJ1T2.Visible = true;
                                pcBoxJ1T2.BackColor = Color.Red;
                                pcBoxJ1T2.Location = new Point(446, 455);

                            }
                            else
                            {


                                pcBoxJ1T2.Visible = true;
                                pcBoxJ1T2.BackColor = Color.Black;
                                pcBoxJ1T2.Location = new Point(446, (455 - 51) - 51);
                                pcBoxJ1T2.Visible = true;
                                pcBoxJ1T2.BackColor = Color.Black;
                                pcBoxJ1T2.Location = new Point(446, 455 - 51);
                                pcBoxJ1T2.Visible = true;
                                pcBoxJ1T2.BackColor = Color.Black;
                                pcBoxJ1T2.Location = new Point(446, 455);
                            }
                        }
                    }
                    else if (statustabu.Trilha == 3)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
               

                                pcBoxJ1T3.Visible = true;
                                pcBoxJ1T3.BackColor = Color.Red;
                                pcBoxJ1T3.Location = new Point(507, 504);

                            }
                            else
                            {
                                

                                pcBoxJ1T3.Visible = true;
                                pcBoxJ1T3.BackColor = Color.Black;
                                pcBoxJ1T3.Location = new Point(507, 504);
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                              

                                pcBoxJ1T3.Visible = true;
                                pcBoxJ1T3.BackColor = Color.Red;
                                pcBoxJ1T3.Location = new Point(507, 504 - 51);

                            }
                            else
                            {
                             

                                pcBoxJ1T3.Visible = true;
                                pcBoxJ1T3.BackColor = Color.Black;
                                pcBoxJ1T3.Location = new Point(507, 504 - 51);
                            }
                        }
                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                

                                pcBoxJ1T3.Visible = true;
                                pcBoxJ1T3.BackColor = Color.Red;
                                pcBoxJ1T3.Location = new Point(507, (504 - 51) - 51);

                            }
                            else
                            {
                            

                                pcBoxJ1T3.Visible = true;
                                pcBoxJ1T3.BackColor = Color.Black;
                                pcBoxJ1T3.Location = new Point(507, (504 - 51) - 51);
                            }

                        }
                        else if (statustabu.Posicao == 4)
                        {
                            if (statustabu.Tipo == "B")
                            {
                             

                                pcBoxJ1T3.Visible = true;
                                pcBoxJ1T3.BackColor = Color.Red;
                                pcBoxJ1T3.Location = new Point(507, (504 - 102) - 51);

                            }
                            else
                            {
               

                                pcBoxJ1T3.Visible = true;
                                pcBoxJ1T3.BackColor = Color.Black;
                                pcBoxJ1T3.Location = new Point(507, (504 - 102) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 5)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                

                                pcBoxJ1T3.Visible = true;
                                pcBoxJ1T3.BackColor = Color.Red;
                                pcBoxJ1T3.Location = new Point(507, (504 - 153) - 51);
                                pcBoxJ1T3.Visible = true;
                                pcBoxJ1T3.BackColor = Color.Red;
                                pcBoxJ1T3.Location = new Point(507, (504 - 102) - 51);
                                pcBoxJ1T3.Visible = true;
                                pcBoxJ1T3.BackColor = Color.Red;
                                pcBoxJ1T3.Location = new Point(507, (504 - 51) - 51);
                                pcBoxJ1T3.Visible = true;
                                pcBoxJ1T3.BackColor = Color.Red;
                                pcBoxJ1T3.Location = new Point(507, 504 - 51);
                                pcBoxJ1T3.Visible = true;
                                pcBoxJ1T3.BackColor = Color.Red;
                                pcBoxJ1T3.Location = new Point(507, 504);

                            }
                            else
                            {
                              

                                pcBoxJ1T3.Visible = true;
                                pcBoxJ1T3.BackColor = Color.Black;
                                pcBoxJ1T3.Location = new Point(507, (504 - 153) - 51);
                                pcBoxJ1T3.Visible = true;
                                pcBoxJ1T3.BackColor = Color.Black;
                                pcBoxJ1T3.Location = new Point(507, (504 - 102) - 51);
                                pcBoxJ1T3.Visible = true;
                                pcBoxJ1T3.BackColor = Color.Black;
                                pcBoxJ1T3.Location = new Point(507, (504 - 51) - 51);
                                pcBoxJ1T3.Visible = true;
                                pcBoxJ1T3.BackColor = Color.Black;
                                pcBoxJ1T3.Location = new Point(507, 504 - 51);
                                pcBoxJ1T3.Visible = true;
                                pcBoxJ1T3.BackColor = Color.Black;
                                pcBoxJ1T3.Location = new Point(507, 504);
                            }
                        }
                    }

                    else if (statustabu.Trilha == 4)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                  

                                pcBoxJ1T4.Visible = true;
                                pcBoxJ1T4.BackColor = Color.Red;
                                pcBoxJ1T4.Location = new Point(574, 559);

                            }
                            else
                            {
                 

                                pcBoxJ1T4.Visible = true;
                                pcBoxJ1T4.BackColor = Color.Black;
                                pcBoxJ1T4.Location = new Point(574, 559);
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                            

                                pcBoxJ1T4.Visible = true;
                                pcBoxJ1T4.BackColor = Color.Red;
                                pcBoxJ1T4.Location = new Point(574, 559 - 51);

                            }
                            else
                            {
                            
                          

                                pcBoxJ1T4.Visible = true;
                                pcBoxJ1T4.BackColor = Color.Black;
                                pcBoxJ1T4.Location = new Point(574, 559 - 51);
                            }
                        }
                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                
                                

                                pcBoxJ1T4.Visible = true;
                                pcBoxJ1T4.BackColor = Color.Red;
                                pcBoxJ1T4.Location = new Point(574, (559 - 51) - 51);

                            }
                            else
                            {
                           

                                pcBoxJ1T4.Visible = true;
                                pcBoxJ1T4.BackColor = Color.Black;
                                pcBoxJ1T4.Location = new Point(574, (559 - 51) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 4)
                        {
                            if (statustabu.Tipo == "B")
                            {
                             

                                pcBoxJ1T4.Visible = true;
                                pcBoxJ1T4.BackColor = Color.Red;
                                pcBoxJ1T4.Location = new Point(574, (559 - 102) - 51);

                            }
                            else
                            {
                               

                                pcBoxJ1T4.Visible = true;
                                pcBoxJ1T4.BackColor = Color.Black;
                                pcBoxJ1T4.Location = new Point(574, (559 - 102) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 5)
                        {

                            if (statustabu.Tipo == "B")
                            {
                         


                                pcBoxJ1T4.Visible = true;
                                pcBoxJ1T4.BackColor = Color.Red;
                                pcBoxJ1T4.Location = new Point(574, (559 - 153) - 51);

                            }
                            else
                            {
                          

                                pcBoxJ1T4.Visible = true;
                                pcBoxJ1T4.BackColor = Color.Black;
                                pcBoxJ1T4.Location = new Point(574, (559 - 153) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 6)
                        {
                            if (statustabu.Tipo == "B")
                            {

                                pcBoxJ1T4.Visible = true;
                                pcBoxJ1T4.BackColor = Color.Red;
                                pcBoxJ1T4.Location = new Point(574, (559 - 204) - 51);

                            }
                            else
                            {
                               

                                pcBoxJ1T4.Visible = true;
                                pcBoxJ1T4.BackColor = Color.Black;
                                pcBoxJ1T4.Location = new Point(574, (559 - 204) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 7)
                        {
                            if (statustabu.Tipo == "B")
                            {
                        


                                pcBoxJ1T4.Visible = true;
                                pcBoxJ1T4.BackColor = Color.Red;
                                pcBoxJ1T4.Location = new Point(574, (559 - 255) - 51);
                                pcBoxJ1T4.Visible = true;
                                pcBoxJ1T4.BackColor = Color.Red;
                                pcBoxJ1T4.Location = new Point(574, (559 - 204) - 51);
                                pcBoxJ1T4.Visible = true;
                                pcBoxJ1T4.BackColor = Color.Red;
                                pcBoxJ1T4.Location = new Point(574, (559 - 153) - 51);
                                pcBoxJ1T4.Visible = true;
                                pcBoxJ1T4.BackColor = Color.Red;
                                pcBoxJ1T4.Location = new Point(574, (559 - 102) - 51);
                                pcBoxJ1T4.Visible = true;
                                pcBoxJ1T4.BackColor = Color.Red;
                                pcBoxJ1T4.Location = new Point(574, (559 - 51) - 51);
                                pcBoxJ1T4.Visible = true;
                                pcBoxJ1T4.BackColor = Color.Red;
                                pcBoxJ1T4.Location = new Point(574, 559 - 51);
                                pcBoxJ1T4.Visible = true;
                                pcBoxJ1T4.BackColor = Color.Red;
                                pcBoxJ1T4.Location = new Point(574, 559);

                            }
                            else
                            {
                            

                                pcBoxJ1T4.Visible = true;
                                pcBoxJ1T4.BackColor = Color.Black;
                                pcBoxJ1T4.Location = new Point(574, (559 - 255) - 51);
                                pcBoxJ1T4.Visible = true;
                                pcBoxJ1T4.BackColor = Color.Black;
                                pcBoxJ1T4.Location = new Point(574, (559 - 204) - 51);
                                pcBoxJ1T4.Visible = true;
                                pcBoxJ1T4.BackColor = Color.Black;
                                pcBoxJ1T4.Location = new Point(574, (559 - 153) - 51);
                                pcBoxJ1T4.Visible = true;
                                pcBoxJ1T4.BackColor = Color.Black;
                                pcBoxJ1T4.Location = new Point(574, (559 - 102) - 51);
                                pcBoxJ1T4.Visible = true;
                                pcBoxJ1T4.BackColor = Color.Black;
                                pcBoxJ1T4.Location = new Point(574, (559 - 51) - 51);
                                pcBoxJ1T4.Visible = true;
                                pcBoxJ1T4.BackColor = Color.Black;
                                pcBoxJ1T4.Location = new Point(574, 559 - 51);
                                pcBoxJ1T4.Visible = true;
                                pcBoxJ1T4.BackColor = Color.Black;
                                pcBoxJ1T4.Location = new Point(574, 559);
                            }
                        }

                    }

                    else if (statustabu.Trilha == 5)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                

                                pcBoxJ1T5.Visible = true;
                                pcBoxJ1T5.BackColor = Color.Red;
                                pcBoxJ1T5.Location = new Point(639, 608);

                            }
                            else
                            {
                   

                                pcBoxJ1T5.Visible = true;
                                pcBoxJ1T5.BackColor = Color.Black;
                                pcBoxJ1T5.Location = new Point(639, 608);
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                  

                                pcBoxJ1T5.Visible = true;
                                pcBoxJ1T5.BackColor = Color.Red;
                                pcBoxJ1T5.Location = new Point(639, 608 - 51);

                            }
                            else
                            {
                       

                                pcBoxJ1T5.Visible = true;
                                pcBoxJ1T5.BackColor = Color.Black;
                                pcBoxJ1T5.Location = new Point(639, 608 - 51);
                            }
                        }
                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                   


                                pcBoxJ1T5.Visible = true;
                                pcBoxJ1T5.BackColor = Color.Red;
                                pcBoxJ1T5.Location = new Point(639, (608 - 51) - 51);

                            }
                            else
                            {
              
                                pcBoxJ1T5.Visible = true;
                                pcBoxJ1T5.BackColor = Color.Black;
                                pcBoxJ1T5.Location = new Point(639, (608 - 51) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 4)
                        {
                            if (statustabu.Tipo == "B")
                            {
                            


                                pcBoxJ1T5.Visible = true;
                                pcBoxJ1T5.BackColor = Color.Red;
                                pcBoxJ1T5.Location = new Point(639, (608 - 102) - 51);

                            }
                            else
                            {
                            

                                pcBoxJ1T5.Visible = true;
                                pcBoxJ1T5.BackColor = Color.Black;
                                pcBoxJ1T5.Location = new Point(639, (608 - 102) - 51);
                            }

                        }
                        else if (statustabu.Posicao == 5)
                        {
                            if (statustabu.Tipo == "B")
                            {
                    

                                pcBoxJ1T5.Visible = true;
                                pcBoxJ1T5.BackColor = Color.Red;
                                pcBoxJ1T5.Location = new Point(639, (608 - 153) - 51);

                            }
                            else
                            {
                        

                                pcBoxJ1T5.Visible = true;
                                pcBoxJ1T5.BackColor = Color.Black;
                                pcBoxJ1T5.Location = new Point(639, (608 - 153) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 6)
                        {
                            if (statustabu.Tipo == "B")
                            {
                       


                                pcBoxJ1T5.Visible = true;
                                pcBoxJ1T5.BackColor = Color.Red;
                                pcBoxJ1T5.Location = new Point(639, (608 - 204) - 51);

                            }
                            else
                            {
                           
                                pcBoxJ1T5.Visible = true;
                                pcBoxJ1T5.BackColor = Color.Black;
                                pcBoxJ1T5.Location = new Point(639, (608 - 204) - 51);
                            }

                        }
                        else if (statustabu.Posicao == 7)
                        {

                            if (statustabu.Tipo == "B")
                            {

                              
                                pcBoxJ1T5.Visible = true;
                                pcBoxJ1T5.BackColor = Color.Red;
                                pcBoxJ1T5.Location = new Point(639, (608 - 255) - 51);

                            }
                            else
                            {
                          
                                pcBoxJ1T5.Visible = true;
                                pcBoxJ1T5.BackColor = Color.Black;
                                pcBoxJ1T5.Location = new Point(639, (608 - 255) - 51);
                            }

                        }
                        else if (statustabu.Posicao == 8)
                        {
                            if (statustabu.Tipo == "B")
                            {

                               

                                pcBoxJ1T5.Visible = true;
                                pcBoxJ1T5.BackColor = Color.Red;
                                pcBoxJ1T5.Location = new Point(639, (608 - 306) - 51);

                            }
                            else
                            {
                            

                                pcBoxJ1T5.Visible = true;
                                pcBoxJ1T5.BackColor = Color.Black;
                                pcBoxJ1T5.Location = new Point(639, (608 - 306) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 9)
                        {
                            if (statustabu.Tipo == "B")
                            {
                  

                                pcBoxJ1T5.Visible = true;
                                pcBoxJ1T5.BackColor = Color.Red;
                                pcBoxJ1T5.Location = new Point(639, (608 - 357) - 51);
                                pcBoxJ1T5.Visible = true;
                                pcBoxJ1T5.BackColor = Color.Red;
                                pcBoxJ1T5.Location = new Point(639, (608 - 306) - 51);
                                pcBoxJ1T5.Visible = true;
                                pcBoxJ1T5.BackColor = Color.Red;
                                pcBoxJ1T5.Location = new Point(639, (608 - 255) - 51);
                                pcBoxJ1T5.Visible = true;
                                pcBoxJ1T5.BackColor = Color.Red;
                                pcBoxJ1T5.Location = new Point(639, (608 - 204) - 51);
                                pcBoxJ1T5.Visible = true;
                                pcBoxJ1T5.BackColor = Color.Red;
                                pcBoxJ1T5.Location = new Point(639, (608 - 153) - 51);
                                pcBoxJ1T5.Visible = true;
                                pcBoxJ1T5.BackColor = Color.Red;
                                pcBoxJ1T5.Location = new Point(639, (608 - 102) - 51);
                                pcBoxJ1T5.Visible = true;
                                pcBoxJ1T5.BackColor = Color.Red;
                                pcBoxJ1T5.Location = new Point(639, (608 - 51) - 51);
                                pcBoxJ1T5.Visible = true;
                                pcBoxJ1T5.BackColor = Color.Red;
                                pcBoxJ1T5.Location = new Point(639, 608 - 51);
                                pcBoxJ1T5.Visible = true;
                                pcBoxJ1T5.BackColor = Color.Red;
                                pcBoxJ1T5.Location = new Point(639, 608);

                            }
                            else
                            {
                        

                                pcBoxJ1T5.Visible = true;
                                pcBoxJ1T5.BackColor = Color.Black;
                                pcBoxJ1T5.Location = new Point(639, (608 - 357) - 51);
                                pcBoxJ1T5.Visible = true;
                                pcBoxJ1T5.BackColor = Color.Black;
                                pcBoxJ1T5.Location = new Point(639, (608 - 306) - 51);
                                pcBoxJ1T5.Visible = true;
                                pcBoxJ1T5.BackColor = Color.Black;
                                pcBoxJ1T5.Location = new Point(639, (608 - 255) - 51);
                                pcBoxJ1T5.Visible = true;
                                pcBoxJ1T5.BackColor = Color.Black;
                                pcBoxJ1T5.Location = new Point(639, (608 - 204) - 51);
                                pcBoxJ1T5.Visible = true;
                                pcBoxJ1T5.BackColor = Color.Black;
                                pcBoxJ1T5.Location = new Point(639, (608 - 153) - 51);
                                pcBoxJ1T5.Visible = true;
                                pcBoxJ1T5.BackColor = Color.Black;
                                pcBoxJ1T5.Location = new Point(639, (608 - 102) - 51);
                                pcBoxJ1T5.Visible = true;
                                pcBoxJ1T5.BackColor = Color.Black;
                                pcBoxJ1T5.Location = new Point(639, (608 - 51) - 51);
                                pcBoxJ1T5.Visible = true;
                                pcBoxJ1T5.BackColor = Color.Black;
                                pcBoxJ1T5.Location = new Point(639, 608 - 51);
                                pcBoxJ1T5.Visible = true;
                                pcBoxJ1T5.BackColor = Color.Black;
                                pcBoxJ1T5.Location = new Point(639, 608);
                            }

                        }
                    }






                    else if (statustabu.Trilha == 6)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                          

                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Red;
                                pcBoxJ1T6.Location = new Point(705, 658);

                            }
                            else
                            {
                          

                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Black;
                                pcBoxJ1T6.Location = new Point(705, 658);
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {

                    

                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Red;
                                pcBoxJ1T6.Location = new Point(705, 658 - 51);

                            }
                            else
                            {
                      

                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Black;
                                pcBoxJ1T6.Location = new Point(705, 658 - 51);
                            }
                        }
                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                         

                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Red;
                                pcBoxJ1T6.Location = new Point(705, (658 - 51) - 51);

                            }
                            else
                            {
                        

                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Black;
                                pcBoxJ1T6.Location = new Point(705, (658 - 51) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 4)
                        {
                            if (statustabu.Tipo == "B")
                            {
                        

                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Red;
                                pcBoxJ1T6.Location = new Point(705, (658 - 102) - 51);

                            }
                            else
                            {
                    

                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Black;
                                pcBoxJ1T6.Location = new Point(705, (658 - 102) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 5)
                        {
                            if (statustabu.Tipo == "B")
                            {
                               

                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Red;
                                pcBoxJ1T6.Location = new Point(705, (658 - 153) - 51);

                            }
                            else
                            {
                            

                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Black;
                                pcBoxJ1T6.Location = new Point(705, (658 - 153) - 51);
                            }

                        }
                        else if (statustabu.Posicao == 6)
                        {
                            if (statustabu.Tipo == "B")
                            {
                            

                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Red;
                                pcBoxJ1T6.Location = new Point(705, (658 - 204) - 51);

                            }
                            else
                            {
                          

                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Black;
                                pcBoxJ1T6.Location = new Point(705, (658 - 204) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 7)
                        {
                            if (statustabu.Tipo == "B")
                            {
                         

                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Red;
                                pcBoxJ1T6.Location = new Point(705, (658 - 255) - 51);

                            }
                            else
                            {
                           

                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Black;
                                pcBoxJ1T6.Location = new Point(705, (658 - 255) - 51);
                            }

                        }
                        else if (statustabu.Posicao == 8)
                        {
                            if (statustabu.Tipo == "B")
                            {
                        

                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Red;
                                pcBoxJ1T6.Location = new Point(705, (658 - 306) - 51);

                            }
                            else
                            {
                          

                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Black;
                                pcBoxJ1T6.Location = new Point(705, (658 - 306) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 9)
                        {

                            if (statustabu.Tipo == "B")
                            {
                         

                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Red;
                                pcBoxJ1T6.Location = new Point(705, (658 - 357) - 51);

                            }
                            else
                            {
                   

                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Black;
                                pcBoxJ1T6.Location = new Point(705, (658 - 357) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 10)
                        {
                            if (statustabu.Tipo == "B")
                            {
                      

                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Red;
                                pcBoxJ1T6.Location = new Point(705, (658 - 408) - 51);

                            }
                            else
                            {
                           

                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Black;
                                pcBoxJ1T6.Location = new Point(705, (658 - 408) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 11)
                        {
                            if (statustabu.Tipo == "B")
                            {
                          


                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Red;
                                pcBoxJ1T6.Location = new Point(705, (658 - 459) - 51);
                                pcBoxJ1T6.BackColor = Color.Red;
                                pcBoxJ1T6.Location = new Point(705, (658 - 408) - 51);
                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Red;
                                pcBoxJ1T6.Location = new Point(705, (658 - 357) - 51);
                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Red;
                                pcBoxJ1T6.Location = new Point(705, (658 - 306) - 51);
                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Red;
                                pcBoxJ1T6.Location = new Point(705, (658 - 255) - 51);
                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Red;
                                pcBoxJ1T6.Location = new Point(705, (658 - 204) - 51);
                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Red;
                                pcBoxJ1T6.Location = new Point(705, (658 - 153) - 51);
                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Red;
                                pcBoxJ1T6.Location = new Point(705, (658 - 102) - 51);
                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Red;
                                pcBoxJ1T6.Location = new Point(705, (658 - 51) - 51);
                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Red;
                                pcBoxJ1T6.Location = new Point(705, 658 - 51);
                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Red;
                                pcBoxJ1T6.Location = new Point(705, 658);

                            }
                            else
                            {
                           

                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Black;
                                pcBoxJ1T6.Location = new Point(705, (658 - 459) - 51);
                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Black;
                                pcBoxJ1T6.Location = new Point(705, (658 - 408) - 51);
                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Black;
                                pcBoxJ1T6.Location = new Point(705, (658 - 357) - 51);
                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Black;
                                pcBoxJ1T6.Location = new Point(705, (658 - 306) - 51);
                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Black;
                                pcBoxJ1T6.Location = new Point(705, (658 - 255) - 51);
                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Black;
                                pcBoxJ1T6.Location = new Point(705, (658 - 204) - 51);
                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Black;
                                pcBoxJ1T6.Location = new Point(705, (658 - 153) - 51);
                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Black;
                                pcBoxJ1T6.Location = new Point(705, (658 - 102) - 51);
                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Black;
                                pcBoxJ1T6.Location = new Point(705, (658 - 51) - 51);
                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Black;
                                pcBoxJ1T6.Location = new Point(705, 658 - 51);
                                pcBoxJ1T6.Visible = true;
                                pcBoxJ1T6.BackColor = Color.Black;
                                pcBoxJ1T6.Location = new Point(705, 658);
                            }
                        }
                    }
                    else if (statustabu.Trilha == 7)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                        
                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Red;
                                pcBoxJ1T7.Location = new Point(771, 710);

                            }
                            else
                            {
                        

                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Black;
                                pcBoxJ1T7.Location = new Point(771, 710);
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                      
                                
                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Red;
                                pcBoxJ1T7.Location = new Point(771, 710 - 51);

                            }
                            else
                            {
                             

                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Black;
                                pcBoxJ1T7.Location = new Point(771, 710 - 51);
                            }
                        }
                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                           

                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Red;
                                pcBoxJ1T7.Location = new Point(771, (710 - 51) - 51);

                            }
                            else
                            {
                          

                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Black;
                                pcBoxJ1T7.Location = new Point(771, (710 - 51) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 4)
                        {

                            if (statustabu.Tipo == "B")
                            {
                                

                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Red;
                                pcBoxJ1T7.Location = new Point(771, (710 - 102) - 51);

                            }
                            else
                            {
                               

                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Black;
                                pcBoxJ1T7.Location = new Point(771, (710 - 102) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 5)
                        {

                            if (statustabu.Tipo == "B")
                            {
                               

                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Red;
                                pcBoxJ1T7.Location = new Point(771, (710 - 153) - 51);

                            }
                            else
                            {
                            

                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Black;
                                pcBoxJ1T7.Location = new Point(771, (710 - 153) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 6)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                

                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Red;
                                pcBoxJ1T7.Location = new Point(771, (710 - 204) - 51);

                            }
                            else
                            {
                               

                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Black;
                                pcBoxJ1T7.Location = new Point(771, (710 - 204) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 7)
                        {

                            if (statustabu.Tipo == "B")
                            {
                                

                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Red;
                                pcBoxJ1T7.Location = new Point(771, (710 - 255) - 51);

                            }
                            else
                            {
                               

                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Black;
                                pcBoxJ1T7.Location = new Point(771, (710 - 255) - 51);
                            }

                        }
                        else if (statustabu.Posicao == 8)
                        {
                            if (statustabu.Tipo == "B")
                            {
                               

                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Red;
                                pcBoxJ1T7.Location = new Point(771, (710 - 306) - 51);

                            }
                            else
                            {
          

                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Black;
                                pcBoxJ1T7.Location = new Point(771, (710 - 306) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 9)
                        {
                            if (statustabu.Tipo == "B")
                            {
                          

                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Red;
                                pcBoxJ1T7.Location = new Point(771, (710 - 357) - 51);

                            }
                            else
                            {
                            

                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Black;
                                pcBoxJ1T7.Location = new Point(771, (710 - 357) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 10)
                        {
                            if (statustabu.Tipo == "B")
                            {
                            

                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Red;
                                pcBoxJ1T7.Location = new Point(771, (710 - 408) - 51);

                            }
                            else
                            {
                              

                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Black;
                                pcBoxJ1T7.Location = new Point(771, (710 - 408) - 51);
                            }

                        }
                        else if (statustabu.Posicao == 11)
                        {
                            if (statustabu.Tipo == "B")
                            {
              

                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Red;
                                pcBoxJ1T7.Location = new Point(771, (710 - 459) - 51);

                            }
                            else
                            {
                    

                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Black;
                                pcBoxJ1T7.Location = new Point(771, (710 - 459) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 12)
                        {

                            if (statustabu.Tipo == "B")
                            {
                        

                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Red;
                                pcBoxJ1T7.Location = new Point(771, (710 - 510) - 51);

                            }
                            else
                            {
                                

                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Black;
                                pcBoxJ1T7.Location = new Point(771, (710 - 510) - 51);
                            }

                        }
                        else if (statustabu.Posicao == 13)
                        {
                            if (statustabu.Tipo == "B")
                            {
                              

                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Red;
                                pcBoxJ1T7.Location = new Point(771, (710 - 561) - 51);
                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Red;
                                pcBoxJ1T7.Location = new Point(771, (710 - 510) - 51);
                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Red;
                                pcBoxJ1T7.Location = new Point(771, (710 - 459) - 51);
                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Red;
                                pcBoxJ1T7.Location = new Point(771, (710 - 408) - 51);
                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Red;
                                pcBoxJ1T7.Location = new Point(771, (710 - 357) - 51);
                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Red;
                                pcBoxJ1T7.Location = new Point(771, (710 - 306) - 51);
                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Red;
                                pcBoxJ1T7.Location = new Point(771, (710 - 255) - 51);
                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Red;
                                pcBoxJ1T7.Location = new Point(771, (710 - 204) - 51);
                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Red;
                                pcBoxJ1T7.Location = new Point(771, (710 - 153) - 51);
                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Red;
                                pcBoxJ1T7.Location = new Point(771, (710 - 102) - 51);
                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Red;
                                pcBoxJ1T7.Location = new Point(771, (710 - 51) - 51);
                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Red;
                                pcBoxJ1T7.Location = new Point(771, 710 - 51);
                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Red;
                                pcBoxJ1T7.Location = new Point(771, 710);

                            }
                            else
                            {
                            

                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Black;
                                pcBoxJ1T7.Location = new Point(771, (710 - 561) - 51);
                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Black;
                                pcBoxJ1T7.Location = new Point(771, (710 - 510) - 51);
                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Black;
                                pcBoxJ1T7.Location = new Point(771, (710 - 459) - 51);
                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Black;
                                pcBoxJ1T7.Location = new Point(771, (710 - 408) - 51);
                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Black;
                                pcBoxJ1T7.Location = new Point(771, (710 - 357) - 51);
                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Black;
                                pcBoxJ1T7.Location = new Point(771, (710 - 306) - 51);
                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Black;
                                pcBoxJ1T7.Location = new Point(771, (710 - 255) - 51);
                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Black;
                                pcBoxJ1T7.Location = new Point(771, (710 - 204) - 51);
                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Black;
                                pcBoxJ1T7.Location = new Point(771, (710 - 153) - 51);
                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Black;
                                pcBoxJ1T7.Location = new Point(771, (710 - 102) - 51); 
                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Black;
                                pcBoxJ1T7.Location = new Point(771, (710 - 51) - 51);
                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Black;
                                pcBoxJ1T7.Location = new Point(771, 710 - 51);
                                pcBoxJ1T7.Visible = true;
                                pcBoxJ1T7.BackColor = Color.Black;
                                pcBoxJ1T7.Location = new Point(771, 710);
                            }

                        }
                    }
                    else if (statustabu.Trilha == 8)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                    

                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Red;
                                pcBoxJ1T8.Location = new Point(837, 658);

                            }
                            else
                            {
               

                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Black;
                                pcBoxJ1T8.Location = new Point(837, 658);
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {

                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Red;
                                pcBoxJ1T8.Location = new Point(837, 658 - 51);

                            }
                            else
                            {
                             

                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Black;
                                pcBoxJ1T8.Location = new Point(837, 658 - 51);
                            }
                        }
                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                             
                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Red;
                                pcBoxJ1T8.Location = new Point(837, (658 - 51) - 51);

                            }
                            else
                            {
                               
                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Black;
                                pcBoxJ1T8.Location = new Point(837, (658 - 51) - 51);
                            }

                        }
                        else if (statustabu.Posicao == 4)
                        {
                            if (statustabu.Tipo == "B")
                            {
                            

                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Red;
                                pcBoxJ1T8.Location = new Point(837, (658 - 102) - 51);

                            }
                            else
                            {
                             
                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Black;
                                pcBoxJ1T8.Location = new Point(837, (658 - 102) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 5)
                        {
                            if (statustabu.Tipo == "B")
                            {
                             

                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Red;
                                pcBoxJ1T8.Location = new Point(837, (658 - 153) - 51);

                            }
                            else
                            {
                           

                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Black;
                                pcBoxJ1T8.Location = new Point(837, (658 - 153) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 6)
                        {

                            if (statustabu.Tipo == "B")
                            {
                           

                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Red;
                                pcBoxJ1T8.Location = new Point(837, (658 - 204) - 51);

                            }
                            else
                            {
                             

                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Black;
                                pcBoxJ1T8.Location = new Point(837, (658 - 204) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 7)
                        {

                            if (statustabu.Tipo == "B")
                            {
                            

                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Red;
                                pcBoxJ1T8.Location = new Point(837, (658 - 255) - 51);

                            }
                            else
                            {
                              

                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Black;
                                pcBoxJ1T8.Location = new Point(837, (658 - 255) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 8)
                        {
                            if (statustabu.Tipo == "B")
                            {
                               

                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Red;
                                pcBoxJ1T8.Location = new Point(837, (658 - 306) - 51);

                            }
                            else
                            {
                              

                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Black;
                                pcBoxJ1T8.Location = new Point(837, (658 - 306) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 9)
                        {
                            if (statustabu.Tipo == "B")
                            {
                   

                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Red;
                                pcBoxJ1T8.Location = new Point(837, (658 - 357) - 51);

                            }
                            else
                            {
                        
                           

                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Black;
                                pcBoxJ1T8.Location = new Point(837, (658 - 357) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 10)
                        {
                            if (statustabu.Tipo == "B")
                            {
                    

                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Red;
                                pcBoxJ1T8.Location = new Point(837, (658 - 408) - 51);

                            }
                            else
                            {
                              

                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Black;
                                pcBoxJ1T8.Location = new Point(837, (658 - 408) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 11)
                        {
                            if (statustabu.Tipo == "B")
                            {
                               

                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Red;
                                pcBoxJ1T8.Location = new Point(837, (658 - 459) - 51);
                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Red;
                                pcBoxJ1T8.Location = new Point(837, (658 - 408) - 51);
                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Red;
                                pcBoxJ1T8.Location = new Point(837, (658 - 357) - 51);
                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Red;
                                pcBoxJ1T8.Location = new Point(837, (658 - 306) - 51);
                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Red;
                                pcBoxJ1T8.Location = new Point(837, (658 - 255) - 51);
                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Red;
                                pcBoxJ1T8.Location = new Point(837, (658 - 204) - 51);
                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Red;
                                pcBoxJ1T8.Location = new Point(837, (658 - 153) - 51);
                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Red;
                                pcBoxJ1T8.Location = new Point(837, (658 - 102) - 51);
                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Red;
                                pcBoxJ1T8.Location = new Point(837, (658 - 51) - 51);
                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Red;
                                pcBoxJ1T8.Location = new Point(837, 658 - 51);
                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Red;
                                pcBoxJ1T8.Location = new Point(837, 658);

                            }
                            else
                            {
                              

                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Black;
                                pcBoxJ1T8.Location = new Point(837, (658 - 459) - 51);
                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Black;
                                pcBoxJ1T8.Location = new Point(837, (658 - 408) - 51);
                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Black;
                                pcBoxJ1T8.Location = new Point(837, (658 - 357) - 51);
                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Black;
                                pcBoxJ1T8.Location = new Point(837, (658 - 306) - 51);
                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Black;
                                pcBoxJ1T8.Location = new Point(837, (658 - 255) - 51);
                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Black;
                                pcBoxJ1T8.Location = new Point(837, (658 - 204) - 51);
                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Black;
                                pcBoxJ1T8.Location = new Point(837, (658 - 153) - 51);
                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Black;
                                pcBoxJ1T8.Location = new Point(837, (658 - 102) - 51);
                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Black;
                                pcBoxJ1T8.Location = new Point(837, (658 - 51) - 51);
                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Black;
                                pcBoxJ1T8.Location = new Point(837, 658 - 51);
                                pcBoxJ1T8.Visible = true;
                                pcBoxJ1T8.BackColor = Color.Black;
                                pcBoxJ1T8.Location = new Point(837, 658);
                            }

                        }
                    }
                    else if (statustabu.Trilha == 9)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                          

                                pcBoxJ1T9.Visible = true;
                                pcBoxJ1T9.BackColor = Color.Red;
                                pcBoxJ1T9.Location = new Point(900, 608);

                            }
                            else
                            {
                                pcBoxJ1T9.Visible = true;
                                pcBoxJ1T9.BackColor = Color.Black;
                                pcBoxJ1T9.Location = new Point(900, 608);
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                

                                pcBoxJ1T9.Visible = true;
                                pcBoxJ1T9.BackColor = Color.Red;
                                pcBoxJ1T9.Location = new Point(900, 608 - 51);

                            }
                            else
                            {
                                

                                pcBoxJ1T9.Visible = true;
                                pcBoxJ1T9.BackColor = Color.Black;
                                pcBoxJ1T9.Location = new Point(900, 608 - 51);
                            }
                        }
                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                               

                                pcBoxJ1T9.Visible = true;
                                pcBoxJ1T9.BackColor = Color.Red;
                                pcBoxJ1T9.Location = new Point(900, (608 - 51) - 51);

                            }
                            else
                            {
                               

                                pcBoxJ1T9.Visible = true;
                                pcBoxJ1T9.BackColor = Color.Black;
                                pcBoxJ1T9.Location = new Point(900, (608 - 51) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 4)
                        {
                            if (statustabu.Tipo == "B")
                            {
                               

                                pcBoxJ1T9.Visible = true;
                                pcBoxJ1T9.BackColor = Color.Red;
                                pcBoxJ1T9.Location = new Point(900, (608 - 102) - 51);

                            }
                            else
                            {
                                

                                pcBoxJ1T9.Visible = true;
                                pcBoxJ1T9.BackColor = Color.Black;
                                pcBoxJ1T9.Location = new Point(900, (608 - 102) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 5)
                        {
                            if (statustabu.Tipo == "B")
                            {
                        

                                pcBoxJ1T9.Visible = true;
                                pcBoxJ1T9.BackColor = Color.Red;
                                pcBoxJ1T9.Location = new Point(900, (608 - 153) - 51);

                            }
                            else
                            {
                            
                                pcBoxJ1T9.Visible = true;
                                pcBoxJ1T9.BackColor = Color.Black;
                                pcBoxJ1T9.Location = new Point(900, (608 - 153) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 6)
                        {
                            if (statustabu.Tipo == "B")
                            {
                               

                                pcBoxJ1T9.Visible = true;
                                pcBoxJ1T9.BackColor = Color.Red;
                                pcBoxJ1T9.Location = new Point(900, (608 - 204) - 51);

                            }
                            else
                            {
                               

                                pcBoxJ1T9.Visible = true;
                                pcBoxJ1T9.BackColor = Color.Black;
                                pcBoxJ1T9.Location = new Point(900, (608 - 204) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 7)
                        {
                            if (statustabu.Tipo == "B")
                            {
                       

                                pcBoxJ1T9.Visible = true;
                                pcBoxJ1T9.BackColor = Color.Red;
                                pcBoxJ1T9.Location = new Point(900, (608 - 255) - 51);

                            }
                            else
                            {
                             

                                pcBoxJ1T9.Visible = true;
                                pcBoxJ1T9.BackColor = Color.Black;
                                pcBoxJ1T9.Location = new Point(900, (608 - 255) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 8)
                        {
                            if (statustabu.Tipo == "B")
                            {
                               

                                pcBoxJ1T9.Visible = true;
                                pcBoxJ1T9.BackColor = Color.Red;
                                pcBoxJ1T9.Location = new Point(900, (608 - 306) - 51);

                            }
                            else
                            {
                               

                                pcBoxJ1T9.Visible = true;
                                pcBoxJ1T9.BackColor = Color.Black;
                                pcBoxJ1T9.Location = new Point(900, (608 - 306) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 9)
                        {
                            if (statustabu.Tipo == "B")
                            {
                               

                                pcBoxJ1T9.Visible = true;
                                pcBoxJ1T9.BackColor = Color.Red;
                                pcBoxJ1T9.Location = new Point(900, (608 - 357) - 51);
                                pcBoxJ1T9.Visible = true;
                                pcBoxJ1T9.BackColor = Color.Red;
                                pcBoxJ1T9.Location = new Point(900, (608 - 306) - 51);
                                pcBoxJ1T9.Visible = true;
                                pcBoxJ1T9.BackColor = Color.Red;
                                pcBoxJ1T9.Location = new Point(900, (608 - 255) - 51);
                                pcBoxJ1T9.Visible = true;
                                pcBoxJ1T9.BackColor = Color.Red;
                                pcBoxJ1T9.Location = new Point(900, (608 - 204) - 51);
                                pcBoxJ1T9.Visible = true;
                                pcBoxJ1T9.BackColor = Color.Red;
                                pcBoxJ1T9.Location = new Point(900, (608 - 153) - 51);
                                pcBoxJ1T9.Visible = true;
                                pcBoxJ1T9.BackColor = Color.Red;
                                pcBoxJ1T9.Location = new Point(900, (608 - 102) - 51);
                                pcBoxJ1T9.Visible = true;
                                pcBoxJ1T9.BackColor = Color.Red;
                                pcBoxJ1T9.Location = new Point(900, (608 - 51) - 51);
                                pcBoxJ1T9.Visible = true;
                                pcBoxJ1T9.BackColor = Color.Red;
                                pcBoxJ1T9.Location = new Point(900, 608 - 51);
                                pcBoxJ1T9.Visible = true;
                                pcBoxJ1T9.BackColor = Color.Red;
                                pcBoxJ1T9.Location = new Point(900, 608);

                            }
                            else
                            {
                               
                                pcBoxJ1T9.Visible = true;
                                pcBoxJ1T9.BackColor = Color.Black;
                                pcBoxJ1T9.Location = new Point(900, (608 - 357) - 51);
                                pcBoxJ1T9.Visible = true;
                                pcBoxJ1T9.BackColor = Color.Black;
                                pcBoxJ1T9.Location = new Point(900, (608 - 306) - 51);
                                pcBoxJ1T9.Visible = true;
                                pcBoxJ1T9.BackColor = Color.Black;
                                pcBoxJ1T9.Location = new Point(900, (608 - 255) - 51);
                                pcBoxJ1T9.Visible = true;
                                pcBoxJ1T9.BackColor = Color.Black;
                                pcBoxJ1T9.Location = new Point(900, (608 - 204) - 51);
                                pcBoxJ1T9.Visible = true;
                                pcBoxJ1T9.BackColor = Color.Black;
                                pcBoxJ1T9.Location = new Point(900, (608 - 153) - 51);
                                pcBoxJ1T9.Visible = true;
                                pcBoxJ1T9.BackColor = Color.Black;
                                pcBoxJ1T9.Location = new Point(900, (608 - 102) - 51);
                                pcBoxJ1T9.Visible = true;
                                pcBoxJ1T9.BackColor = Color.Black;
                                pcBoxJ1T9.Location = new Point(900, (608 - 51) - 51);
                                pcBoxJ1T9.Visible = true;
                                pcBoxJ1T9.BackColor = Color.Black;
                                pcBoxJ1T9.Location = new Point(900, 608 - 51);
                                pcBoxJ1T9.Visible = true;
                                pcBoxJ1T9.BackColor = Color.Black;
                                pcBoxJ1T9.Location = new Point(900, 608);
                            }

                        }
                    }
                    else if (statustabu.Trilha == 10)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                       
                                pcBoxJ1T10.Visible = true;
                                pcBoxJ1T10.BackColor = Color.Red;
                                pcBoxJ1T10.Location = new Point(967, 559);

                            }
                            else
                            {
                           

                                pcBoxJ1T10.Visible = true;
                                pcBoxJ1T10.BackColor = Color.Black;
                                pcBoxJ1T10.Location = new Point(967, 559);
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                             

                                pcBoxJ1T10.Visible = true;
                                pcBoxJ1T10.BackColor = Color.Red;
                                pcBoxJ1T10.Location = new Point(967, 559 - 51);

                            }
                            else
                            {
               

                                pcBoxJ1T10.Visible = true;
                                pcBoxJ1T10.BackColor = Color.Black;
                                pcBoxJ1T10.Location = new Point(967, 559 - 51);
                            }
                        }
                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                


                                pcBoxJ1T10.Visible = true;
                                pcBoxJ1T10.BackColor = Color.Red;
                                pcBoxJ1T10.Location = new Point(967, (559 - 51) - 51);

                            }
                            else
                            {
                           

                                pcBoxJ1T10.Visible = true;
                                pcBoxJ1T10.BackColor = Color.Black;
                                pcBoxJ1T10.Location = new Point(967, (559 - 51) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 4)
                        {
                            if (statustabu.Tipo == "B")
                            {
                

                                pcBoxJ1T10.Visible = true;
                                pcBoxJ1T10.BackColor = Color.Red;
                                pcBoxJ1T10.Location = new Point(967, (559 - 102) - 51);

                            }
                            else
                            {
                          

                                pcBoxJ1T10.Visible = true;
                                pcBoxJ1T10.BackColor = Color.Black;
                                pcBoxJ1T10.Location = new Point(967, (559 - 102) - 51);
                            }

                        }
                        else if (statustabu.Posicao == 5)
                        {
                            if (statustabu.Tipo == "B")
                            {
                           

                                pcBoxJ1T10.Visible = true;
                                pcBoxJ1T10.BackColor = Color.Red;
                                pcBoxJ1T10.Location = new Point(967, (559 - 153) - 51);

                            }
                            else
                            {
                         

                                pcBoxJ1T10.Visible = true;
                                pcBoxJ1T10.BackColor = Color.Black;
                                pcBoxJ1T10.Location = new Point(967, (559 - 153) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 6)
                        {
                            if (statustabu.Tipo == "B")
                            {
                              

                                pcBoxJ1T10.Visible = true;
                                pcBoxJ1T10.BackColor = Color.Red;
                                pcBoxJ1T10.Location = new Point(967, (559 - 204) - 51);

                            }
                            else
                            {
                             

                                pcBoxJ1T9.Visible = true;
                                pcBoxJ1T9.BackColor = Color.Black;
                                pcBoxJ1T9.Location = new Point(967, (559 - 204) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 7)
                        {

                            if (statustabu.Tipo == "B")
                            {
                              

                                pcBoxJ1T10.Visible = true;
                                pcBoxJ1T10.BackColor = Color.Red;
                                pcBoxJ1T10.Location = new Point(967, (559 - 255) - 51);
                                pcBoxJ1T9.Visible = true;
                                pcBoxJ1T9.BackColor = Color.Red;
                                pcBoxJ1T9.Location = new Point(967, (559 - 204) - 51);
                                pcBoxJ1T10.Visible = true;
                                pcBoxJ1T10.BackColor = Color.Red;
                                pcBoxJ1T10.Location = new Point(967, (559 - 153) - 51);
                                pcBoxJ1T10.Visible = true;
                                pcBoxJ1T10.BackColor = Color.Red;
                                pcBoxJ1T10.Location = new Point(967, (559 - 102) - 51);
                                pcBoxJ1T10.Visible = true;
                                pcBoxJ1T10.BackColor = Color.Red;
                                pcBoxJ1T10.Location = new Point(967, (559 - 51) - 51);
                                pcBoxJ1T10.Visible = true;
                                pcBoxJ1T10.BackColor = Color.Red;
                                pcBoxJ1T10.Location = new Point(967, 559 - 51);
                                pcBoxJ1T10.Visible = true;
                                pcBoxJ1T10.BackColor = Color.Red;
                                pcBoxJ1T10.Location = new Point(967, 559);

                            }
                            else
                            {
                                

                                pcBoxJ1T10.Visible = true;
                                pcBoxJ1T10.BackColor = Color.Black;
                                pcBoxJ1T10.Location = new Point(967, (559 - 255) - 51);
                                pcBoxJ1T9.Visible = true;
                                pcBoxJ1T9.BackColor = Color.Black;
                                pcBoxJ1T9.Location = new Point(967, (559 - 204) - 51);
                                pcBoxJ1T10.Visible = true;
                                pcBoxJ1T10.BackColor = Color.Black;
                                pcBoxJ1T10.Location = new Point(967, (559 - 153) - 51);
                                pcBoxJ1T10.Visible = true;
                                pcBoxJ1T10.BackColor = Color.Black;
                                pcBoxJ1T10.Location = new Point(967, (559 - 102) - 51);
                                pcBoxJ1T10.Visible = true;
                                pcBoxJ1T10.BackColor = Color.Black;
                                pcBoxJ1T10.Location = new Point(967, (559 - 51) - 51);
                                pcBoxJ1T10.Visible = true;
                                pcBoxJ1T10.BackColor = Color.Black;
                                pcBoxJ1T10.Location = new Point(967, 559 - 51);
                                pcBoxJ1T10.Visible = true;
                                pcBoxJ1T10.BackColor = Color.Black;
                                pcBoxJ1T10.Location = new Point(967, 559);
                            }

                        }

                    }

                    else if (statustabu.Trilha == 11)
                    {
                        if (statustabu.Posicao == 1)
                        {

                            if (statustabu.Tipo == "B")
                            {
                          

                                pcBoxJ1T11.Visible = true;
                                pcBoxJ1T11.BackColor = Color.Red;
                                pcBoxJ1T11.Location = new Point(1031, 504);

                            }
                            else
                            {
                               

                                pcBoxJ1T11.Visible = true;
                                pcBoxJ1T11.BackColor = Color.Black;
                                pcBoxJ1T11.Location = new Point(1031, 504);
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                               

                                pcBoxJ1T11.Visible = true;
                                pcBoxJ1T11.BackColor = Color.Red;
                                pcBoxJ1T11.Location = new Point(1031, 504 - 51);

                            }
                            else
                            {
               

                                pcBoxJ1T11.Visible = true;
                                pcBoxJ1T11.BackColor = Color.Black;
                                pcBoxJ1T11.Location = new Point(1031, 504 - 51);
                            }

                        }
                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
               
                                pcBoxJ1T11.Visible = true;
                                pcBoxJ1T11.BackColor = Color.Red;
                                pcBoxJ1T11.Location = new Point(1031, (504 - 51) - 51);

                            }
                            else
                            {
                 

                                pcBoxJ1T11.Visible = true;
                                pcBoxJ1T11.BackColor = Color.Black;
                                pcBoxJ1T11.Location = new Point(1031, (504 - 51) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 4)
                        {

                            if (statustabu.Tipo == "B")
                            {
                                

                                pcBoxJ1T11.Visible = true;
                                pcBoxJ1T11.BackColor = Color.Red;
                                pcBoxJ1T11.Location = new Point(1031, (504 - 102) - 51);

                            }
                            else
                            {
                                

                                pcBoxJ1T11.Visible = true;
                                pcBoxJ1T11.BackColor = Color.Black;
                                pcBoxJ1T11.Location = new Point(1031, (504 - 102) - 51);
                            }
                        }
                        else if (statustabu.Posicao == 5)
                        {
                            if (statustabu.Tipo == "B")
                            {
                              

                                pcBoxJ1T11.Visible = true;
                                pcBoxJ1T11.BackColor = Color.Red;
                                pcBoxJ1T11.Location = new Point(1031, (504 - 153) - 51);
                                pcBoxJ1T11.Visible = true;
                                pcBoxJ1T11.BackColor = Color.Red;
                                pcBoxJ1T11.Location = new Point(1031, (504 - 102) - 51);
                                pcBoxJ1T11.Visible = true;
                                pcBoxJ1T11.BackColor = Color.Red;
                                pcBoxJ1T11.Location = new Point(1031, (504 - 51) - 51);
                                pcBoxJ1T11.Visible = true;
                                pcBoxJ1T11.BackColor = Color.Red;
                                pcBoxJ1T11.Location = new Point(1031, 504 - 51);
                                pcBoxJ1T11.Visible = true;
                                pcBoxJ1T11.BackColor = Color.Red;
                                pcBoxJ1T11.Location = new Point(1031, 504);

                            }
                            else
                            {
                               

                                pcBoxJ1T11.Visible = true;
                                pcBoxJ1T11.BackColor = Color.Black;
                                pcBoxJ1T11.Location = new Point(1031, (504 - 153) - 51);
                                pcBoxJ1T11.Visible = true;
                                pcBoxJ1T11.BackColor = Color.Black;
                                pcBoxJ1T11.Location = new Point(1031, (504 - 102) - 51);
                                pcBoxJ1T11.Visible = true;
                                pcBoxJ1T11.BackColor = Color.Black;
                                pcBoxJ1T11.Location = new Point(1031, (504 - 51) - 51);
                                pcBoxJ1T11.Visible = true;
                                pcBoxJ1T11.BackColor = Color.Black;
                                pcBoxJ1T11.Location = new Point(1031, 504 - 51);
                                pcBoxJ1T11.Visible = true;
                                pcBoxJ1T11.BackColor = Color.Black;
                                pcBoxJ1T11.Location = new Point(1031, 504);
                            }

                        }
                    }
                    else if (statustabu.Trilha == 12)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                

                                pcBoxJ1T12.Visible = true;
                                pcBoxJ1T12.BackColor = Color.Red;
                                pcBoxJ1T12.Location = new Point(1097, 455);

                            }
                            else
                            {
                              

                                pcBoxJ1T12.Visible = true;
                                pcBoxJ1T12.BackColor = Color.Black;
                                pcBoxJ1T12.Location = new Point(1097, 455);
                            }

                        }
                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                            

                                pcBoxJ1T12.Visible = true;
                                pcBoxJ1T12.BackColor = Color.Red;
                                pcBoxJ1T12.Location = new Point(1097, 455 - 51);

                            }
                            else
                            {
                      

                                pcBoxJ1T12.Visible = true;
                                pcBoxJ1T12.BackColor = Color.Black;
                                pcBoxJ1T12.Location = new Point(1097, 455 - 51);
                            }
                        }
                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                          

                                pcBoxJ1T12.Visible = true;
                                pcBoxJ1T12.BackColor = Color.Red;
                                pcBoxJ1T12.Location = new Point(1097, (455 - 51) - 51);
                                pcBoxJ1T12.Visible = true;
                                pcBoxJ1T12.BackColor = Color.Red;
                                pcBoxJ1T12.Location = new Point(1097, 455 - 51);
                                pcBoxJ1T12.Visible = true;
                                pcBoxJ1T12.BackColor = Color.Red;
                                pcBoxJ1T12.Location = new Point(1097, 455);

                            }
                            else
                            {
                          

                                pcBoxJ1T12.Visible = true;
                                pcBoxJ1T12.BackColor = Color.Black;
                                pcBoxJ1T12.Location = new Point(1097, (455 - 51) - 51);
                                pcBoxJ1T12.Visible = true;
                                pcBoxJ1T12.BackColor = Color.Black;
                                pcBoxJ1T12.Location = new Point(1097, 455 - 51);
                                pcBoxJ1T12.Visible = true;
                                pcBoxJ1T12.BackColor = Color.Black;
                                pcBoxJ1T12.Location = new Point(1097, 455);
                            }
                        }
                    }
                }

                ////////////////////////    JOGADOR 2 ///////////////

                
                else if (statustabu.idJogador == Convert.ToInt32(jogadorId[0]) + 1 )
                {
                    //TRILHA 2
                    if (statustabu.Trilha == 2)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T2.Visible = true;
                                pcBoxJ2T2.BackColor = Color.Blue;
                                pcBoxJ2T2.Location = new Point(461, 455);
                            }
                            else
                            {
                                pcBoxJ2T2.Visible = true;
                                pcBoxJ2T2.BackColor = Color.Black;
                                pcBoxJ2T2.Location = new Point(461, 455);
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T2.Visible = true;
                                pcBoxJ2T2.BackColor = Color.Blue;
                                pcBoxJ2T2.Location = new Point(461, 455 - 51);
                            }
                            else
                            {
                                pcBoxJ2T2.Visible = true;
                                pcBoxJ2T2.BackColor = Color.Black;
                                pcBoxJ2T2.Location = new Point(461, 455 - 51);

                            }
                        }
                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T2.Visible = true;
                                pcBoxJ2T2.BackColor = Color.Blue;
                                pcBoxJ2T2.Location = new Point(461, 455 - (51 * 2));
                                pcBoxJ2T2.Visible = true;
                                pcBoxJ2T2.BackColor = Color.Blue;
                                pcBoxJ2T2.Location = new Point(461, 455 - 51);
                                pcBoxJ2T2.Visible = true;
                                pcBoxJ2T2.BackColor = Color.Blue;
                                pcBoxJ2T2.Location = new Point(461, 455);
                            }
                            else
                            {
                                pcBoxJ2T2.Visible = true;
                                pcBoxJ2T2.BackColor = Color.Black;
                                pcBoxJ2T2.Location = new Point(461, 455 - (51 * 2));
                                pcBoxJ2T2.Visible = true;
                                pcBoxJ2T2.BackColor = Color.Black;
                                pcBoxJ2T2.Location = new Point(461, 455 - 51);
                                pcBoxJ2T2.Visible = true;
                                pcBoxJ2T2.BackColor = Color.Black;
                                pcBoxJ2T2.Location = new Point(461, 455);

                            }
                        }
                    }


                    //TRILHA 3

                    else if (statustabu.Trilha == 3)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T3.Visible = true;
                                pcBoxJ2T3.BackColor = Color.Blue;
                                pcBoxJ2T3.Location = new Point(527, 504);
                            }
                            else
                            {
                                pcBoxJ2T3.Visible = true;
                                pcBoxJ2T3.BackColor = Color.Black;
                                pcBoxJ2T3.Location = new Point(527, 504);
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T3.Visible = true;
                                pcBoxJ2T3.BackColor = Color.Blue;
                                pcBoxJ2T3.Location = new Point(527, 504 - (51 * 1));
                            }
                            else
                            {
                                pcBoxJ2T3.Visible = true;
                                pcBoxJ2T3.BackColor = Color.Black;
                                pcBoxJ2T3.Location = new Point(527, 504 - (51 * 1));
                            }
                        }
                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T3.Visible = true;
                                pcBoxJ2T3.BackColor = Color.Blue;
                                pcBoxJ2T3.Location = new Point(527, 504 - (51 * 2));
                            }
                            else
                            {
                                pcBoxJ2T3.Visible = true;
                                pcBoxJ2T3.BackColor = Color.Black;
                                pcBoxJ2T3.Location = new Point(527, 504 - (51 * 2));
                            }
                        }
                        else if (statustabu.Posicao == 4)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T3.Visible = true;
                                pcBoxJ2T3.BackColor = Color.Blue;
                                pcBoxJ2T3.Location = new Point(527, 504 - (51 * 3));
                            }
                            else
                            {
                                pcBoxJ2T3.Visible = true;
                                pcBoxJ2T3.BackColor = Color.Black;
                                pcBoxJ2T3.Location = new Point(527, 504 - (51 * 3));
                            }
                        }
                        else if (statustabu.Posicao == 5)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T3.Visible = true;
                                pcBoxJ2T3.BackColor = Color.Blue;
                                pcBoxJ2T3.Location = new Point(527, 504 - (51 * 4));
                                pcBoxJ2T3.Visible = true;
                                pcBoxJ2T3.BackColor = Color.Blue;
                                pcBoxJ2T3.Location = new Point(527, 504 - (51 * 3));
                                pcBoxJ2T3.Visible = true;
                                pcBoxJ2T3.BackColor = Color.Blue;
                                pcBoxJ2T3.Location = new Point(527, 504 - (51 * 2));
                                pcBoxJ2T3.Visible = true;
                                pcBoxJ2T3.BackColor = Color.Blue;
                                pcBoxJ2T3.Location = new Point(527, 504 - (51 * 1));
                                pcBoxJ2T3.Visible = true;
                                pcBoxJ2T3.BackColor = Color.Blue;
                                pcBoxJ2T3.Location = new Point(527, 504);
                            }
                            else
                            {
                                pcBoxJ2T3.Visible = true;
                                pcBoxJ2T3.BackColor = Color.Black;
                                pcBoxJ2T3.Location = new Point(527, 504 - (51 * 4));
                                pcBoxJ2T3.Visible = true;
                                pcBoxJ2T3.BackColor = Color.Black;
                                pcBoxJ2T3.Location = new Point(527, 504 - (51 * 3));
                                pcBoxJ2T3.Visible = true;
                                pcBoxJ2T3.BackColor = Color.Black;
                                pcBoxJ2T3.Location = new Point(527, 504 - (51 * 2));
                                pcBoxJ2T3.Visible = true;
                                pcBoxJ2T3.BackColor = Color.Black;
                                pcBoxJ2T3.Location = new Point(527, 504 - (51 * 1));
                                pcBoxJ2T3.Visible = true;
                                pcBoxJ2T3.BackColor = Color.Black;
                                pcBoxJ2T3.Location = new Point(527, 504);
                            }
                        }

                    }

                    // TRILHA 4
                    else if (statustabu.Trilha == 4)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T4.Visible = true;
                                pcBoxJ2T4.BackColor = Color.Blue;
                                pcBoxJ2T4.Location = new Point(594, 559);
                            }
                            else
                            {
                                pcBoxJ2T4.Visible = true;
                                pcBoxJ2T4.BackColor = Color.Black;
                                pcBoxJ2T4.Location = new Point(594, 559);
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {

                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T4.Visible = true;
                                pcBoxJ2T4.BackColor = Color.Blue;
                                pcBoxJ2T4.Location = new Point(594, 559 - 51);
                            }
                            else
                            {
                                pcBoxJ2T4.Visible = true;
                                pcBoxJ2T4.BackColor = Color.Black;
                                pcBoxJ2T4.Location = new Point(594, 559 - 51);
                            }

                        }
                        else if (statustabu.Posicao == 3)
                        {

                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T4.Visible = true;
                                pcBoxJ2T4.BackColor = Color.Blue;
                                pcBoxJ2T4.Location = new Point(594, 559 - (51 * 2));
                            }
                            else
                            {
                                pcBoxJ2T4.Visible = true;
                                pcBoxJ2T4.BackColor = Color.Black;
                                pcBoxJ2T4.Location = new Point(594, 559 - (51 * 2));
                            }
                        }
                        else if (statustabu.Posicao == 4)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T4.Visible = true;
                                pcBoxJ2T4.BackColor = Color.Blue;
                                pcBoxJ2T4.Location = new Point(594, 559 - (51 * 3));
                            }
                            else
                            {
                                pcBoxJ2T4.Visible = true;
                                pcBoxJ2T4.BackColor = Color.Black;
                                pcBoxJ2T4.Location = new Point(594, 559 - (51 * 3));
                            }
                        }
                        else if (statustabu.Posicao == 5)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T4.Visible = true;
                                pcBoxJ2T4.BackColor = Color.Blue;
                                pcBoxJ2T4.Location = new Point(594, 559 - (51 * 4));
                            }
                            else
                            {
                                pcBoxJ2T4.Visible = true;
                                pcBoxJ2T4.BackColor = Color.Black;
                                pcBoxJ2T4.Location = new Point(594, 559 - (51 * 4));
                            }
                        }
                        else if (statustabu.Posicao == 6)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T4.Visible = true;
                                pcBoxJ2T4.BackColor = Color.Blue;
                                pcBoxJ2T4.Location = new Point(594, 559 - (51 * 5));
                            }
                            else
                            {
                                pcBoxJ2T4.Visible = true;
                                pcBoxJ2T4.BackColor = Color.Black;
                                pcBoxJ2T4.Location = new Point(594, 559 - (51 * 5));
                            }
                        }
                        else if (statustabu.Posicao == 7)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T4.Visible = true;
                                pcBoxJ2T4.BackColor = Color.Blue;
                                pcBoxJ2T4.Location = new Point(594, 559 - (51 * 6));
                                pcBoxJ2T4.Visible = true;
                                pcBoxJ2T4.BackColor = Color.Blue;
                                pcBoxJ2T4.Location = new Point(594, 559 - (51 * 5));
                                pcBoxJ2T4.Visible = true;
                                pcBoxJ2T4.BackColor = Color.Blue;
                                pcBoxJ2T4.Location = new Point(594, 559 - (51 * 4));
                                pcBoxJ2T4.Visible = true;
                                pcBoxJ2T4.BackColor = Color.Blue;
                                pcBoxJ2T4.Location = new Point(594, 559 - (51 * 3));
                                pcBoxJ2T4.Visible = true;
                                pcBoxJ2T4.BackColor = Color.Blue;
                                pcBoxJ2T4.Location = new Point(594, 559 - (51 * 2));
                                pcBoxJ2T4.Visible = true;
                                pcBoxJ2T4.BackColor = Color.Blue;
                                pcBoxJ2T4.Location = new Point(594, 559 - 51);
                                pcBoxJ2T4.Visible = true;
                                pcBoxJ2T4.BackColor = Color.Blue;
                                pcBoxJ2T4.Location = new Point(594, 559);

                            }
                            else
                            {
                                pcBoxJ2T4.Visible = true;
                                pcBoxJ2T4.BackColor = Color.Black;
                                pcBoxJ2T4.Location = new Point(594, 559 - (51 * 6));
                                pcBoxJ2T4.Visible = true;
                                pcBoxJ2T4.BackColor = Color.Black;
                                pcBoxJ2T4.Location = new Point(594, 559 - (51 * 5));
                                pcBoxJ2T4.Visible = true;
                                pcBoxJ2T4.BackColor = Color.Black;
                                pcBoxJ2T4.Location = new Point(594, 559 - (51 * 4));
                                pcBoxJ2T4.Visible = true;
                                pcBoxJ2T4.BackColor = Color.Black;
                                pcBoxJ2T4.Location = new Point(594, 559 - (51 * 3));
                                pcBoxJ2T4.Visible = true;
                                pcBoxJ2T4.BackColor = Color.Black;
                                pcBoxJ2T4.Location = new Point(594, 559 - (51 * 2));
                                pcBoxJ2T4.Visible = true;
                                pcBoxJ2T4.BackColor = Color.Black;
                                pcBoxJ2T4.Location = new Point(594, 559 - 51);
                                pcBoxJ2T4.Visible = true;
                                pcBoxJ2T4.BackColor = Color.Black;
                                pcBoxJ2T4.Location = new Point(594, 559);
                            }
                        }

                    }

                    //TRILHA 5

                    else if (statustabu.Trilha == 5)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T5.Visible = true;
                                pcBoxJ2T5.BackColor = Color.Blue;
                                pcBoxJ2T5.Location = new Point(659, 608 );
                            }
                            else
                            {
                                pcBoxJ2T5.Visible = true;
                                pcBoxJ2T5.BackColor = Color.Black;
                                pcBoxJ2T5.Location = new Point(659, 608 );
                            }
                        }

                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T5.Visible = true;
                                pcBoxJ2T5.BackColor = Color.Blue;
                                pcBoxJ2T5.Location = new Point(659, 608 - 51);
                            }
                            else
                            {
                                pcBoxJ2T5.Visible = true;
                                pcBoxJ2T5.BackColor = Color.Black;
                                pcBoxJ2T5.Location = new Point(659, 608 - 51);
                            }
                        }

                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T5.Visible = true;
                                pcBoxJ2T5.BackColor = Color.Blue;
                                pcBoxJ2T5.Location = new Point(659, 608 - (51*2));
                            }
                            else
                            {
                                pcBoxJ2T5.Visible = true;
                                pcBoxJ2T5.BackColor = Color.Black;
                                pcBoxJ2T5.Location = new Point(659, 608 - (51*2));
                            }
                        }
                        else if (statustabu.Posicao == 4)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T5.Visible = true;
                                pcBoxJ2T5.BackColor = Color.Blue;
                                pcBoxJ2T5.Location = new Point(659, 608 - (51 * 3));
                            }
                            else
                            {
                                pcBoxJ2T5.Visible = true;
                                pcBoxJ2T5.BackColor = Color.Black;
                                pcBoxJ2T5.Location = new Point(659, 608 - (51 * 3));
                            }
                        }
                        else if (statustabu.Posicao == 5)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T5.Visible = true;
                                pcBoxJ2T5.BackColor = Color.Blue;
                                pcBoxJ2T5.Location = new Point(659, 608 - (51 * 4));
                            }
                            else
                            {
                                pcBoxJ2T5.Visible = true;
                                pcBoxJ2T5.BackColor = Color.Black;
                                pcBoxJ2T5.Location = new Point(659, 608 - (51 * 4));
                            }
                        }
                        else if (statustabu.Posicao == 6)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T5.Visible = true;
                                pcBoxJ2T5.BackColor = Color.Blue;
                                pcBoxJ2T5.Location = new Point(659, 608 - (51 * 5));
                            }
                            else
                            {
                                pcBoxJ2T5.Visible = true;
                                pcBoxJ2T5.BackColor = Color.Black;
                                pcBoxJ2T5.Location = new Point(659, 608 - (51 * 5));
                            }
                        }
                        else if (statustabu.Posicao == 7)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T5.Visible = true;
                                pcBoxJ2T5.BackColor = Color.Blue;
                                pcBoxJ2T5.Location = new Point(659, 608 - (51 * 6));
                            }
                            else
                            {
                                pcBoxJ2T5.Visible = true;
                                pcBoxJ2T5.BackColor = Color.Black;
                                pcBoxJ2T5.Location = new Point(659, 608 - (51 * 6));
                            }
                        }
                        else if (statustabu.Posicao == 8)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T5.Visible = true;
                                pcBoxJ2T5.BackColor = Color.Blue;
                                pcBoxJ2T5.Location = new Point(659, 608 - (51 * 7));
                            }
                            else
                            {
                                pcBoxJ2T5.Visible = true;
                                pcBoxJ2T5.BackColor = Color.Black;
                                pcBoxJ2T5.Location = new Point(659, 608 - (51 * 7));
                            }
                        }
                        else if (statustabu.Posicao == 9)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T5.Visible = true;
                                pcBoxJ2T5.BackColor = Color.Blue;
                                pcBoxJ2T5.Location = new Point(659, 608 - (51 * 8));
                                pcBoxJ2T5.Visible = true;
                                pcBoxJ2T5.BackColor = Color.Blue;
                                pcBoxJ2T5.Location = new Point(659, 608 - (51 * 7));
                                pcBoxJ2T5.Visible = true;
                                pcBoxJ2T5.BackColor = Color.Blue;
                                pcBoxJ2T5.Location = new Point(659, 608 - (51 * 6));
                                pcBoxJ2T5.Visible = true;
                                pcBoxJ2T5.BackColor = Color.Blue;
                                pcBoxJ2T5.Location = new Point(659, 608 - (51 * 5));
                                pcBoxJ2T5.Visible = true;
                                pcBoxJ2T5.BackColor = Color.Blue;
                                pcBoxJ2T5.Location = new Point(659, 608 - (51 * 4));
                                pcBoxJ2T5.Visible = true;
                                pcBoxJ2T5.BackColor = Color.Blue;
                                pcBoxJ2T5.Location = new Point(659, 608 - (51 * 3));
                                pcBoxJ2T5.Visible = true;
                                pcBoxJ2T5.BackColor = Color.Blue;
                                pcBoxJ2T5.Location = new Point(659, 608 - (51 * 2));
                                pcBoxJ2T5.Visible = true;
                                pcBoxJ2T5.BackColor = Color.Blue;
                                pcBoxJ2T5.Location = new Point(659, 608 - (51));
                                pcBoxJ2T5.Visible = true;
                                pcBoxJ2T5.BackColor = Color.Blue;
                                pcBoxJ2T5.Location = new Point(659, 608);
                            }
                            else
                            {
                                pcBoxJ2T5.Visible = true;
                                pcBoxJ2T5.BackColor = Color.Black;
                                pcBoxJ2T5.Location = new Point(659, 608 - (51 * 8));
                                pcBoxJ2T5.Visible = true;
                                pcBoxJ2T5.BackColor = Color.Black;
                                pcBoxJ2T5.Location = new Point(659, 608 - (51 * 7));
                                pcBoxJ2T5.Visible = true;
                                pcBoxJ2T5.BackColor = Color.Black;
                                pcBoxJ2T5.Location = new Point(659, 608 - (51 * 6));
                                pcBoxJ2T5.Visible = true;
                                pcBoxJ2T5.BackColor = Color.Black;
                                pcBoxJ2T5.Location = new Point(659, 608 - (51 * 5));
                                pcBoxJ2T5.Visible = true;
                                pcBoxJ2T5.BackColor = Color.Black;
                                pcBoxJ2T5.Location = new Point(659, 608 - (51 * 4));
                                pcBoxJ2T5.Visible = true;
                                pcBoxJ2T5.BackColor = Color.Black;
                                pcBoxJ2T5.Location = new Point(659, 608 - (51 * 3));
                                pcBoxJ2T5.Visible = true;
                                pcBoxJ2T5.BackColor = Color.Black;
                                pcBoxJ2T5.Location = new Point(659, 608 - (51 * 2));
                                pcBoxJ2T5.Visible = true;
                                pcBoxJ2T5.BackColor = Color.Black;
                                pcBoxJ2T5.Location = new Point(659, 608 - (51));
                                pcBoxJ2T5.Visible = true;
                                pcBoxJ2T5.BackColor = Color.Black;
                                pcBoxJ2T5.Location = new Point(659, 608);

                            }
                        }
                    }

                    //TRILHA 6
                    else if (statustabu.Trilha == 6)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Blue;
                                pcBoxJ2T6.Location = new Point(725, 658);
                            }
                            else
                            {
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Black;
                                pcBoxJ2T6.Location = new Point(725, 658);
                            }
                        }
                        else if (statustabu.Posicao ==2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Blue;
                                pcBoxJ2T6.Location = new Point(725, 658 - 51);
                            }
                            else
                            {
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Black;
                                pcBoxJ2T6.Location = new Point(725, 658 - 51);
                            }
                        }
                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Blue;
                                pcBoxJ2T6.Location = new Point(725, 658 - (51*2));
                            }
                            else
                            {
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Black;
                                pcBoxJ2T6.Location = new Point(725, 658 - (51*2));
                            }
                        }
                        else if (statustabu.Posicao == 4)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Blue;
                                pcBoxJ2T6.Location = new Point(725, 658 - (51 * 3));
                            }
                            else
                            {
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Black;
                                pcBoxJ2T6.Location = new Point(725, 658 - (51 * 3));
                            }
                        }
                        else if (statustabu.Posicao == 5)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Blue;
                                pcBoxJ2T6.Location = new Point(725, 658 - (51 * 4));
                            }
                            else
                            {
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Black;
                                pcBoxJ2T6.Location = new Point(725, 658 - (51 * 4));
                            }
                        }
                        else if (statustabu.Posicao== 6)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Blue;
                                pcBoxJ2T6.Location = new Point(725, 658 - (51 * 5));
                            }
                            else
                            {
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Black;
                                pcBoxJ2T6.Location = new Point(725, 658 - (51 * 5));
                            }
                        }
                        else if (statustabu.Posicao == 7)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Blue;
                                pcBoxJ2T6.Location = new Point(725, 658 - (51 * 6));
                            }
                            else
                            {
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Black;
                                pcBoxJ2T6.Location = new Point(725, 658 - (51 * 6));
                            }
                        }
                        else if (statustabu.Posicao == 8)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Blue;
                                pcBoxJ2T6.Location = new Point(725, 658 - (51 * 7));
                            }
                            else
                            {
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Black;
                                pcBoxJ2T6.Location = new Point(725, 658 - (51 * 7));
                            }
                        }
                        else if (statustabu.Posicao == 9)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Blue;
                                pcBoxJ2T6.Location = new Point(725, 658 - (51 * 8));
                            }
                            else
                            {
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Black;
                                pcBoxJ2T6.Location = new Point(725, 658 - (51 * 8));
                            }
                        }
                        else if (statustabu.Posicao == 10)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Blue;
                                pcBoxJ2T6.Location = new Point(725, 658 - (51 * 9));
                            }
                            else
                            {
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Black;
                                pcBoxJ2T6.Location = new Point(725, 658 - (51 * 9));
                            }
                        }
                        else if (statustabu.Posicao == 11)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Blue;
                                pcBoxJ2T6.Location = new Point(725, 658 - (51 * 10));
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Blue;
                                pcBoxJ2T6.Location = new Point(725, 658 - (51 * 9));
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Blue;
                                pcBoxJ2T6.Location = new Point(725, 658 - (51 * 8));
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Blue;
                                pcBoxJ2T6.Location = new Point(725, 658 - (51 * 7));
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Blue;
                                pcBoxJ2T6.Location = new Point(725, 658 - (51 * 6));
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Blue;
                                pcBoxJ2T6.Location = new Point(725, 658 - (51 * 5));
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Blue;
                                pcBoxJ2T6.Location = new Point(725, 658 - (51 * 4));
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Blue;
                                pcBoxJ2T6.Location = new Point(725, 658 - (51 * 3));
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Blue;
                                pcBoxJ2T6.Location = new Point(725, 658 - (51 * 2));
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Blue;
                                pcBoxJ2T6.Location = new Point(725, 658 - (51));
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Blue;
                                pcBoxJ2T6.Location = new Point(725, 658);
                            }
                            else
                            {
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Black;
                                pcBoxJ2T6.Location = new Point(725, 658 - (51 * 10));
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Black;
                                pcBoxJ2T6.Location = new Point(725, 658 - (51 * 9));
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Black;
                                pcBoxJ2T6.Location = new Point(725, 658 - (51 * 8));
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Black;
                                pcBoxJ2T6.Location = new Point(725, 658 - (51 * 7));
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Black;
                                pcBoxJ2T6.Location = new Point(725, 658 - (51 * 6));
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Black;
                                pcBoxJ2T6.Location = new Point(725, 658 - (51 * 5));
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Black;
                                pcBoxJ2T6.Location = new Point(725, 658 - (51 * 4));
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Black;
                                pcBoxJ2T6.Location = new Point(725, 658 - (51 * 3));
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Black;
                                pcBoxJ2T6.Location = new Point(725, 658 - (51 * 2));
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Black;
                                pcBoxJ2T6.Location = new Point(725, 658 - (51));
                                pcBoxJ2T6.Visible = true;
                                pcBoxJ2T6.BackColor = Color.Black;
                                pcBoxJ2T6.Location = new Point(725, 658);
                            }
                        }
                    }

                    /// TRILHA 7
                    else if (statustabu.Trilha == 7)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Blue;
                                pcBoxJ2T7.Location = new Point(791, 710);
                            }
                            else
                            {
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Black;
                                pcBoxJ2T7.Location = new Point(791, 710);
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Blue;
                                pcBoxJ2T7.Location = new Point(791, 710 - 51);
                            }
                            else
                            {
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Black;
                                pcBoxJ2T7.Location = new Point(791, 710 - 51);
                            }
                        }
                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Blue;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51* 2 ));
                            }
                            else
                            {
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Black;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 2 ));
                            }
                        }
                        else if (statustabu.Posicao == 4)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Blue;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 3));
                            }
                            else
                            {
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Black;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 3));
                            }
                        }
                        else if (statustabu.Posicao == 5)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Blue;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 4));
                            }
                            else
                            {
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Black;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 4));
                            }
                        }
                        else if (statustabu.Posicao == 6)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Blue;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 5));
                            }
                            else
                            {
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Black;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 5));
                            }
                        }
                        else if (statustabu.Posicao == 7)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Blue;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 6));
                            }
                            else
                            {
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Black;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 6));
                            }
                        }
                        else if (statustabu.Posicao == 8)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Blue;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 7));
                            }
                            else
                            {
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Black;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 7));
                            }
                        }
                        else if (statustabu. Posicao == 9)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Blue;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 8));
                            }
                            else
                            {
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Black;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 8));
                            }
                        }
                        else if (statustabu.Posicao == 10)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Blue;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 9));
                            }
                            else
                            {
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Black;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 9));
                            }
                        }
                        else if (statustabu.Posicao == 11)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Blue;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 10));
                            }
                            else
                            {
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Black;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 10));
                            }
                        }
                        else if (statustabu.Posicao == 12)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Blue;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 11));
                            }
                            else
                            {
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Black;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 11));
                            }
                        }
                        else if (statustabu.Posicao == 13)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Blue;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 12));
                                pcBoxJ2T7.BackColor = Color.Blue;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 11));
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Blue;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 10));
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Blue;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 9));
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Blue;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 8));
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Blue;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 7));
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Blue;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 6));
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Blue;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 5));
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Blue;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 4));
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Blue;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 3));
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Blue;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 2));
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Blue;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51));
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Blue;
                                pcBoxJ2T7.Location = new Point(791, 710);
                            }
                            else
                            {
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Black;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 12));
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Black;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 11));
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Black;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 10));
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Black;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 9));
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Black;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 8));
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Black;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 7));
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Black;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 6));
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Black;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 5));
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Black;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 4));
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Black;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 3));
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Black;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51 * 2));
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Black;
                                pcBoxJ2T7.Location = new Point(791, 710 - (51));
                                pcBoxJ2T7.Visible = true;
                                pcBoxJ2T7.BackColor = Color.Black;
                                pcBoxJ2T7.Location = new Point(791, 710);
                            }
                        }
                    }


                    // TRILHA 8
                    else if (statustabu.Trilha == 8)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Blue;
                                pcBoxJ2T8.Location = new Point(857, 658);
                            }
                            else
                            {
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Black;
                                pcBoxJ2T8.Location = new Point(857, 658 );
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Blue;
                                pcBoxJ2T8.Location = new Point(857, 658 - 51);
                            }
                            else
                            {
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Black;
                                pcBoxJ2T8.Location = new Point(857, 658 - 51 );
                            }
                        }
                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Blue;
                                pcBoxJ2T8.Location = new Point(857, 658 - (51 * 2 ));
                            }
                            else
                            {
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Black;
                                pcBoxJ2T8.Location = new Point(857, 658 - (51 * 2 ));
                            }
                        }
                        else if (statustabu.Posicao == 4)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Blue;
                                pcBoxJ2T8.Location = new Point(857, 658 - (51 * 3));
                            }
                            else
                            {
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Black;
                                pcBoxJ2T8.Location = new Point(857, 658 - (51 * 3));
                            }
                        }
                        else if (statustabu.Posicao == 5)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Blue;
                                pcBoxJ2T8.Location = new Point(857, 658 - (51 * 4));
                            }
                            else
                            {
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Black;
                                pcBoxJ2T8.Location = new Point(857, 658 - (51 * 4));
                            }
                        }
                        else if (statustabu.Posicao == 6)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Blue;
                                pcBoxJ2T8.Location = new Point(857, 658 - (51 * 5));
                            }
                            else
                            {
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Black;
                                pcBoxJ2T8.Location = new Point(857, 658 - (51 * 5));
                            }
                        }
                        else if (statustabu.Posicao == 7)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Blue;
                                pcBoxJ2T8.Location = new Point(857, 658 - (51 * 6));
                            }
                            else
                            {
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Black;
                                pcBoxJ2T8.Location = new Point(857, 658 - (51 * 6));
                            }
                        }
                        else if (statustabu.Posicao == 8)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Blue;
                                pcBoxJ2T8.Location = new Point(857, 658 - (51 * 7));
                            }
                            else
                            {
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Black;
                                pcBoxJ2T8.Location = new Point(857, 658 - (51 * 7));
                            }
                        }
                        else if (statustabu.Posicao == 9)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Blue;
                                pcBoxJ2T8.Location = new Point(857, 658 - (51 * 8));
                            }
                            else
                            {
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Black;
                                pcBoxJ2T8.Location = new Point(857, 658 - (51 * 8));
                            }
                        }
                        else if (statustabu.Posicao == 10)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Blue;
                                pcBoxJ2T8.Location = new Point(857, 658 - (51 * 9));
                            }
                            else
                            {
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Black;
                                pcBoxJ2T8.Location = new Point(857, 658 - (51 * 9));
                            }
                        }
                        else if (statustabu.Posicao == 11)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Blue;
                                pcBoxJ2T8.Location = new Point(857, 658 - (51 * 10));
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Blue;
                                pcBoxJ2T8.Location = new Point(857, 658 - (51 * 9));
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Blue;
                                pcBoxJ2T8.Location = new Point(857, 658 - (51 * 8));
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Blue;
                                pcBoxJ2T8.Location = new Point(857, 658 - (51 * 7));
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Blue;
                                pcBoxJ2T8.Location = new Point(857, 658 - (51 * 6));
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Blue;
                                pcBoxJ2T8.Location = new Point(857, 658 - (51 * 5));
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Blue;
                                pcBoxJ2T8.Location = new Point(857, 658 - (51 * 4));
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Blue;
                                pcBoxJ2T8.Location = new Point(857, 658 - (51 * 3));
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Blue;
                                pcBoxJ2T8.Location = new Point(857, 658 - (51 * 2));
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Blue;
                                pcBoxJ2T8.Location = new Point(857, 658 - (51));
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Blue;
                                pcBoxJ2T8.Location = new Point(857, 658);
                            }
                            else
                            {
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Black;
                                pcBoxJ2T8.Location = new Point(857, 658 - (51 * 10));
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Black;
                                pcBoxJ2T8.Location = new Point(857, 658 - (51 * 9));
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Black;
                                pcBoxJ2T8.Location = new Point(857, 658 - (51 * 8));
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Black;
                                pcBoxJ2T8.Location = new Point(857, 658 - (51 * 7));
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Black;
                                pcBoxJ2T8.Location = new Point(857, 658 - (51 * 6));
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Black;
                                pcBoxJ2T8.Location = new Point(857, 658 - (51 * 5));
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Black;
                                pcBoxJ2T8.Location = new Point(857, 658 - (51 * 4));
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Black;
                                pcBoxJ2T8.Location = new Point(857, 658 - (51 * 3));
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Black;
                                pcBoxJ2T8.Location = new Point(857, 658 - (51 * 2));
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Black;
                                pcBoxJ2T8.Location = new Point(857, 658 - (51));
                                pcBoxJ2T8.Visible = true;
                                pcBoxJ2T8.BackColor = Color.Black;
                                pcBoxJ2T8.Location = new Point(857, 658);
                            }
                        }
                    }
                    //TRILHA 9
                    else if (statustabu.Trilha == 9)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T9.Visible = true;
                                pcBoxJ2T9.BackColor = Color.Blue;
                                pcBoxJ2T9.Location = new Point(920, 608);
                            }
                            else
                            {
                                pcBoxJ2T9.Visible = true;
                                pcBoxJ2T9.BackColor = Color.Black;
                                pcBoxJ2T9.Location = new Point(920, 608);
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T9.Visible = true;
                                pcBoxJ2T9.BackColor = Color.Blue;
                                pcBoxJ2T9.Location = new Point(920, 608 - 51);
                            }
                            else
                            {
                                pcBoxJ2T9.Visible = true;
                                pcBoxJ2T9.BackColor = Color.Black;
                                pcBoxJ2T9.Location = new Point(920, 608 - 51 );
                            }
                        }
                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T9.Visible = true;
                                pcBoxJ2T9.BackColor = Color.Blue;
                                pcBoxJ2T9.Location = new Point(920, 608 - (51 * 2));
                            }
                            else
                            {
                                pcBoxJ2T9.Visible = true;
                                pcBoxJ2T9.BackColor = Color.Black;
                                pcBoxJ2T9.Location = new Point(920, 608 - (51 * 2));
                            }
                        }
                        else if (statustabu.Posicao == 4)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T9.Visible = true;
                                pcBoxJ2T9.BackColor = Color.Blue;
                                pcBoxJ2T9.Location = new Point(920, 608 - (51 * 3));
                            }
                            else
                            {
                                pcBoxJ2T9.Visible = true;
                                pcBoxJ2T9.BackColor = Color.Black;
                                pcBoxJ2T9.Location = new Point(920, 608 - (51 * 3));
                            }
                        }
                        else if (statustabu.Posicao == 5)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T9.Visible = true;
                                pcBoxJ2T9.BackColor = Color.Blue;
                                pcBoxJ2T9.Location = new Point(920, 608 - (51 * 4));
                            }
                            else
                            {
                                pcBoxJ2T9.Visible = true;
                                pcBoxJ2T9.BackColor = Color.Black;
                                pcBoxJ2T9.Location = new Point(920, 608 - (51 * 4));
                            }
                        }
                        else if (statustabu.Posicao == 6)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T9.Visible = true;
                                pcBoxJ2T9.BackColor = Color.Blue;
                                pcBoxJ2T9.Location = new Point(920, 608 - (51 * 5));
                            }
                            else
                            {
                                pcBoxJ2T9.Visible = true;
                                pcBoxJ2T9.BackColor = Color.Black;
                                pcBoxJ2T9.Location = new Point(920, 608 - (51 * 5));
                            }
                        }
                        else if (statustabu.Posicao == 7)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T9.Visible = true;
                                pcBoxJ2T9.BackColor = Color.Blue;
                                pcBoxJ2T9.Location = new Point(920, 608 - (51 * 6));
                            }
                            else
                            {
                                pcBoxJ2T9.Visible = true;
                                pcBoxJ2T9.BackColor = Color.Black;
                                pcBoxJ2T9.Location = new Point(920, 608 - (51 * 6));
                            }
                        }
                        else if (statustabu.Posicao == 8)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T9.Visible = true;
                                pcBoxJ2T9.BackColor = Color.Blue;
                                pcBoxJ2T9.Location = new Point(920, 608 - (51 * 7));
                            }
                            else
                            {
                                pcBoxJ2T9.Visible = true;
                                pcBoxJ2T9.BackColor = Color.Black;
                                pcBoxJ2T9.Location = new Point(920, 608 - (51 * 7));
                            }
                        }
                        else if (statustabu.Posicao== 9)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T9.Visible = true;
                                pcBoxJ2T9.BackColor = Color.Blue;
                                pcBoxJ2T9.Location = new Point(920, 608 - (51 * 8));
                                pcBoxJ2T9.Visible = true;
                                pcBoxJ2T9.BackColor = Color.Blue;
                                pcBoxJ2T9.Location = new Point(920, 608 - (51 * 7));
                                pcBoxJ2T9.Visible = true;
                                pcBoxJ2T9.BackColor = Color.Blue;
                                pcBoxJ2T9.Location = new Point(920, 608 - (51 * 6));
                                pcBoxJ2T9.Visible = true;
                                pcBoxJ2T9.BackColor = Color.Blue;
                                pcBoxJ2T9.Location = new Point(920, 608 - (51 * 5));
                                pcBoxJ2T9.Visible = true;
                                pcBoxJ2T9.BackColor = Color.Blue;
                                pcBoxJ2T9.Location = new Point(920, 608 - (51 * 4));
                                pcBoxJ2T9.Visible = true;
                                pcBoxJ2T9.BackColor = Color.Blue;
                                pcBoxJ2T9.Location = new Point(920, 608 - (51 * 3));
                                pcBoxJ2T9.Visible = true;
                                pcBoxJ2T9.BackColor = Color.Blue;
                                pcBoxJ2T9.Location = new Point(920, 608 - (51 * 2));
                                pcBoxJ2T9.Visible = true;
                                pcBoxJ2T9.BackColor = Color.Blue;
                                pcBoxJ2T9.Location = new Point(920, 608 - (51));
                                pcBoxJ2T9.Visible = true;
                                pcBoxJ2T9.BackColor = Color.Blue;
                                pcBoxJ2T9.Location = new Point(920, 608);
                            }
                            else
                            {
                                pcBoxJ2T9.Visible = true;
                                pcBoxJ2T9.BackColor = Color.Black;
                                pcBoxJ2T9.Location = new Point(920, 608 - (51 * 8));
                                pcBoxJ2T9.Visible = true;
                                pcBoxJ2T9.BackColor = Color.Black;
                                pcBoxJ2T9.Location = new Point(920, 608 - (51 * 7));
                                pcBoxJ2T9.Visible = true;
                                pcBoxJ2T9.BackColor = Color.Black;
                                pcBoxJ2T9.Location = new Point(920, 608 - (51 * 6));
                                pcBoxJ2T9.Visible = true;
                                pcBoxJ2T9.BackColor = Color.Black;
                                pcBoxJ2T9.Location = new Point(920, 608 - (51 * 5));
                                pcBoxJ2T9.Visible = true;
                                pcBoxJ2T9.BackColor = Color.Black;
                                pcBoxJ2T9.Location = new Point(920, 608 - (51 * 4));
                                pcBoxJ2T9.Visible = true;
                                pcBoxJ2T9.BackColor = Color.Black;
                                pcBoxJ2T9.Location = new Point(920, 608 - (51 * 3));
                                pcBoxJ2T9.Visible = true;
                                pcBoxJ2T9.BackColor = Color.Black;
                                pcBoxJ2T9.Location = new Point(920, 608 - (51 * 2));
                                pcBoxJ2T9.Visible = true;
                                pcBoxJ2T9.BackColor = Color.Black;
                                pcBoxJ2T9.Location = new Point(920, 608 - (51));
                                pcBoxJ2T9.Visible = true;
                                pcBoxJ2T9.BackColor = Color.Black;
                                pcBoxJ2T9.Location = new Point(920, 608);
                            }
                        }
                    }
                    //TRILHA 10
                    else if (statustabu.Trilha == 10)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T10.Visible = true;
                                pcBoxJ2T10.BackColor = Color.Blue;
                                pcBoxJ2T10.Location = new Point(987, 559);
                            }
                            else
                            {
                                pcBoxJ2T10.Visible = true;
                                pcBoxJ2T10.BackColor = Color.Black;
                                pcBoxJ2T10.Location = new Point(987, 559 );
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T10.Visible = true;
                                pcBoxJ2T10.BackColor = Color.Blue;
                                pcBoxJ2T10.Location = new Point(987, 559 - 51);
                            }
                            else
                            {
                                pcBoxJ2T10.Visible = true;
                                pcBoxJ2T10.BackColor = Color.Black;
                                pcBoxJ2T10.Location = new Point(987, 559 - 51 );
                            }
                        }
                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T10.Visible = true;
                                pcBoxJ2T10.BackColor = Color.Blue;
                                pcBoxJ2T10.Location = new Point(987, 559 - (51 * 2));
                            }
                            else
                            {
                                pcBoxJ2T10.Visible = true;
                                pcBoxJ2T10.BackColor = Color.Black;
                                pcBoxJ2T10.Location = new Point(987, 559 - (51 * 2));
                            }
                        }
                        else if (statustabu.Posicao == 4)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T10.Visible = true;
                                pcBoxJ2T10.BackColor = Color.Blue;
                                pcBoxJ2T10.Location = new Point(987, 559 - (51 * 3));
                            }
                            else
                            {
                                pcBoxJ2T10.Visible = true;
                                pcBoxJ2T10.BackColor = Color.Black;
                                pcBoxJ2T10.Location = new Point(987, 559 - (51 * 3));
                            }
                        }
                        else if (statustabu.Posicao == 5)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T10.Visible = true;
                                pcBoxJ2T10.BackColor = Color.Blue;
                                pcBoxJ2T10.Location = new Point(987, 559 - (51 * 4));
                            }
                            else
                            {
                                pcBoxJ2T10.Visible = true;
                                pcBoxJ2T10.BackColor = Color.Black;
                                pcBoxJ2T10.Location = new Point(987, 559 - (51 * 4));
                            }
                        }
                        else if (statustabu.Posicao == 6)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T10.Visible = true;
                                pcBoxJ2T10.BackColor = Color.Blue;
                                pcBoxJ2T10.Location = new Point(987, 559 - (51 * 5));
                            }
                            else
                            {
                                pcBoxJ2T10.Visible = true;
                                pcBoxJ2T10.BackColor = Color.Black;
                                pcBoxJ2T10.Location = new Point(987, 559 - (51 * 5));
                            }
                        }
                        else if (statustabu.Posicao == 7 )
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T10.Visible = true;
                                pcBoxJ2T10.BackColor = Color.Blue;
                                pcBoxJ2T10.Location = new Point(987, 559 - (51 * 6));
                                pcBoxJ2T10.Visible = true;
                                pcBoxJ2T10.BackColor = Color.Blue;
                                pcBoxJ2T10.Location = new Point(987, 559 - (51 * 5));
                                pcBoxJ2T10.Visible = true;
                                pcBoxJ2T10.BackColor = Color.Blue;
                                pcBoxJ2T10.Location = new Point(987, 559 - (51 * 4));
                                pcBoxJ2T10.Visible = true;
                                pcBoxJ2T10.BackColor = Color.Blue;
                                pcBoxJ2T10.Location = new Point(987, 559 - (51 * 3));
                                pcBoxJ2T10.Visible = true;
                                pcBoxJ2T10.BackColor = Color.Blue;
                                pcBoxJ2T10.Location = new Point(987, 559 - (51 * 2));
                                pcBoxJ2T10.Visible = true;
                                pcBoxJ2T10.BackColor = Color.Blue;
                                pcBoxJ2T10.Location = new Point(987, 559 - (51));
                                pcBoxJ2T10.Visible = true;
                                pcBoxJ2T10.BackColor = Color.Blue;
                                pcBoxJ2T10.Location = new Point(987, 559);
                            }
                            else
                            {
                                pcBoxJ2T10.Visible = true;
                                pcBoxJ2T10.BackColor = Color.Black;
                                pcBoxJ2T10.Location = new Point(987, 559 - (51 * 6));
                                pcBoxJ2T10.Visible = true;
                                pcBoxJ2T10.BackColor = Color.Black;
                                pcBoxJ2T10.Location = new Point(987, 559 - (51 * 5));
                                pcBoxJ2T10.Visible = true;
                                pcBoxJ2T10.BackColor = Color.Black;
                                pcBoxJ2T10.Location = new Point(987, 559 - (51 * 4));
                                pcBoxJ2T10.Visible = true;
                                pcBoxJ2T10.BackColor = Color.Black;
                                pcBoxJ2T10.Location = new Point(987, 559 - (51 * 3));
                                pcBoxJ2T10.Visible = true;
                                pcBoxJ2T10.BackColor = Color.Black;
                                pcBoxJ2T10.Location = new Point(987, 559 - (51 * 2));
                                pcBoxJ2T10.Visible = true;
                                pcBoxJ2T10.BackColor = Color.Black;
                                pcBoxJ2T10.Location = new Point(987, 559 - (51));
                                pcBoxJ2T10.Visible = true;
                                pcBoxJ2T10.BackColor = Color.Black;
                                pcBoxJ2T10.Location = new Point(987, 559);
                            }
                        }
                    }

                    //TRILHA 11
                    else if (statustabu.Trilha == 11)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T11.Visible = true;
                                pcBoxJ2T11.BackColor = Color.Blue;
                                pcBoxJ2T11.Location = new Point(1051, 504 );
                            }
                            else
                            {
                                pcBoxJ2T11.Visible = true;
                                pcBoxJ2T11.BackColor = Color.Black;
                                pcBoxJ2T11.Location = new Point(1051, 504 );
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T11.Visible = true;
                                pcBoxJ2T11.BackColor = Color.Blue;
                                pcBoxJ2T11.Location = new Point(1051, 504 - 51);
                            }
                            else
                            {
                                pcBoxJ2T11.Visible = true;
                                pcBoxJ2T11.BackColor = Color.Black;
                                pcBoxJ2T11.Location = new Point(1051, 504 - 51);
                            }
                        }
                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T11.Visible = true;
                                pcBoxJ2T11.BackColor = Color.Blue;
                                pcBoxJ2T11.Location = new Point(1051, 504 - (51 * 2 ));
                            }
                            else
                            {
                                pcBoxJ2T11.Visible = true;
                                pcBoxJ2T11.BackColor = Color.Black;
                                pcBoxJ2T11.Location = new Point(1051, 504 - (51 * 2));
                            }
                        }
                        else if (statustabu.Posicao == 4)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T11.Visible = true;
                                pcBoxJ2T11.BackColor = Color.Blue;
                                pcBoxJ2T11.Location = new Point(1051, 504 - (51 * 3));
                            }
                            else
                            {
                                pcBoxJ2T11.Visible = true;
                                pcBoxJ2T11.BackColor = Color.Black;
                                pcBoxJ2T11.Location = new Point(1051, 504 - (51 * 3));
                            }
                        }
                        else if (statustabu.Posicao == 5)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T11.Visible = true;
                                pcBoxJ2T11.BackColor = Color.Blue;
                                pcBoxJ2T11.Location = new Point(1051, 504 - (51 * 4));
                                pcBoxJ2T11.Visible = true;
                                pcBoxJ2T11.BackColor = Color.Blue;
                                pcBoxJ2T11.Location = new Point(1051, 504 - (51 * 3));
                                pcBoxJ2T11.Visible = true;
                                pcBoxJ2T11.BackColor = Color.Blue;
                                pcBoxJ2T11.Location = new Point(1051, 504 - (51 * 2));
                                pcBoxJ2T11.Visible = true;
                                pcBoxJ2T11.BackColor = Color.Blue;
                                pcBoxJ2T11.Location = new Point(1051, 504 - (51));
                                pcBoxJ2T11.Visible = true;
                                pcBoxJ2T11.BackColor = Color.Blue;
                                pcBoxJ2T11.Location = new Point(1051, 504);
                            }
                            else
                            {
                                pcBoxJ2T11.Visible = true;
                                pcBoxJ2T11.BackColor = Color.Black;
                                pcBoxJ2T11.Location = new Point(1051, 504 - (51 * 4));
                                pcBoxJ2T11.Visible = true;
                                pcBoxJ2T11.BackColor = Color.Black;
                                pcBoxJ2T11.Location = new Point(1051, 504 - (51 * 3));
                                pcBoxJ2T11.Visible = true;
                                pcBoxJ2T11.BackColor = Color.Black;
                                pcBoxJ2T11.Location = new Point(1051, 504 - (51 * 2));
                                pcBoxJ2T11.Visible = true;
                                pcBoxJ2T11.BackColor = Color.Black;
                                pcBoxJ2T11.Location = new Point(1051, 504 - (51));
                                pcBoxJ2T11.Visible = true;
                                pcBoxJ2T11.BackColor = Color.Black;
                                pcBoxJ2T11.Location = new Point(1051, 504);
                            }
                        }
                    }

                    //TRILHA 12
                    else if (statustabu.Trilha == 12)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T12.Visible = true;
                                pcBoxJ2T12.BackColor = Color.Blue;
                                pcBoxJ2T12.Location = new Point(1117, 455);
                            }
                            else
                            {
                                pcBoxJ2T12.Visible = true;
                                pcBoxJ2T12.BackColor = Color.Black;
                                pcBoxJ2T12.Location = new Point(1117, 455 );
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T12.Visible = true;
                                pcBoxJ2T12.BackColor = Color.Blue;
                                pcBoxJ2T12.Location = new Point(1117, 455 - 51);
                            }
                            else
                            {
                                pcBoxJ2T12.Visible = true;
                                pcBoxJ2T12.BackColor = Color.Black;
                                pcBoxJ2T12.Location = new Point(1117, 455 - 51);
                            }
                        }
                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ2T12.Visible = true;
                                pcBoxJ2T12.BackColor = Color.Blue;
                                pcBoxJ2T12.Location = new Point(1117, 455 - (51 * 2 ));
                                pcBoxJ2T12.Visible = true;
                                pcBoxJ2T12.BackColor = Color.Blue;
                                pcBoxJ2T12.Location = new Point(1117, 455 - (51));
                                pcBoxJ2T12.Visible = true;
                                pcBoxJ2T12.BackColor = Color.Blue;
                                pcBoxJ2T12.Location = new Point(1117, 455);
                            }
                            else
                            {
                                pcBoxJ2T12.Visible = true;
                                pcBoxJ2T12.BackColor = Color.Black;
                                pcBoxJ2T12.Location = new Point(1117, 455 - (51 * 2));
                                pcBoxJ2T12.Visible = true;
                                pcBoxJ2T12.BackColor = Color.Black;
                                pcBoxJ2T12.Location = new Point(1117, 455 - (51));
                                pcBoxJ2T12.Visible = true;
                                pcBoxJ2T12.BackColor = Color.Black;
                                pcBoxJ2T12.Location = new Point(1117, 455);
                            }
                        }
                    }

                }

                ////////////////////////    JOGADOR 3 ///////////////


                else if (statustabu.idJogador == Convert.ToInt32(jogadorId[0] ) + 2)
                {
                    //TRILHA 2
                    if (statustabu.Trilha == 2)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T2.Visible = true;
                                pcBoxJ3T2.BackColor = Color.Green;
                                pcBoxJ3T2.Location = new Point(446, 471 );
                            }
                            else
                            {
                                pcBoxJ3T2.Visible = true;
                                pcBoxJ3T2.BackColor = Color.Black;
                                pcBoxJ3T2.Location = new Point(446, 471);
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T2.Visible = true;
                                pcBoxJ3T2.BackColor = Color.Green;
                                pcBoxJ3T2.Location = new Point(446, 471 - 51);
                            }
                            else
                            {
                                pcBoxJ3T2.Visible = true;
                                pcBoxJ3T2.BackColor = Color.Black;
                                pcBoxJ3T2.Location = new Point(446, 471 - 51);
                            }
                        }
                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T2.Visible = true;
                                pcBoxJ3T2.BackColor = Color.Green;
                                pcBoxJ3T2.Location = new Point(446, 471 - (51 * 2));
                                pcBoxJ3T2.Visible = true;
                                pcBoxJ3T2.BackColor = Color.Green;
                                pcBoxJ3T2.Location = new Point(446, 471 - (51));
                                pcBoxJ3T2.Visible = true;
                                pcBoxJ3T2.BackColor = Color.Green;
                                pcBoxJ3T2.Location = new Point(446, 471);
                            }
                            else
                            {
                                pcBoxJ3T2.Visible = true;
                                pcBoxJ3T2.BackColor = Color.Black;
                                pcBoxJ3T2.Location = new Point(446, 471 - (51 * 2));
                                pcBoxJ3T2.Visible = true;
                                pcBoxJ3T2.BackColor = Color.Black;
                                pcBoxJ3T2.Location = new Point(446, 471 - (51));
                                pcBoxJ3T2.Visible = true;
                                pcBoxJ3T2.BackColor = Color.Black;
                                pcBoxJ3T2.Location = new Point(446, 471);
                            }
                        }
                    }


                    //TRILHA 3

                    else if (statustabu.Trilha == 3)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T3.Visible = true;
                                pcBoxJ3T3.BackColor = Color.Green;
                                pcBoxJ3T3.Location = new Point(506, 521);
                            }
                            else
                            {
                                pcBoxJ3T3.Visible = true;
                                pcBoxJ3T3.BackColor = Color.Black;
                                pcBoxJ3T3.Location = new Point(506, 521);
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T3.Visible = true;
                                pcBoxJ3T3.BackColor = Color.Green;
                                pcBoxJ3T3.Location = new Point(506, 521 - (51 * 1));
                            }
                            else
                            {
                                pcBoxJ3T3.Visible = true;
                                pcBoxJ3T3.BackColor = Color.Black;
                                pcBoxJ3T3.Location = new Point(506, 521 - (51 * 1));
                            }
                        }
                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T3.Visible = true;
                                pcBoxJ3T3.BackColor = Color.Green;
                                pcBoxJ3T3.Location = new Point(506, 521 - (51 * 2));
                            }
                            else
                            {
                                pcBoxJ3T3.Visible = true;
                                pcBoxJ3T3.BackColor = Color.Black;
                                pcBoxJ3T3.Location = new Point(506, 521 - (51 * 2));
                            }
                        }
                        else if (statustabu.Posicao == 4)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T3.Visible = true;
                                pcBoxJ3T3.BackColor = Color.Green;
                                pcBoxJ3T3.Location = new Point(506, 521 - (51 * 3));
                            }
                            else
                            {
                                pcBoxJ3T3.Visible = true;
                                pcBoxJ3T3.BackColor = Color.Black;
                                pcBoxJ3T3.Location = new Point(506, 521 - (51 * 3));
                            }
                        }
                        else if (statustabu.Posicao == 5)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T3.Visible = true;
                                pcBoxJ3T3.BackColor = Color.Green;
                                pcBoxJ3T3.Location = new Point(506, 521 - (51 * 4));
                                pcBoxJ3T3.Visible = true;
                                pcBoxJ3T3.BackColor = Color.Green;
                                pcBoxJ3T3.Location = new Point(506, 521 - (51 * 3));
                                pcBoxJ3T3.Visible = true;
                                pcBoxJ3T3.BackColor = Color.Green;
                                pcBoxJ3T3.Location = new Point(506, 521 - (51 * 2));
                                pcBoxJ3T3.Visible = true;
                                pcBoxJ3T3.BackColor = Color.Green;
                                pcBoxJ3T3.Location = new Point(506, 521 - (51));
                                pcBoxJ3T3.Visible = true;
                                pcBoxJ3T3.BackColor = Color.Green;
                                pcBoxJ3T3.Location = new Point(506, 521);
                            }
                            else
                            {
                                pcBoxJ3T3.Visible = true;
                                pcBoxJ3T3.BackColor = Color.Black;
                                pcBoxJ3T3.Location = new Point(506, 521 - (51 * 4));
                                pcBoxJ3T3.Visible = true;
                                pcBoxJ3T3.BackColor = Color.Black;
                                pcBoxJ3T3.Location = new Point(506, 521 - (51 * 3));
                                pcBoxJ3T3.Visible = true;
                                pcBoxJ3T3.BackColor = Color.Black;
                                pcBoxJ3T3.Location = new Point(506, 521 - (51 * 2));
                                pcBoxJ3T3.Visible = true;
                                pcBoxJ3T3.BackColor = Color.Black;
                                pcBoxJ3T3.Location = new Point(506, 521 - (51));
                                pcBoxJ3T3.Visible = true;
                                pcBoxJ3T3.BackColor = Color.Black;
                                pcBoxJ3T3.Location = new Point(506, 521);
                            }
                        }

                    }

                    // TRILHA 4
                    else if (statustabu.Trilha == 4)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T4.Visible = true;
                                pcBoxJ3T4.BackColor = Color.Green;
                                pcBoxJ3T4.Location = new Point(574, 570);
                            }
                            else
                            {
                                pcBoxJ3T4.Visible = true;
                                pcBoxJ3T4.BackColor = Color.Black;
                                pcBoxJ3T4.Location = new Point(574, 570);
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {

                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T4.Visible = true;
                                pcBoxJ3T4.BackColor = Color.Green;
                                pcBoxJ3T4.Location = new Point(574, 570 - 51);
                            }
                            else
                            {
                                pcBoxJ3T4.Visible = true;
                                pcBoxJ3T4.BackColor = Color.Black;
                                pcBoxJ3T4.Location = new Point(574, 570 - 51);
                            }

                        }
                        else if (statustabu.Posicao == 3)
                        {

                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T4.Visible = true;
                                pcBoxJ3T4.BackColor = Color.Green;
                                pcBoxJ3T4.Location = new Point(574, 570 - (51 * 2));
                            }
                            else
                            {
                                pcBoxJ3T4.Visible = true;
                                pcBoxJ3T4.BackColor = Color.Black;
                                pcBoxJ3T4.Location = new Point(574, 570 - (51 * 2));
                            }
                        }
                        else if (statustabu.Posicao == 4)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T4.Visible = true;
                                pcBoxJ3T4.BackColor = Color.Green;
                                pcBoxJ3T4.Location = new Point(574, 570 - (51 * 3));
                            }
                            else
                            {
                                pcBoxJ3T4.Visible = true;
                                pcBoxJ3T4.BackColor = Color.Black;
                                pcBoxJ3T4.Location = new Point(574, 570 - (51 * 3));
                            }
                        }
                        else if (statustabu.Posicao == 5)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T4.Visible = true;
                                pcBoxJ3T4.BackColor = Color.Green;
                                pcBoxJ3T4.Location = new Point(574, 570 - (51 * 4));
                            }
                            else
                            {
                                pcBoxJ3T4.Visible = true;
                                pcBoxJ3T4.BackColor = Color.Black;
                                pcBoxJ3T4.Location = new Point(574, 570 - (51 * 4));
                            }
                        }
                        else if (statustabu.Posicao == 6)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T4.Visible = true;
                                pcBoxJ3T4.BackColor = Color.Green;
                                pcBoxJ3T4.Location = new Point(574, 570 - (51 * 5));
                            }
                            else
                            {
                                pcBoxJ3T4.Visible = true;
                                pcBoxJ3T4.BackColor = Color.Black;
                                pcBoxJ3T4.Location = new Point(574, 570 - (51 * 5));
                            }
                        }
                        else if (statustabu.Posicao == 7)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T4.Visible = true;
                                pcBoxJ3T4.BackColor = Color.Green;
                                pcBoxJ3T4.Location = new Point(574, 570 - (51 * 6));
                                pcBoxJ3T4.Visible = true;
                                pcBoxJ3T4.BackColor = Color.Green;
                                pcBoxJ3T4.Location = new Point(574, 570 - (51 * 5));
                                pcBoxJ3T4.Visible = true;
                                pcBoxJ3T4.BackColor = Color.Green;
                                pcBoxJ3T4.Location = new Point(574, 570 - (51 * 4));
                                pcBoxJ3T4.Visible = true;
                                pcBoxJ3T4.BackColor = Color.Green;
                                pcBoxJ3T4.Location = new Point(574, 570 - (51 * 3));
                                pcBoxJ3T4.Visible = true;
                                pcBoxJ3T4.BackColor = Color.Green;
                                pcBoxJ3T4.Location = new Point(574, 570 - (51 * 2));
                                pcBoxJ3T4.Visible = true;
                                pcBoxJ3T4.BackColor = Color.Green;
                                pcBoxJ3T4.Location = new Point(574, 570 - (51));
                                pcBoxJ3T4.Visible = true;
                                pcBoxJ3T4.BackColor = Color.Green;
                                pcBoxJ3T4.Location = new Point(574, 570);
                            }
                            else
                            {
                                pcBoxJ3T4.Visible = true;
                                pcBoxJ3T4.BackColor = Color.Black;
                                pcBoxJ3T4.Location = new Point(574, 570 - (51 * 6));
                                pcBoxJ3T4.Visible = true;
                                pcBoxJ3T4.BackColor = Color.Black;
                                pcBoxJ3T4.Location = new Point(574, 570 - (51 * 5));
                                pcBoxJ3T4.Visible = true;
                                pcBoxJ3T4.BackColor = Color.Black;
                                pcBoxJ3T4.Location = new Point(574, 570 - (51 * 4));
                                pcBoxJ3T4.Visible = true;
                                pcBoxJ3T4.BackColor = Color.Black;
                                pcBoxJ3T4.Location = new Point(574, 570 - (51 * 3));
                                pcBoxJ3T4.Visible = true;
                                pcBoxJ3T4.BackColor = Color.Black;
                                pcBoxJ3T4.Location = new Point(574, 570 - (51 * 2));
                                pcBoxJ3T4.Visible = true;
                                pcBoxJ3T4.BackColor = Color.Black;
                                pcBoxJ3T4.Location = new Point(574, 570 - (51));
                                pcBoxJ3T4.Visible = true;
                                pcBoxJ3T4.BackColor = Color.Black;
                                pcBoxJ3T4.Location = new Point(574, 570);
                            }
                        }

                    }

                    //TRILHA 5

                    else if (statustabu.Trilha == 5)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T5.Visible = true;
                                pcBoxJ3T5.BackColor = Color.Green;
                                pcBoxJ3T5.Location = new Point(639, 620);
                            }
                            else
                            {
                                pcBoxJ3T5.Visible = true;
                                pcBoxJ3T5.BackColor = Color.Black;
                                pcBoxJ3T5.Location = new Point(639, 620);
                            }
                        }

                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T5.Visible = true;
                                pcBoxJ3T5.BackColor = Color.Green;
                                pcBoxJ3T5.Location = new Point(639, 620 - 51);
                            }
                            else
                            {
                                pcBoxJ3T5.Visible = true;
                                pcBoxJ3T5.BackColor = Color.Black;
                                pcBoxJ3T5.Location = new Point(639, 620 - 51);
                            }
                        }

                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T5.Visible = true;
                                pcBoxJ3T5.BackColor = Color.Green;
                                pcBoxJ3T5.Location = new Point(639, 620 - (51 * 2));
                            }
                            else
                            {
                                pcBoxJ3T5.Visible = true;
                                pcBoxJ3T5.BackColor = Color.Black;
                                pcBoxJ3T5.Location = new Point(639, 620 - (51 * 2));
                            }
                        }
                        else if (statustabu.Posicao == 4)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T5.Visible = true;
                                pcBoxJ3T5.BackColor = Color.Green;
                                pcBoxJ3T5.Location = new Point(639, 620 - (51 * 3));
                            }
                            else
                            {
                                pcBoxJ3T5.Visible = true;
                                pcBoxJ3T5.BackColor = Color.Black;
                                pcBoxJ3T5.Location = new Point(639, 620 - (51 * 3));
                            }
                        }
                        else if (statustabu.Posicao == 5)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T5.Visible = true;
                                pcBoxJ3T5.BackColor = Color.Green;
                                pcBoxJ3T5.Location = new Point(639, 620 - (51 * 4));
                            }
                            else
                            {
                                pcBoxJ3T5.Visible = true;
                                pcBoxJ3T5.BackColor = Color.Black;
                                pcBoxJ3T5.Location = new Point(639, 620 - (51 * 4));
                            }
                        }
                        else if (statustabu.Posicao == 6)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T5.Visible = true;
                                pcBoxJ3T5.BackColor = Color.Green;
                                pcBoxJ3T5.Location = new Point(639, 620 - (51 * 5));
                            }
                            else
                            {
                                pcBoxJ3T5.Visible = true;
                                pcBoxJ3T5.BackColor = Color.Black;
                                pcBoxJ3T5.Location = new Point(639, 620 - (51 * 5));
                            }
                        }
                        else if (statustabu.Posicao == 7)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T5.Visible = true;
                                pcBoxJ3T5.BackColor = Color.Green;
                                pcBoxJ3T5.Location = new Point(639, 620 - (51 * 6));
                            }
                            else
                            {
                                pcBoxJ3T5.Visible = true;
                                pcBoxJ3T5.BackColor = Color.Black;
                                pcBoxJ3T5.Location = new Point(639, 620 - (51 * 6));
                            }
                        }
                        else if (statustabu.Posicao == 8)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T5.Visible = true;
                                pcBoxJ3T5.BackColor = Color.Green;
                                pcBoxJ3T5.Location = new Point(639, 620 - (51 * 7));
                            }
                            else
                            {
                                pcBoxJ3T5.Visible = true;
                                pcBoxJ3T5.BackColor = Color.Black;
                                pcBoxJ3T5.Location = new Point(639, 620 - (51 * 7));
                            }
                        }
                        else if (statustabu.Posicao == 9)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T5.Visible = true;
                                pcBoxJ3T5.BackColor = Color.Green;
                                pcBoxJ3T5.Location = new Point(639, 620 - (51 * 8));
                                pcBoxJ3T5.Visible = true;
                                pcBoxJ3T5.BackColor = Color.Green;
                                pcBoxJ3T5.Location = new Point(639, 620 - (51 * 7));
                                pcBoxJ3T5.Visible = true;
                                pcBoxJ3T5.BackColor = Color.Green;
                                pcBoxJ3T5.Location = new Point(639, 620 - (51 * 6));
                                pcBoxJ3T5.Visible = true;
                                pcBoxJ3T5.BackColor = Color.Green;
                                pcBoxJ3T5.Location = new Point(639, 620 - (51 * 5));
                                pcBoxJ3T5.Visible = true;
                                pcBoxJ3T5.BackColor = Color.Green;
                                pcBoxJ3T5.Location = new Point(639, 620 - (51 * 4));
                                pcBoxJ3T5.Visible = true;
                                pcBoxJ3T5.BackColor = Color.Green;
                                pcBoxJ3T5.Location = new Point(639, 620 - (51 * 3));
                                pcBoxJ3T5.Visible = true;
                                pcBoxJ3T5.BackColor = Color.Green;
                                pcBoxJ3T5.Location = new Point(639, 620 - (51 * 2));
                                pcBoxJ3T5.Visible = true;
                                pcBoxJ3T5.BackColor = Color.Green;
                                pcBoxJ3T5.Location = new Point(639, 620 - (51));
                                pcBoxJ3T5.Visible = true;
                                pcBoxJ3T5.BackColor = Color.Green;
                                pcBoxJ3T5.Location = new Point(639, 620);
                            }
                            else
                            {
                                pcBoxJ3T5.Visible = true;
                                pcBoxJ3T5.BackColor = Color.Black;
                                pcBoxJ3T5.Location = new Point(639, 620 - (51 * 8));
                                pcBoxJ3T5.Visible = true;
                                pcBoxJ3T5.BackColor = Color.Black;
                                pcBoxJ3T5.Location = new Point(639, 620 - (51 * 7));
                                pcBoxJ3T5.Visible = true;
                                pcBoxJ3T5.BackColor = Color.Black;
                                pcBoxJ3T5.Location = new Point(639, 620 - (51 * 6));
                                pcBoxJ3T5.Visible = true;
                                pcBoxJ3T5.BackColor = Color.Black;
                                pcBoxJ3T5.Location = new Point(639, 620 - (51 * 5));
                                pcBoxJ3T5.Visible = true;
                                pcBoxJ3T5.BackColor = Color.Black;
                                pcBoxJ3T5.Location = new Point(639, 620 - (51 * 4));
                                pcBoxJ3T5.Visible = true;
                                pcBoxJ3T5.BackColor = Color.Black;
                                pcBoxJ3T5.Location = new Point(639, 620 - (51 * 3));
                                pcBoxJ3T5.Visible = true;
                                pcBoxJ3T5.BackColor = Color.Black;
                                pcBoxJ3T5.Location = new Point(639, 620 - (51 * 2));
                                pcBoxJ3T5.Visible = true;
                                pcBoxJ3T5.BackColor = Color.Black;
                                pcBoxJ3T5.Location = new Point(639, 620 - (51));
                                pcBoxJ3T5.Visible = true;
                                pcBoxJ3T5.BackColor = Color.Black;
                                pcBoxJ3T5.Location = new Point(639, 620);
                            }
                        }
                    }

                    //TRILHA 6
                    else if (statustabu.Trilha == 6)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Green;
                                pcBoxJ3T6.Location = new Point(703, 671 );
                            }
                            else
                            {
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Black;
                                pcBoxJ3T6.Location = new Point(703, 671);
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Green;
                                pcBoxJ3T6.Location = new Point(703, 671 - 51);
                            }
                            else
                            {
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Black;
                                pcBoxJ3T6.Location = new Point(703, 671 - 51);
                            }
                        }
                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Green;
                                pcBoxJ3T6.Location = new Point(703, 671 - (51 * 2));
                            }
                            else
                            {
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Black;
                                pcBoxJ3T6.Location = new Point(703, 671 - (51 * 2));
                            }
                        }
                        else if (statustabu.Posicao == 4)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Green;
                                pcBoxJ3T6.Location = new Point(703, 671 - (51 * 3));
                            }
                            else
                            {
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Black;
                                pcBoxJ3T6.Location = new Point(703, 671 - (51 * 3));
                            }
                        }
                        else if (statustabu.Posicao == 5)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Green;
                                pcBoxJ3T6.Location = new Point(703, 671 - (51 * 4));
                            }
                            else
                            {
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Black;
                                pcBoxJ3T6.Location = new Point(703, 671 - (51 * 4));
                            }
                        }
                        else if (statustabu.Posicao == 6)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Green;
                                pcBoxJ3T6.Location = new Point(703, 671 - (51 * 5));
                            }
                            else
                            {
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Black;
                                pcBoxJ3T6.Location = new Point(703, 671 - (51 * 5));
                            }
                        }
                        else if (statustabu.Posicao == 7)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Green;
                                pcBoxJ3T6.Location = new Point(703, 671 - (51 * 6));
                            }
                            else
                            {
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Black;
                                pcBoxJ3T6.Location = new Point(703, 671 - (51 * 6));
                            }
                        }
                        else if (statustabu.Posicao == 8)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Green;
                                pcBoxJ3T6.Location = new Point(703, 671 - (51 * 7));
                            }
                            else
                            {
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Black;
                                pcBoxJ3T6.Location = new Point(703, 671 - (51 * 7));
                            }
                        }
                        else if (statustabu.Posicao == 9)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Green;
                                pcBoxJ3T6.Location = new Point(703, 671 - (51 * 8));
                            }
                            else
                            {
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Black;
                                pcBoxJ3T6.Location = new Point(703, 671 - (51 * 8));
                            }
                        }
                        else if (statustabu.Posicao == 10)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Green;
                                pcBoxJ3T6.Location = new Point(703, 671 - (51 * 9));
                            }
                            else
                            {
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Black;
                                pcBoxJ3T6.Location = new Point(703, 671 - (51 * 9));
                            }
                        }
                        else if (statustabu.Posicao == 11)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Green;
                                pcBoxJ3T6.Location = new Point(703, 671 - (51 * 10));
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Green;
                                pcBoxJ3T6.Location = new Point(703, 671 - (51 * 9));
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Green;
                                pcBoxJ3T6.Location = new Point(703, 671 - (51 * 8));
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Green;
                                pcBoxJ3T6.Location = new Point(703, 671 - (51 * 7));
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Green;
                                pcBoxJ3T6.Location = new Point(703, 671 - (51 * 6));
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Green;
                                pcBoxJ3T6.Location = new Point(703, 671 - (51 * 5));
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Green;
                                pcBoxJ3T6.Location = new Point(703, 671 - (51 * 4));
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Green;
                                pcBoxJ3T6.Location = new Point(703, 671 - (51 * 3));
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Green;
                                pcBoxJ3T6.Location = new Point(703, 671 - (51 * 2));
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Green;
                                pcBoxJ3T6.Location = new Point(703, 671 - (51));
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Green;
                                pcBoxJ3T6.Location = new Point(703, 671);
                            }
                            else
                            {
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Black;
                                pcBoxJ3T6.Location = new Point(703, 671 - (51 * 10));
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Black;
                                pcBoxJ3T6.Location = new Point(703, 671 - (51 * 9));
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Black;
                                pcBoxJ3T6.Location = new Point(703, 671 - (51 * 8));
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Black;
                                pcBoxJ3T6.Location = new Point(703, 671 - (51 * 7));
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Black;
                                pcBoxJ3T6.Location = new Point(703, 671 - (51 * 6));
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Black;
                                pcBoxJ3T6.Location = new Point(703, 671 - (51 * 5));
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Black;
                                pcBoxJ3T6.Location = new Point(703, 671 - (51 * 4));
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Black;
                                pcBoxJ3T6.Location = new Point(703, 671 - (51 * 3));
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Black;
                                pcBoxJ3T6.Location = new Point(703, 671 - (51 * 2));
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Black;
                                pcBoxJ3T6.Location = new Point(703, 671 - (51));
                                pcBoxJ3T6.Visible = true;
                                pcBoxJ3T6.BackColor = Color.Black;
                                pcBoxJ3T6.Location = new Point(703, 671);
                            }
                        }
                    }

                    /// TRILHA 7
                    else if (statustabu.Trilha == 7)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Green;
                                pcBoxJ3T7.Location = new Point(770, 723);
                            }
                            else
                            {
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Black;
                                pcBoxJ3T7.Location = new Point(770, 723);
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Green;
                                pcBoxJ3T7.Location = new Point(770, 723 - 51);
                            }
                            else
                            {
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Black;
                                pcBoxJ3T7.Location = new Point(770, 723 - 51);
                            }
                        }
                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Green;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 2));
                            }
                            else
                            {
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Black;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 2));
                            }
                        }
                        else if (statustabu.Posicao == 4)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Green;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 3));
                            }
                            else
                            {
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Black;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 3));
                            }
                        }
                        else if (statustabu.Posicao == 5)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Green;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 4));
                            }
                            else
                            {
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Black;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 4));
                            }
                        }
                        else if (statustabu.Posicao == 6)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Green;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 5));
                            }
                            else
                            {
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Black;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 5));
                            }
                        }
                        else if (statustabu.Posicao == 7)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Green;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 6));
                            }
                            else
                            {
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Black;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 6));
                            }
                        }
                        else if (statustabu.Posicao == 8)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Green;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 7));
                            }
                            else
                            {
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Black;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 7));
                            }
                        }
                        else if (statustabu.Posicao == 9)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Green;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 8));
                            }
                            else
                            {
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Black;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 8));
                            }
                        }
                        else if (statustabu.Posicao == 10)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Green;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 9));
                            }
                            else
                            {
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Black;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 9));
                            }
                        }
                        else if (statustabu.Posicao == 11)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Green;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 10));
                            }
                            else
                            {
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Black;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 10));
                            }
                        }
                        else if (statustabu.Posicao == 12)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Green;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 11));
                            }
                            else
                            {
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Black;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 11));
                            }
                        }
                        else if (statustabu.Posicao == 13)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Green;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 12));
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Green;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 11));
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Green;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 10));
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Green;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 9));
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Green;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 8));
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Green;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 7));
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Green;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 6));
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Green;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 5));
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Green;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 4));
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Green;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 3));
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Green;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 2));
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Green;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51));
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Green;
                                pcBoxJ3T7.Location = new Point(770, 723);
                            }
                            else
                            {
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Black;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 12));
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Black;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 11));
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Black;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 10));
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Black;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 9));
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Black;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 8));
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Black;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 7));
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Black;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 6));
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Black;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 5));
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Black;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 4));
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Black;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 3));
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Black;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51 * 2));
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Black;
                                pcBoxJ3T7.Location = new Point(770, 723 - (51));
                                pcBoxJ3T7.Visible = true;
                                pcBoxJ3T7.BackColor = Color.Black;
                                pcBoxJ3T7.Location = new Point(770, 723);
                            }
                        }
                    }


                    // TRILHA 8
                    else if (statustabu.Trilha == 8)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Green;
                                pcBoxJ3T8.Location = new Point(836, 671);
                            }
                            else
                            {
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Black;
                                pcBoxJ3T8.Location = new Point(836, 671);
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Green;
                                pcBoxJ3T8.Location = new Point(836, 671 - 51);
                            }
                            else
                            {
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Black;
                                pcBoxJ3T8.Location = new Point(836, 671 - 51);
                            }
                        }
                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Green;
                                pcBoxJ3T8.Location = new Point(836, 671 - (51 * 2));
                            }
                            else
                            {
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Black;
                                pcBoxJ3T8.Location = new Point(836, 671 - (51 * 2));
                            }
                        }
                        else if (statustabu.Posicao == 4)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Green;
                                pcBoxJ3T8.Location = new Point(836, 671 - (51 * 3));
                            }
                            else
                            {
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Black;
                                pcBoxJ3T8.Location = new Point(836, 671 - (51 * 3));
                            }
                        }
                        else if (statustabu.Posicao == 5)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Green;
                                pcBoxJ3T8.Location = new Point(836, 671 - (51 * 4));
                            }
                            else
                            {
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Black;
                                pcBoxJ3T8.Location = new Point(836, 671 - (51 * 4));
                            }
                        }
                        else if (statustabu.Posicao == 6)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Green;
                                pcBoxJ3T8.Location = new Point(836, 671 - (51 * 5));
                            }
                            else
                            {
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Black;
                                pcBoxJ3T8.Location = new Point(836, 671 - (51 * 5));
                            }
                        }
                        else if (statustabu.Posicao == 7)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Green;
                                pcBoxJ3T8.Location = new Point(836, 671 - (51 * 6));
                            }
                            else
                            {
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Black;
                                pcBoxJ3T8.Location = new Point(836, 671 - (51 * 6));
                            }
                        }
                        else if (statustabu.Posicao == 8)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Green;
                                pcBoxJ3T8.Location = new Point(836, 671 - (51 * 7));
                            }
                            else
                            {
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Black;
                                pcBoxJ3T8.Location = new Point(836, 671 - (51 * 7));
                            }
                        }
                        else if (statustabu.Posicao == 9)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Green;
                                pcBoxJ3T8.Location = new Point(836, 671 - (51 * 8));
                            }
                            else
                            {
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Black;
                                pcBoxJ3T8.Location = new Point(836, 671 - (51 * 8));
                            }
                        }
                        else if (statustabu.Posicao == 10)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Green;
                                pcBoxJ3T8.Location = new Point(836, 671 - (51 * 9));
                            }
                            else
                            {
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Black;
                                pcBoxJ3T8.Location = new Point(836, 671 - (51 * 9));
                            }
                        }
                        else if (statustabu.Posicao == 11)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Green;
                                pcBoxJ3T8.Location = new Point(836, 671 - (51 * 10));
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Green;
                                pcBoxJ3T8.Location = new Point(836, 671 - (51 * 9));
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Green;
                                pcBoxJ3T8.Location = new Point(836, 671 - (51 * 8));
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Green;
                                pcBoxJ3T8.Location = new Point(836, 671 - (51 * 7));
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Green;
                                pcBoxJ3T8.Location = new Point(836, 671 - (51 * 6));
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Green;
                                pcBoxJ3T8.Location = new Point(836, 671 - (51 * 5));
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Green;
                                pcBoxJ3T8.Location = new Point(836, 671 - (51 * 4));
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Green;
                                pcBoxJ3T8.Location = new Point(836, 671 - (51 * 3));
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Green;
                                pcBoxJ3T8.Location = new Point(836, 671 - (51 * 2));
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Green;
                                pcBoxJ3T8.Location = new Point(836, 671 - (51));
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Green;
                                pcBoxJ3T8.Location = new Point(836, 671);
                            }
                            else
                            {
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Black;
                                pcBoxJ3T8.Location = new Point(836, 671 - (51 * 10));
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Black;
                                pcBoxJ3T8.Location = new Point(836, 671 - (51 * 9));
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Black;
                                pcBoxJ3T8.Location = new Point(836, 671 - (51 * 8));
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Black;
                                pcBoxJ3T8.Location = new Point(836, 671 - (51 * 7));
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Black;
                                pcBoxJ3T8.Location = new Point(836, 671 - (51 * 6));
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Black;
                                pcBoxJ3T8.Location = new Point(836, 671 - (51 * 5));
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Black;
                                pcBoxJ3T8.Location = new Point(836, 671 - (51 * 4));
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Black;
                                pcBoxJ3T8.Location = new Point(836, 671 - (51 * 3));
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Black;
                                pcBoxJ3T8.Location = new Point(836, 671 - (51 * 2));
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Black;
                                pcBoxJ3T8.Location = new Point(836, 671 - (51));
                                pcBoxJ3T8.Visible = true;
                                pcBoxJ3T8.BackColor = Color.Black;
                                pcBoxJ3T8.Location = new Point(836, 671);
                            }
                        }
                    }
                    //TRILHA 9
                    else if (statustabu.Trilha == 9)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T9.Visible = true;
                                pcBoxJ3T9.BackColor = Color.Green;
                                pcBoxJ3T9.Location = new Point(897, 618 );
                            }
                            else
                            {
                                pcBoxJ3T9.Visible = true;
                                pcBoxJ3T9.BackColor = Color.Black;
                                pcBoxJ3T9.Location = new Point(897, 618);
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T9.Visible = true;
                                pcBoxJ3T9.BackColor = Color.Green;
                                pcBoxJ3T9.Location = new Point(897, 618 - 51);
                            }
                            else
                            {
                                pcBoxJ3T9.Visible = true;
                                pcBoxJ3T9.BackColor = Color.Black;
                                pcBoxJ3T9.Location = new Point(897, 618 - 51);
                            }
                        }
                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T9.Visible = true;
                                pcBoxJ3T9.BackColor = Color.Green;
                                pcBoxJ3T9.Location = new Point(897, 618 - (51 * 2));
                            }
                            else
                            {
                                pcBoxJ3T9.Visible = true;
                                pcBoxJ3T9.BackColor = Color.Black;
                                pcBoxJ3T9.Location = new Point(897, 618 - (51 * 2));
                            }
                        }
                        else if (statustabu.Posicao == 4)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T9.Visible = true;
                                pcBoxJ3T9.BackColor = Color.Green;
                                pcBoxJ3T9.Location = new Point(897, 618 - (51 * 3));
                            }
                            else
                            {
                                pcBoxJ3T9.Visible = true;
                                pcBoxJ3T9.BackColor = Color.Black;
                                pcBoxJ3T9.Location = new Point(897, 618 - (51 * 3));
                            }
                        }
                        else if (statustabu.Posicao == 5)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T9.Visible = true;
                                pcBoxJ3T9.BackColor = Color.Green;
                                pcBoxJ3T9.Location = new Point(897, 618 - (51 * 4));
                            }
                            else
                            {
                                pcBoxJ3T9.Visible = true;
                                pcBoxJ3T9.BackColor = Color.Black;
                                pcBoxJ3T9.Location = new Point(897, 618 - (51 * 4));
                            }
                        }
                        else if (statustabu.Posicao == 6)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T9.Visible = true;
                                pcBoxJ3T9.BackColor = Color.Green;
                                pcBoxJ3T9.Location = new Point(897, 618 - (51 * 5));
                            }
                            else
                            {
                                pcBoxJ3T9.Visible = true;
                                pcBoxJ3T9.BackColor = Color.Black;
                                pcBoxJ3T9.Location = new Point(897, 618 - (51 * 5));
                            }
                        }
                        else if (statustabu.Posicao == 7)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T9.Visible = true;
                                pcBoxJ3T9.BackColor = Color.Green;
                                pcBoxJ3T9.Location = new Point(897, 618 - (51 * 6));
                            }
                            else
                            {
                                pcBoxJ3T9.Visible = true;
                                pcBoxJ3T9.BackColor = Color.Black;
                                pcBoxJ3T9.Location = new Point(897, 618 - (51 * 6));
                            }
                        }
                        else if (statustabu.Posicao == 8)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T9.Visible = true;
                                pcBoxJ3T9.BackColor = Color.Green;
                                pcBoxJ3T9.Location = new Point(897, 618 - (51 * 7));
                            }
                            else
                            {
                                pcBoxJ3T9.Visible = true;
                                pcBoxJ3T9.BackColor = Color.Black;
                                pcBoxJ3T9.Location = new Point(897, 618 - (51 * 7));
                            }
                        }
                        else if (statustabu.Posicao == 9)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T9.Visible = true;
                                pcBoxJ3T9.BackColor = Color.Green;
                                pcBoxJ3T9.Location = new Point(897, 618 - (51 * 8));
                                pcBoxJ3T9.Visible = true;
                                pcBoxJ3T9.BackColor = Color.Green;
                                pcBoxJ3T9.Location = new Point(897, 618 - (51 * 7));
                                pcBoxJ3T9.Visible = true;
                                pcBoxJ3T9.BackColor = Color.Green;
                                pcBoxJ3T9.Location = new Point(897, 618 - (51 * 6));
                                pcBoxJ3T9.Visible = true;
                                pcBoxJ3T9.BackColor = Color.Green;
                                pcBoxJ3T9.Location = new Point(897, 618 - (51 * 5));
                                pcBoxJ3T9.Visible = true;
                                pcBoxJ3T9.BackColor = Color.Green;
                                pcBoxJ3T9.Location = new Point(897, 618 - (51 * 4));
                                pcBoxJ3T9.Visible = true;
                                pcBoxJ3T9.BackColor = Color.Green;
                                pcBoxJ3T9.Location = new Point(897, 618 - (51 * 3));
                                pcBoxJ3T9.Visible = true;
                                pcBoxJ3T9.BackColor = Color.Green;
                                pcBoxJ3T9.Location = new Point(897, 618 - (51 * 2));
                                pcBoxJ3T9.Visible = true;
                                pcBoxJ3T9.BackColor = Color.Green;
                                pcBoxJ3T9.Location = new Point(897, 618 - (51));
                                pcBoxJ3T9.Visible = true;
                                pcBoxJ3T9.BackColor = Color.Green;
                                pcBoxJ3T9.Location = new Point(897, 618);
                            }
                            else
                            {
                                pcBoxJ3T9.Visible = true;
                                pcBoxJ3T9.BackColor = Color.Black;
                                pcBoxJ3T9.Location = new Point(897, 618 - (51 * 8));
                                pcBoxJ3T9.Visible = true;
                                pcBoxJ3T9.BackColor = Color.Black;
                                pcBoxJ3T9.Location = new Point(897, 618 - (51 * 7));
                                pcBoxJ3T9.Visible = true;
                                pcBoxJ3T9.BackColor = Color.Black;
                                pcBoxJ3T9.Location = new Point(897, 618 - (51 * 6));
                                pcBoxJ3T9.Visible = true;
                                pcBoxJ3T9.BackColor = Color.Black;
                                pcBoxJ3T9.Location = new Point(897, 618 - (51 * 5));
                                pcBoxJ3T9.Visible = true;
                                pcBoxJ3T9.BackColor = Color.Black;
                                pcBoxJ3T9.Location = new Point(897, 618 - (51 * 4));
                                pcBoxJ3T9.Visible = true;
                                pcBoxJ3T9.BackColor = Color.Black;
                                pcBoxJ3T9.Location = new Point(897, 618 - (51 * 3));
                                pcBoxJ3T9.Visible = true;
                                pcBoxJ3T9.BackColor = Color.Black;
                                pcBoxJ3T9.Location = new Point(897, 618 - (51 * 2));
                                pcBoxJ3T9.Visible = true;
                                pcBoxJ3T9.BackColor = Color.Black;
                                pcBoxJ3T9.Location = new Point(897, 618 - (51));
                                pcBoxJ3T9.Visible = true;
                                pcBoxJ3T9.BackColor = Color.Black;
                                pcBoxJ3T9.Location = new Point(897, 618);
                            }
                        }
                    }
                    //TRILHA 10
                    else if (statustabu.Trilha == 10)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T10.Visible = true;
                                pcBoxJ3T10.BackColor = Color.Green;
                                pcBoxJ3T10.Location = new Point(966, 572);
                            }
                            else
                            {
                                pcBoxJ3T10.Visible = true;
                                pcBoxJ3T10.BackColor = Color.Black;
                                pcBoxJ3T10.Location = new Point(966, 572);
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T10.Visible = true;
                                pcBoxJ3T10.BackColor = Color.Green;
                                pcBoxJ3T10.Location = new Point(966, 572 - 51);
                            }
                            else
                            {
                                pcBoxJ3T10.Visible = true;
                                pcBoxJ3T10.BackColor = Color.Black;
                                pcBoxJ3T10.Location = new Point(966, 572 - 51);
                            }
                        }
                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T10.Visible = true;
                                pcBoxJ3T10.BackColor = Color.Green;
                                pcBoxJ3T10.Location = new Point(966, 572 - (51 * 2));
                            }
                            else
                            {
                                pcBoxJ3T10.Visible = true;
                                pcBoxJ3T10.BackColor = Color.Black;
                                pcBoxJ3T10.Location = new Point(966, 572 - (51 * 2));
                            }
                        }
                        else if (statustabu.Posicao == 4)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T10.Visible = true;
                                pcBoxJ3T10.BackColor = Color.Green;
                                pcBoxJ3T10.Location = new Point(966, 572 - (51 * 3));
                            }
                            else
                            {
                                pcBoxJ3T10.Visible = true;
                                pcBoxJ3T10.BackColor = Color.Black;
                                pcBoxJ3T10.Location = new Point(966, 572 - (51 * 3));
                            }
                        }
                        else if (statustabu.Posicao == 5)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T10.Visible = true;
                                pcBoxJ3T10.BackColor = Color.Green;
                                pcBoxJ3T10.Location = new Point(966, 572 - (51 * 4));
                            }
                            else
                            {
                                pcBoxJ3T10.Visible = true;
                                pcBoxJ3T10.BackColor = Color.Black;
                                pcBoxJ3T10.Location = new Point(966, 572 - (51 * 4));
                            }
                        }
                        else if (statustabu.Posicao == 6)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T10.Visible = true;
                                pcBoxJ3T10.BackColor = Color.Green;
                                pcBoxJ3T10.Location = new Point(966, 572 - (51 * 5));
                            }
                            else
                            {
                                pcBoxJ3T10.Visible = true;
                                pcBoxJ3T10.BackColor = Color.Black;
                                pcBoxJ3T10.Location = new Point(966, 572 - (51 * 5));
                            }
                        }
                        else if (statustabu.Posicao == 7)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T10.Visible = true;
                                pcBoxJ3T10.BackColor = Color.Green;
                                pcBoxJ3T10.Location = new Point(966, 572 - (51 * 6));
                                pcBoxJ3T10.Visible = true;
                                pcBoxJ3T10.BackColor = Color.Green;
                                pcBoxJ3T10.Location = new Point(966, 572 - (51 * 5));
                                pcBoxJ3T10.Visible = true;
                                pcBoxJ3T10.BackColor = Color.Green;
                                pcBoxJ3T10.Location = new Point(966, 572 - (51 * 4));
                                pcBoxJ3T10.Visible = true;
                                pcBoxJ3T10.BackColor = Color.Green;
                                pcBoxJ3T10.Location = new Point(966, 572 - (51 * 3));
                                pcBoxJ3T10.Visible = true;
                                pcBoxJ3T10.BackColor = Color.Green;
                                pcBoxJ3T10.Location = new Point(966, 572 - (51 * 2));
                                pcBoxJ3T10.Visible = true;
                                pcBoxJ3T10.BackColor = Color.Green;
                                pcBoxJ3T10.Location = new Point(966, 572 - (51));
                                pcBoxJ3T10.Visible = true;
                                pcBoxJ3T10.BackColor = Color.Green;
                                pcBoxJ3T10.Location = new Point(966, 572);
                            }
                            else
                            {
                                pcBoxJ3T10.Visible = true;
                                pcBoxJ3T10.BackColor = Color.Black;
                                pcBoxJ3T10.Location = new Point(966, 572 - (51 * 6));
                                pcBoxJ3T10.Visible = true;
                                pcBoxJ3T10.BackColor = Color.Black;
                                pcBoxJ3T10.Location = new Point(966, 572 - (51 * 5));
                                pcBoxJ3T10.Visible = true;
                                pcBoxJ3T10.BackColor = Color.Black;
                                pcBoxJ3T10.Location = new Point(966, 572 - (51 * 4));
                                pcBoxJ3T10.Visible = true;
                                pcBoxJ3T10.BackColor = Color.Black;
                                pcBoxJ3T10.Location = new Point(966, 572 - (51 * 3));
                                pcBoxJ3T10.Visible = true;
                                pcBoxJ3T10.BackColor = Color.Black;
                                pcBoxJ3T10.Location = new Point(966, 572 - (51 * 2));
                                pcBoxJ3T10.Visible = true;
                                pcBoxJ3T10.BackColor = Color.Black;
                                pcBoxJ3T10.Location = new Point(966, 572 - (51));
                                pcBoxJ3T10.Visible = true;
                                pcBoxJ3T10.BackColor = Color.Black;
                                pcBoxJ3T10.Location = new Point(966, 572);
                            }
                        }
                    }

                    //TRILHA 11
                    else if (statustabu.Trilha == 11)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T11.Visible = true;
                                pcBoxJ3T11.BackColor = Color.Green;
                                pcBoxJ3T11.Location = new Point(1036, 518 );
                            }
                            else
                            {
                                pcBoxJ3T11.Visible = true;
                                pcBoxJ3T11.BackColor = Color.Black;
                                pcBoxJ3T11.Location = new Point(1036, 518);
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T11.Visible = true;
                                pcBoxJ3T11.BackColor = Color.Green;
                                pcBoxJ3T11.Location = new Point(1036, 518 - 51);
                            }
                            else
                            {
                                pcBoxJ3T11.Visible = true;
                                pcBoxJ3T11.BackColor = Color.Black;
                                pcBoxJ3T11.Location = new Point(1036, 518 - 51);
                            }
                        }
                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T11.Visible = true;
                                pcBoxJ3T11.BackColor = Color.Green;
                                pcBoxJ3T11.Location = new Point(1036, 518 - (51 * 2));
                            }
                            else
                            {
                                pcBoxJ3T11.Visible = true;
                                pcBoxJ3T11.BackColor = Color.Black;
                                pcBoxJ3T11.Location = new Point(1036, 518 - (51 * 2));
                            }
                        }
                        else if (statustabu.Posicao == 4)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T11.Visible = true;
                                pcBoxJ3T11.BackColor = Color.Green;
                                pcBoxJ3T11.Location = new Point(1036, 518 - (51 * 3));
                            }
                            else
                            {
                                pcBoxJ3T11.Visible = true;
                                pcBoxJ3T11.BackColor = Color.Black;
                                pcBoxJ3T11.Location = new Point(1036, 518 - (51 * 3));
                            }
                        }
                        else if (statustabu.Posicao == 5)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T11.Visible = true;
                                pcBoxJ3T11.BackColor = Color.Green;
                                pcBoxJ3T11.Location = new Point(1036, 518 - (51 * 4));
                                pcBoxJ3T11.Visible = true;
                                pcBoxJ3T11.BackColor = Color.Green;
                                pcBoxJ3T11.Location = new Point(1036, 518 - (51 * 3));
                                pcBoxJ3T11.Visible = true;
                                pcBoxJ3T11.BackColor = Color.Green;
                                pcBoxJ3T11.Location = new Point(1036, 518 - (51 * 2));
                                pcBoxJ3T11.Visible = true;
                                pcBoxJ3T11.BackColor = Color.Green;
                                pcBoxJ3T11.Location = new Point(1036, 518 - (51));
                                pcBoxJ3T11.Visible = true;
                                pcBoxJ3T11.BackColor = Color.Green;
                                pcBoxJ3T11.Location = new Point(1036, 518);
                            }
                            else
                            {
                                pcBoxJ3T11.Visible = true;
                                pcBoxJ3T11.BackColor = Color.Black;
                                pcBoxJ3T11.Location = new Point(1036, 518 - (51 * 4));
                                pcBoxJ3T11.Visible = true;
                                pcBoxJ3T11.BackColor = Color.Black;
                                pcBoxJ3T11.Location = new Point(1036, 518 - (51 * 3));
                                pcBoxJ3T11.Visible = true;
                                pcBoxJ3T11.BackColor = Color.Black;
                                pcBoxJ3T11.Location = new Point(1036, 518 - (51 * 2));
                                pcBoxJ3T11.Visible = true;
                                pcBoxJ3T11.BackColor = Color.Black;
                                pcBoxJ3T11.Location = new Point(1036, 518 - (51));
                                pcBoxJ3T11.Visible = true;
                                pcBoxJ3T11.BackColor = Color.Black;
                                pcBoxJ3T11.Location = new Point(1036, 518);
                            }
                        }
                    }

                    //TRILHA 12
                    else if (statustabu.Trilha == 12)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T12.Visible = true;
                                pcBoxJ3T12.BackColor = Color.Green;
                                pcBoxJ3T12.Location = new Point(1097, 470 );
                            }
                            else
                            {
                                pcBoxJ3T12.Visible = true;
                                pcBoxJ3T12.BackColor = Color.Black;
                                pcBoxJ3T12.Location = new Point(1097, 470);
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T12.Visible = true;
                                pcBoxJ3T12.BackColor = Color.Green;
                                pcBoxJ3T12.Location = new Point(1097, 470 - 51);
                            }
                            else
                            {
                                pcBoxJ3T12.Visible = true;
                                pcBoxJ3T12.BackColor = Color.Black;
                                pcBoxJ3T12.Location = new Point(1097, 470 - 51);
                            }
                        }
                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ3T12.Visible = true;
                                pcBoxJ3T12.BackColor = Color.Green;
                                pcBoxJ3T12.Location = new Point(1097, 470 - (51 * 2));
                                pcBoxJ3T12.Visible = true;
                                pcBoxJ3T12.BackColor = Color.Green;
                                pcBoxJ3T12.Location = new Point(1097, 470 - (51));
                                pcBoxJ3T12.Visible = true;
                                pcBoxJ3T12.BackColor = Color.Green;
                                pcBoxJ3T12.Location = new Point(1097, 470);
                            }
                            else
                            {
                                pcBoxJ3T12.Visible = true;
                                pcBoxJ3T12.BackColor = Color.Black;
                                pcBoxJ3T12.Location = new Point(1097, 470 - (51 * 2));
                                pcBoxJ3T12.Visible = true;
                                pcBoxJ3T12.BackColor = Color.Black;
                                pcBoxJ3T12.Location = new Point(1097, 470 - (51));
                                pcBoxJ3T12.Visible = true;
                                pcBoxJ3T12.BackColor = Color.Black;
                                pcBoxJ3T12.Location = new Point(1097, 470);
                            }
                        }
                    }

                }


                ////////////////////////    JOGADOR 4 ///////////////


                else if (statustabu.idJogador == Convert.ToInt32(jogadorId[0]) + 3)
                {
                    //TRILHA 2
                    if (statustabu.Trilha == 2)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T2.Visible = true;
                                pcBoxJ4T2.BackColor = Color.Yellow;
                                pcBoxJ4T2.Location = new Point(466, 471);
                            }
                            else
                            {
                                pcBoxJ4T2.Visible = true;
                                pcBoxJ4T2.BackColor = Color.Black;
                                pcBoxJ4T2.Location = new Point(466, 471);
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T2.Visible = true;
                                pcBoxJ4T2.BackColor = Color.Yellow;
                                pcBoxJ4T2.Location = new Point(466, 471 - 51);
                            }
                            else
                            {
                                pcBoxJ4T2.Visible = true;
                                pcBoxJ4T2.BackColor = Color.Black;
                                pcBoxJ4T2.Location = new Point(466, 471 - 51);
                            }
                        }
                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T2.Visible = true;
                                pcBoxJ4T2.BackColor = Color.Yellow;
                                pcBoxJ4T2.Location = new Point(466, 471 - (51 * 2));
                                pcBoxJ4T2.Visible = true;
                                pcBoxJ4T2.BackColor = Color.Yellow;
                                pcBoxJ4T2.Location = new Point(466, 471 - (51));
                                pcBoxJ4T2.Visible = true;
                                pcBoxJ4T2.BackColor = Color.Yellow;
                                pcBoxJ4T2.Location = new Point(466, 471);
                            }
                            else
                            {
                                pcBoxJ4T2.Visible = true;
                                pcBoxJ4T2.BackColor = Color.Black;
                                pcBoxJ4T2.Location = new Point(466, 471 - (51 * 2));
                                pcBoxJ4T2.Visible = true;
                                pcBoxJ4T2.BackColor = Color.Black;
                                pcBoxJ4T2.Location = new Point(466, 471 - (51));
                                pcBoxJ4T2.Visible = true;
                                pcBoxJ4T2.BackColor = Color.Black;
                                pcBoxJ4T2.Location = new Point(466, 471);
                            }
                        }
                    }


                    //TRILHA 3

                    else if (statustabu.Trilha == 3)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T3.Visible = true;
                                pcBoxJ4T3.BackColor = Color.Yellow;
                                pcBoxJ4T3.Location = new Point(526, 521);
                            }
                            else
                            {
                                pcBoxJ4T3.Visible = true;
                                pcBoxJ4T3.BackColor = Color.Black;
                                pcBoxJ4T3.Location = new Point(526, 521);
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T3.Visible = true;
                                pcBoxJ4T3.BackColor = Color.Yellow;
                                pcBoxJ4T3.Location = new Point(526, 521 - (51 * 1));
                            }
                            else
                            {
                                pcBoxJ4T3.Visible = true;
                                pcBoxJ4T3.BackColor = Color.Black;
                                pcBoxJ4T3.Location = new Point(526, 521 - (51 * 1));
                            }
                        }
                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T3.Visible = true;
                                pcBoxJ4T3.BackColor = Color.Yellow;
                                pcBoxJ4T3.Location = new Point(526, 521 - (51 * 2));
                            }
                            else
                            {
                                pcBoxJ4T3.Visible = true;
                                pcBoxJ4T3.BackColor = Color.Black;
                                pcBoxJ4T3.Location = new Point(526, 521 - (51 * 2));
                            }
                        }
                        else if (statustabu.Posicao == 4)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T3.Visible = true;
                                pcBoxJ4T3.BackColor = Color.Yellow;
                                pcBoxJ4T3.Location = new Point(526, 521 - (51 * 3));
                            }
                            else
                            {
                                pcBoxJ4T3.Visible = true;
                                pcBoxJ4T3.BackColor = Color.Black;
                                pcBoxJ4T3.Location = new Point(526, 521 - (51 * 3));
                            }
                        }
                        else if (statustabu.Posicao == 5)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T3.Visible = true;
                                pcBoxJ4T3.BackColor = Color.Yellow;
                                pcBoxJ4T3.Location = new Point(526, 521 - (51 * 4));
                                pcBoxJ4T3.Visible = true;
                                pcBoxJ4T3.BackColor = Color.Yellow;
                                pcBoxJ4T3.Location = new Point(526, 521 - (51 * 3));
                                pcBoxJ4T3.Visible = true;
                                pcBoxJ4T3.BackColor = Color.Yellow;
                                pcBoxJ4T3.Location = new Point(526, 521 - (51 * 2));
                                pcBoxJ4T3.Visible = true;
                                pcBoxJ4T3.BackColor = Color.Yellow;
                                pcBoxJ4T3.Location = new Point(526, 521 - (51));
                                pcBoxJ4T3.Visible = true;
                                pcBoxJ4T3.BackColor = Color.Yellow;
                                pcBoxJ4T3.Location = new Point(526, 521);
                            }
                            else
                            {
                                pcBoxJ4T3.Visible = true;
                                pcBoxJ4T3.BackColor = Color.Black;
                                pcBoxJ4T3.Location = new Point(526, 521 - (51 * 4));
                                pcBoxJ4T3.Visible = true;
                                pcBoxJ4T3.BackColor = Color.Black;
                                pcBoxJ4T3.Location = new Point(526, 521 - (51 * 3));
                                pcBoxJ4T3.Visible = true;
                                pcBoxJ4T3.BackColor = Color.Black;
                                pcBoxJ4T3.Location = new Point(526, 521 - (51 * 2));
                                pcBoxJ4T3.Visible = true;
                                pcBoxJ4T3.BackColor = Color.Black;
                                pcBoxJ4T3.Location = new Point(526, 521 - (51));
                                pcBoxJ4T3.Visible = true;
                                pcBoxJ4T3.BackColor = Color.Black;
                                pcBoxJ4T3.Location = new Point(526, 521);
                            }
                        }

                    }

                    // TRILHA 4
                    else if (statustabu.Trilha == 4)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T4.Visible = true;
                                pcBoxJ4T4.BackColor = Color.Yellow;
                                pcBoxJ4T4.Location = new Point(594, 570);
                            }
                            else
                            {
                                pcBoxJ4T4.Visible = true;
                                pcBoxJ4T4.BackColor = Color.Black;
                                pcBoxJ4T4.Location = new Point(594, 570);
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {

                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T4.Visible = true;
                                pcBoxJ4T4.BackColor = Color.Yellow;
                                pcBoxJ4T4.Location = new Point(594, 570 - 51);
                            }
                            else
                            {
                                pcBoxJ4T4.Visible = true;
                                pcBoxJ4T4.BackColor = Color.Black;
                                pcBoxJ4T4.Location = new Point(594, 570 - 51);
                            }

                        }
                        else if (statustabu.Posicao == 3)
                        {

                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T4.Visible = true;
                                pcBoxJ4T4.BackColor = Color.Yellow;
                                pcBoxJ4T4.Location = new Point(594, 570 - (51 * 2));
                            }
                            else
                            {
                                pcBoxJ4T4.Visible = true;
                                pcBoxJ4T4.BackColor = Color.Black;
                                pcBoxJ4T4.Location = new Point(594, 570 - (51 * 2));
                            }
                        }
                        else if (statustabu.Posicao == 4)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T4.Visible = true;
                                pcBoxJ4T4.BackColor = Color.Yellow;
                                pcBoxJ4T4.Location = new Point(594, 570 - (51 * 3));
                            }
                            else
                            {
                                pcBoxJ4T4.Visible = true;
                                pcBoxJ4T4.BackColor = Color.Black;
                                pcBoxJ4T4.Location = new Point(594, 570 - (51 * 3));
                            }
                        }
                        else if (statustabu.Posicao == 5)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T4.Visible = true;
                                pcBoxJ4T4.BackColor = Color.Yellow;
                                pcBoxJ4T4.Location = new Point(594, 570 - (51 * 4));
                            }
                            else
                            {
                                pcBoxJ4T4.Visible = true;
                                pcBoxJ4T4.BackColor = Color.Black;
                                pcBoxJ4T4.Location = new Point(594, 570 - (51 * 4));
                            }
                        }
                        else if (statustabu.Posicao == 6)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T4.Visible = true;
                                pcBoxJ4T4.BackColor = Color.Yellow;
                                pcBoxJ4T4.Location = new Point(594, 570 - (51 * 5));
                            }
                            else
                            {
                                pcBoxJ4T4.Visible = true;
                                pcBoxJ4T4.BackColor = Color.Black;
                                pcBoxJ4T4.Location = new Point(594, 570 - (51 * 5));
                            }
                        }
                        else if (statustabu.Posicao == 7)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T4.Visible = true;
                                pcBoxJ4T4.BackColor = Color.Yellow;
                                pcBoxJ4T4.Location = new Point(594, 570 - (51 * 6));
                                pcBoxJ4T4.BackColor = Color.Yellow;
                                pcBoxJ4T4.Location = new Point(594, 570 - (51 * 5));
                                pcBoxJ4T4.Visible = true;
                                pcBoxJ4T4.BackColor = Color.Yellow;
                                pcBoxJ4T4.Location = new Point(594, 570 - (51 * 4));
                                pcBoxJ4T4.Visible = true;
                                pcBoxJ4T4.BackColor = Color.Yellow;
                                pcBoxJ4T4.Location = new Point(594, 570 - (51 * 3));
                                pcBoxJ4T4.Visible = true;
                                pcBoxJ4T4.BackColor = Color.Yellow;
                                pcBoxJ4T4.Location = new Point(594, 570 - (51 * 2));
                                pcBoxJ4T4.Visible = true;
                                pcBoxJ4T4.BackColor = Color.Yellow;
                                pcBoxJ4T4.Location = new Point(594, 570 - (51));
                                pcBoxJ4T4.Visible = true;
                                pcBoxJ4T4.BackColor = Color.Yellow;
                                pcBoxJ4T4.Location = new Point(594, 570);
                            }
                            else
                            {
                                pcBoxJ4T4.Visible = true;
                                pcBoxJ4T4.BackColor = Color.Black;
                                pcBoxJ4T4.Location = new Point(594, 570 - (51 * 6));
                                pcBoxJ4T4.Visible = true;
                                pcBoxJ4T4.BackColor = Color.Black;
                                pcBoxJ4T4.Location = new Point(594, 570 - (51 * 5));
                                pcBoxJ4T4.Visible = true;
                                pcBoxJ4T4.BackColor = Color.Black;
                                pcBoxJ4T4.Location = new Point(594, 570 - (51 * 4));
                                pcBoxJ4T4.Visible = true;
                                pcBoxJ4T4.BackColor = Color.Black;
                                pcBoxJ4T4.Location = new Point(594, 570 - (51 * 3));
                                pcBoxJ4T4.Visible = true;
                                pcBoxJ4T4.BackColor = Color.Black;
                                pcBoxJ4T4.Location = new Point(594, 570 - (51 * 2));
                                pcBoxJ4T4.Visible = true;
                                pcBoxJ4T4.BackColor = Color.Black;
                                pcBoxJ4T4.Location = new Point(594, 570 - (51));
                                pcBoxJ4T4.Visible = true;
                                pcBoxJ4T4.BackColor = Color.Black;
                                pcBoxJ4T4.Location = new Point(594, 570);
                            }
                        }

                    }

                    //TRILHA 5

                    else if (statustabu.Trilha == 5)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T5.Visible = true;
                                pcBoxJ4T5.BackColor = Color.Yellow;
                                pcBoxJ4T5.Location = new Point(659, 620);
                            }
                            else
                            {
                                pcBoxJ4T5.Visible = true;
                                pcBoxJ4T5.BackColor = Color.Black;
                                pcBoxJ4T5.Location = new Point(659, 620);
                            }
                        }

                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T5.Visible = true;
                                pcBoxJ4T5.BackColor = Color.Yellow;
                                pcBoxJ4T5.Location = new Point(659, 620 - 51);
                            }
                            else
                            {
                                pcBoxJ4T5.Visible = true;
                                pcBoxJ4T5.BackColor = Color.Black;
                                pcBoxJ4T5.Location = new Point(659, 620 - 51);
                            }
                        }

                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T5.Visible = true;
                                pcBoxJ4T5.BackColor = Color.Yellow;
                                pcBoxJ4T5.Location = new Point(659, 620 - (51 * 2));
                            }
                            else
                            {
                                pcBoxJ4T5.Visible = true;
                                pcBoxJ4T5.BackColor = Color.Black;
                                pcBoxJ4T5.Location = new Point(659, 620 - (51 * 2));
                            }
                        }
                        else if (statustabu.Posicao == 4)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T5.Visible = true;
                                pcBoxJ4T5.BackColor = Color.Yellow;
                                pcBoxJ4T5.Location = new Point(659, 620 - (51 * 3));
                            }
                            else
                            {
                                pcBoxJ4T5.Visible = true;
                                pcBoxJ4T5.BackColor = Color.Black;
                                pcBoxJ4T5.Location = new Point(659, 620 - (51 * 3));
                            }
                        }
                        else if (statustabu.Posicao == 5)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T5.Visible = true;
                                pcBoxJ4T5.BackColor = Color.Yellow;
                                pcBoxJ4T5.Location = new Point(659, 620 - (51 * 4));
                            }
                            else
                            {
                                pcBoxJ4T5.Visible = true;
                                pcBoxJ4T5.BackColor = Color.Black;
                                pcBoxJ4T5.Location = new Point(659, 620 - (51 * 4));
                            }
                        }
                        else if (statustabu.Posicao == 6)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T5.Visible = true;
                                pcBoxJ4T5.BackColor = Color.Yellow;
                                pcBoxJ4T5.Location = new Point(659, 620 - (51 * 5));
                            }
                            else
                            {
                                pcBoxJ4T5.Visible = true;
                                pcBoxJ4T5.BackColor = Color.Black;
                                pcBoxJ4T5.Location = new Point(659, 620 - (51 * 5));
                            }
                        }
                        else if (statustabu.Posicao == 7)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T5.Visible = true;
                                pcBoxJ4T5.BackColor = Color.Yellow;
                                pcBoxJ4T5.Location = new Point(659, 620 - (51 * 6));
                            }
                            else
                            {
                                pcBoxJ4T5.Visible = true;
                                pcBoxJ4T5.BackColor = Color.Black;
                                pcBoxJ4T5.Location = new Point(659, 620 - (51 * 6));
                            }
                        }
                        else if (statustabu.Posicao == 8)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T5.Visible = true;
                                pcBoxJ4T5.BackColor = Color.Yellow;
                                pcBoxJ4T5.Location = new Point(659, 620 - (51 * 7));
                            }
                            else
                            {
                                pcBoxJ4T5.Visible = true;
                                pcBoxJ4T5.BackColor = Color.Black;
                                pcBoxJ4T5.Location = new Point(659, 620 - (51 * 7));
                            }
                        }
                        else if (statustabu.Posicao == 9)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T5.Visible = true;
                                pcBoxJ4T5.BackColor = Color.Yellow;
                                pcBoxJ4T5.Location = new Point(659, 620 - (51 * 8));
                                pcBoxJ4T5.Visible = true;
                                pcBoxJ4T5.BackColor = Color.Yellow;
                                pcBoxJ4T5.Location = new Point(659, 620 - (51 * 7));
                                pcBoxJ4T5.Visible = true;
                                pcBoxJ4T5.BackColor = Color.Yellow;
                                pcBoxJ4T5.Location = new Point(659, 620 - (51 * 6));
                                pcBoxJ4T5.Visible = true;
                                pcBoxJ4T5.BackColor = Color.Yellow;
                                pcBoxJ4T5.Location = new Point(659, 620 - (51 * 5));
                                pcBoxJ4T5.Visible = true;
                                pcBoxJ4T5.BackColor = Color.Yellow;
                                pcBoxJ4T5.Location = new Point(659, 620 - (51 * 4));
                                pcBoxJ4T5.Visible = true;
                                pcBoxJ4T5.BackColor = Color.Yellow;
                                pcBoxJ4T5.Location = new Point(659, 620 - (51 * 3));
                                pcBoxJ4T5.Visible = true;
                                pcBoxJ4T5.BackColor = Color.Yellow;
                                pcBoxJ4T5.Location = new Point(659, 620 - (51 * 2));
                                pcBoxJ4T5.Visible = true;
                                pcBoxJ4T5.BackColor = Color.Yellow;
                                pcBoxJ4T5.Location = new Point(659, 620 - (51));
                                pcBoxJ4T5.Visible = true;
                                pcBoxJ4T5.BackColor = Color.Yellow;
                                pcBoxJ4T5.Location = new Point(659, 620);
                            }
                            else
                            {
                                pcBoxJ4T5.Visible = true;
                                pcBoxJ4T5.BackColor = Color.Black;
                                pcBoxJ4T5.Location = new Point(659, 620 - (51 * 8));
                                pcBoxJ4T5.Visible = true;
                                pcBoxJ4T5.BackColor = Color.Black;
                                pcBoxJ4T5.Location = new Point(659, 620 - (51 * 7));
                                pcBoxJ4T5.Visible = true;
                                pcBoxJ4T5.BackColor = Color.Black;
                                pcBoxJ4T5.Location = new Point(659, 620 - (51 * 6));
                                pcBoxJ4T5.Visible = true;
                                pcBoxJ4T5.BackColor = Color.Black;
                                pcBoxJ4T5.Location = new Point(659, 620 - (51 * 5));
                                pcBoxJ4T5.Visible = true;
                                pcBoxJ4T5.BackColor = Color.Black;
                                pcBoxJ4T5.Location = new Point(659, 620 - (51 * 4));
                                pcBoxJ4T5.Visible = true;
                                pcBoxJ4T5.BackColor = Color.Black;
                                pcBoxJ4T5.Location = new Point(659, 620 - (51 * 3));
                                pcBoxJ4T5.Visible = true;
                                pcBoxJ4T5.BackColor = Color.Black;
                                pcBoxJ4T5.Location = new Point(659, 620 - (51 * 2));
                                pcBoxJ4T5.Visible = true;
                                pcBoxJ4T5.BackColor = Color.Black;
                                pcBoxJ4T5.Location = new Point(659, 620 - (51));
                                pcBoxJ4T5.Visible = true;
                                pcBoxJ4T5.BackColor = Color.Black;
                                pcBoxJ4T5.Location = new Point(659, 620);
                            }
                        }
                    }

                    //TRILHA 6
                    else if (statustabu.Trilha == 6)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Yellow;
                                pcBoxJ4T6.Location = new Point(723, 671);
                            }
                            else
                            {
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Black;
                                pcBoxJ4T6.Location = new Point(723, 671);
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Yellow;
                                pcBoxJ4T6.Location = new Point(723, 671 - 51);
                            }
                            else
                            {
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Black;
                                pcBoxJ4T6.Location = new Point(723, 671 - 51);
                            }
                        }
                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Yellow;
                                pcBoxJ4T6.Location = new Point(723, 671 - (51 * 2));
                            }
                            else
                            {
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Black;
                                pcBoxJ4T6.Location = new Point(723, 671 - (51 * 2));
                            }
                        }
                        else if (statustabu.Posicao == 4)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Yellow;
                                pcBoxJ4T6.Location = new Point(723, 671 - (51 * 3));
                            }
                            else
                            {
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Black;
                                pcBoxJ4T6.Location = new Point(723, 671 - (51 * 3));
                            }
                        }
                        else if (statustabu.Posicao == 5)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Yellow;
                                pcBoxJ4T6.Location = new Point(723, 671 - (51 * 4));
                            }
                            else
                            {
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Black;
                                pcBoxJ4T6.Location = new Point(723, 671 - (51 * 4));
                            }
                        }
                        else if (statustabu.Posicao == 6)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Yellow;
                                pcBoxJ4T6.Location = new Point(723, 671 - (51 * 5));
                            }
                            else
                            {
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Black;
                                pcBoxJ4T6.Location = new Point(723, 671 - (51 * 5));
                            }
                        }
                        else if (statustabu.Posicao == 7)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Yellow;
                                pcBoxJ4T6.Location = new Point(723, 671 - (51 * 6));
                            }
                            else
                            {
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Black;
                                pcBoxJ4T6.Location = new Point(723, 671 - (51 * 6));
                            }
                        }
                        else if (statustabu.Posicao == 8)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Yellow;
                                pcBoxJ4T6.Location = new Point(723, 671 - (51 * 7));
                            }
                            else
                            {
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Black;
                                pcBoxJ4T6.Location = new Point(723, 671 - (51 * 7));
                            }
                        }
                        else if (statustabu.Posicao == 9)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Yellow;
                                pcBoxJ4T6.Location = new Point(723, 671 - (51 * 8));
                            }
                            else
                            {
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Black;
                                pcBoxJ4T6.Location = new Point(723, 671 - (51 * 8));
                            }
                        }
                        else if (statustabu.Posicao == 10)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Yellow;
                                pcBoxJ4T6.Location = new Point(723, 671 - (51 * 9));
                            }
                            else
                            {
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Black;
                                pcBoxJ4T6.Location = new Point(723, 671 - (51 * 9));
                            }
                        }
                        else if (statustabu.Posicao == 11)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Yellow;
                                pcBoxJ4T6.Location = new Point(723, 671 - (51 * 10));
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Yellow;
                                pcBoxJ4T6.Location = new Point(723, 671 - (51 * 9));
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Yellow;
                                pcBoxJ4T6.Location = new Point(723, 671 - (51 * 8));
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Yellow;
                                pcBoxJ4T6.Location = new Point(723, 671 - (51 * 7));
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Yellow;
                                pcBoxJ4T6.Location = new Point(723, 671 - (51 * 6));
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Yellow;
                                pcBoxJ4T6.Location = new Point(723, 671 - (51 * 5));
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Yellow;
                                pcBoxJ4T6.Location = new Point(723, 671 - (51 * 4));
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Yellow;
                                pcBoxJ4T6.Location = new Point(723, 671 - (51 * 3));
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Yellow;
                                pcBoxJ4T6.Location = new Point(723, 671 - (51 * 2));
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Yellow;
                                pcBoxJ4T6.Location = new Point(723, 671 - (51));
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Yellow;
                                pcBoxJ4T6.Location = new Point(723, 671);
                            }
                            else
                            {
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Black;
                                pcBoxJ4T6.Location = new Point(723, 671 - (51 * 10));
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Black;
                                pcBoxJ4T6.Location = new Point(723, 671 - (51 * 9));
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Black;
                                pcBoxJ4T6.Location = new Point(723, 671 - (51 * 8));
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Black;
                                pcBoxJ4T6.Location = new Point(723, 671 - (51 * 7));
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Black;
                                pcBoxJ4T6.Location = new Point(723, 671 - (51 * 6));
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Black;
                                pcBoxJ4T6.Location = new Point(723, 671 - (51 * 5));
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Black;
                                pcBoxJ4T6.Location = new Point(723, 671 - (51 * 4));
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Black;
                                pcBoxJ4T6.Location = new Point(723, 671 - (51 * 3));
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Black;
                                pcBoxJ4T6.Location = new Point(723, 671 - (51 * 2));
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Black;
                                pcBoxJ4T6.Location = new Point(723, 671 - (51));
                                pcBoxJ4T6.Visible = true;
                                pcBoxJ4T6.BackColor = Color.Black;
                                pcBoxJ4T6.Location = new Point(723, 671);
                            }
                        }
                    }

                    /// TRILHA 7
                    else if (statustabu.Trilha == 7)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Yellow;
                                pcBoxJ4T7.Location = new Point(787, 723);
                            }
                            else
                            {
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Black;
                                pcBoxJ4T7.Location = new Point(787, 723);
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Yellow;
                                pcBoxJ4T7.Location = new Point(787, 723 - 51);
                            }
                            else
                            {
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Black;
                                pcBoxJ4T7.Location = new Point(787, 723 - 51);
                            }
                        }
                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Yellow;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 2));
                            }
                            else
                            {
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Black;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 2));
                            }
                        }
                        else if (statustabu.Posicao == 4)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Yellow;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 3));
                            }
                            else
                            {
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Black;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 3));
                            }
                        }
                        else if (statustabu.Posicao == 5)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Yellow;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 4));
                            }
                            else
                            {
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Black;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 4));
                            }
                        }
                        else if (statustabu.Posicao == 6)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Yellow;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 5));
                            }
                            else
                            {
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Black;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 5));
                            }
                        }
                        else if (statustabu.Posicao == 7)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Yellow;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 6));
                            }
                            else
                            {
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Black;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 6));
                            }
                        }
                        else if (statustabu.Posicao == 8)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Yellow;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 7));
                            }
                            else
                            {
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Black;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 7));
                            }
                        }
                        else if (statustabu.Posicao == 9)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Yellow;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 8));
                            }
                            else
                            {
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Black;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 8));
                            }
                        }
                        else if (statustabu.Posicao == 10)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Yellow;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 9));
                            }
                            else
                            {
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Black;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 9));
                            }
                        }
                        else if (statustabu.Posicao == 11)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Yellow;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 10));
                            }
                            else
                            {
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Black;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 10));
                            }
                        }
                        else if (statustabu.Posicao == 12)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Yellow;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 11));
                            }
                            else
                            {
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Black;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 11));
                            }
                        }
                        else if (statustabu.Posicao == 13)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Yellow;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 12));
                                pcBoxJ4T7.BackColor = Color.Yellow;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 11));
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Yellow;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 10));
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Yellow;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 9));
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Yellow;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 8));
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Yellow;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 7));
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Yellow;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 6));
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Yellow;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 5));
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Yellow;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 4));
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Yellow;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 3));
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Yellow;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 2));
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Yellow;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51));
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Yellow;
                                pcBoxJ4T7.Location = new Point(787, 723);
                            }
                            else
                            {
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Black;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 12));
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Black;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 11));
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Black;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 10));
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Black;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 9));
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Black;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 8));
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Black;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 7));
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Black;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 6));
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Black;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 5));
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Black;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 4));
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Black;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 3));
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Black;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51 * 2));
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Black;
                                pcBoxJ4T7.Location = new Point(787, 723 - (51));
                                pcBoxJ4T7.Visible = true;
                                pcBoxJ4T7.BackColor = Color.Black;
                                pcBoxJ4T7.Location = new Point(787, 723);
                            }
                        }
                    }


                    // TRILHA 8
                    else if (statustabu.Trilha == 8)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Yellow;
                                pcBoxJ4T8.Location = new Point(856, 671);
                            }
                            else
                            {
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Black;
                                pcBoxJ4T8.Location = new Point(856, 671);
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Yellow;
                                pcBoxJ4T8.Location = new Point(856, 671 - 51);
                            }
                            else
                            {
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Black;
                                pcBoxJ4T8.Location = new Point(856, 671 - 51);
                            }
                        }
                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Yellow;
                                pcBoxJ4T8.Location = new Point(856, 671 - (51 * 2));
                            }
                            else
                            {
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Black;
                                pcBoxJ4T8.Location = new Point(856, 671 - (51 * 2));
                            }
                        }
                        else if (statustabu.Posicao == 4)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Yellow;
                                pcBoxJ4T8.Location = new Point(856, 671 - (51 * 3));
                            }
                            else
                            {
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Black;
                                pcBoxJ4T8.Location = new Point(856, 671 - (51 * 3));
                            }
                        }
                        else if (statustabu.Posicao == 5)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Yellow;
                                pcBoxJ4T8.Location = new Point(856, 671 - (51 * 4));
                            }
                            else
                            {
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Black;
                                pcBoxJ4T8.Location = new Point(856, 671 - (51 * 4));
                            }
                        }
                        else if (statustabu.Posicao == 6)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Yellow;
                                pcBoxJ4T8.Location = new Point(856, 671 - (51 * 5));
                            }
                            else
                            {
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Black;
                                pcBoxJ4T8.Location = new Point(856, 671 - (51 * 5));
                            }
                        }
                        else if (statustabu.Posicao == 7)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Yellow;
                                pcBoxJ4T8.Location = new Point(856, 671 - (51 * 6));
                            }
                            else
                            {
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Black;
                                pcBoxJ4T8.Location = new Point(856, 671 - (51 * 6));
                            }
                        }
                        else if (statustabu.Posicao == 8)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Yellow;
                                pcBoxJ4T8.Location = new Point(856, 671 - (51 * 7));
                            }
                            else
                            {
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Black;
                                pcBoxJ4T8.Location = new Point(856, 671 - (51 * 7));
                            }
                        }
                        else if (statustabu.Posicao == 9)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Yellow;
                                pcBoxJ4T8.Location = new Point(856, 671 - (51 * 8));
                            }
                            else
                            {
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Black;
                                pcBoxJ4T8.Location = new Point(856, 671 - (51 * 8));
                            }
                        }
                        else if (statustabu.Posicao == 10)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Yellow;
                                pcBoxJ4T8.Location = new Point(856, 671 - (51 * 9));
                            }
                            else
                            {
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Black;
                                pcBoxJ4T8.Location = new Point(856, 671 - (51 * 9));
                            }
                        }
                        else if (statustabu.Posicao == 11)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Yellow;
                                pcBoxJ4T8.Location = new Point(856, 671 - (51 * 10));
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Yellow;
                                pcBoxJ4T8.Location = new Point(856, 671 - (51 * 9));
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Yellow;
                                pcBoxJ4T8.Location = new Point(856, 671 - (51 * 8));
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Yellow;
                                pcBoxJ4T8.Location = new Point(856, 671 - (51 * 7));
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Yellow;
                                pcBoxJ4T8.Location = new Point(856, 671 - (51 * 6));
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Yellow;
                                pcBoxJ4T8.Location = new Point(856, 671 - (51 * 5));
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Yellow;
                                pcBoxJ4T8.Location = new Point(856, 671 - (51 * 4));
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Yellow;
                                pcBoxJ4T8.Location = new Point(856, 671 - (51 * 3));
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Yellow;
                                pcBoxJ4T8.Location = new Point(856, 671 - (51 * 2));
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Yellow;
                                pcBoxJ4T8.Location = new Point(856, 671 - (51));
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Yellow;
                                pcBoxJ4T8.Location = new Point(856, 671);
                            }
                            else
                            {
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Black;
                                pcBoxJ4T8.Location = new Point(856, 671 - (51 * 10));
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Black;
                                pcBoxJ4T8.Location = new Point(856, 671 - (51 * 9));
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Black;
                                pcBoxJ4T8.Location = new Point(856, 671 - (51 * 8));
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Black;
                                pcBoxJ4T8.Location = new Point(856, 671 - (51 * 7));
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Black;
                                pcBoxJ4T8.Location = new Point(856, 671 - (51 * 6));
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Black;
                                pcBoxJ4T8.Location = new Point(856, 671 - (51 * 5));
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Black;
                                pcBoxJ4T8.Location = new Point(856, 671 - (51 * 4));
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Black;
                                pcBoxJ4T8.Location = new Point(856, 671 - (51 * 3));
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Black;
                                pcBoxJ4T8.Location = new Point(856, 671 - (51 * 2));
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Black;
                                pcBoxJ4T8.Location = new Point(856, 671 - (51));
                                pcBoxJ4T8.Visible = true;
                                pcBoxJ4T8.BackColor = Color.Black;
                                pcBoxJ4T8.Location = new Point(856, 671);
                            }
                        }
                    }
                    //TRILHA 9
                    else if (statustabu.Trilha == 9)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T9.Visible = true;
                                pcBoxJ4T9.BackColor = Color.Yellow;
                                pcBoxJ4T9.Location = new Point(917, 618);
                            }
                            else
                            {
                                pcBoxJ4T9.Visible = true;
                                pcBoxJ4T9.BackColor = Color.Black;
                                pcBoxJ4T9.Location = new Point(917, 618);
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T9.Visible = true;
                                pcBoxJ4T9.BackColor = Color.Yellow;
                                pcBoxJ4T9.Location = new Point(917, 618 - 51);
                            }
                            else
                            {
                                pcBoxJ4T9.Visible = true;
                                pcBoxJ4T9.BackColor = Color.Black;
                                pcBoxJ4T9.Location = new Point(917, 618 - 51);
                            }
                        }
                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T9.Visible = true;
                                pcBoxJ4T9.BackColor = Color.Yellow;
                                pcBoxJ4T9.Location = new Point(917, 618 - (51 * 2));
                            }
                            else
                            {
                                pcBoxJ4T9.Visible = true;
                                pcBoxJ4T9.BackColor = Color.Black;
                                pcBoxJ4T9.Location = new Point(917, 618 - (51 * 2));
                            }
                        }
                        else if (statustabu.Posicao == 4)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T9.Visible = true;
                                pcBoxJ4T9.BackColor = Color.Yellow;
                                pcBoxJ4T9.Location = new Point(917, 618 - (51 * 3));
                            }
                            else
                            {
                                pcBoxJ4T9.Visible = true;
                                pcBoxJ4T9.BackColor = Color.Black;
                                pcBoxJ4T9.Location = new Point(917, 618 - (51 * 3));
                            }
                        }
                        else if (statustabu.Posicao == 5)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T9.Visible = true;
                                pcBoxJ4T9.BackColor = Color.Yellow;
                                pcBoxJ4T9.Location = new Point(917, 618 - (51 * 4));
                            }
                            else
                            {
                                pcBoxJ4T9.Visible = true;
                                pcBoxJ4T9.BackColor = Color.Black;
                                pcBoxJ4T9.Location = new Point(917, 618 - (51 * 4));
                            }
                        }
                        else if (statustabu.Posicao == 6)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T9.Visible = true;
                                pcBoxJ4T9.BackColor = Color.Yellow;
                                pcBoxJ4T9.Location = new Point(917, 618 - (51 * 5));
                            }
                            else
                            {
                                pcBoxJ4T9.Visible = true;
                                pcBoxJ4T9.BackColor = Color.Black;
                                pcBoxJ4T9.Location = new Point(917, 618 - (51 * 5));
                            }
                        }
                        else if (statustabu.Posicao == 7)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T9.Visible = true;
                                pcBoxJ4T9.BackColor = Color.Yellow;
                                pcBoxJ4T9.Location = new Point(917, 618 - (51 * 6));
                            }
                            else
                            {
                                pcBoxJ4T9.Visible = true;
                                pcBoxJ4T9.BackColor = Color.Black;
                                pcBoxJ4T9.Location = new Point(917, 618 - (51 * 6));
                            }
                        }
                        else if (statustabu.Posicao == 8)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T9.Visible = true;
                                pcBoxJ4T9.BackColor = Color.Yellow;
                                pcBoxJ4T9.Location = new Point(917, 618 - (51 * 7));
                            }
                            else
                            {
                                pcBoxJ4T9.Visible = true;
                                pcBoxJ4T9.BackColor = Color.Black;
                                pcBoxJ4T9.Location = new Point(917, 618 - (51 * 7));
                            }
                        }
                        else if (statustabu.Posicao == 9)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T9.Visible = true;
                                pcBoxJ4T9.BackColor = Color.Yellow;
                                pcBoxJ4T9.Location = new Point(917, 618 - (51 * 8));
                                pcBoxJ4T9.Visible = true;
                                pcBoxJ4T9.BackColor = Color.Yellow;
                                pcBoxJ4T9.Location = new Point(917, 618 - (51 * 7));
                                pcBoxJ4T9.Visible = true;
                                pcBoxJ4T9.BackColor = Color.Yellow;
                                pcBoxJ4T9.Location = new Point(917, 618 - (51 * 6));
                                pcBoxJ4T9.Visible = true;
                                pcBoxJ4T9.BackColor = Color.Yellow;
                                pcBoxJ4T9.Location = new Point(917, 618 - (51 * 5));
                                pcBoxJ4T9.Visible = true;
                                pcBoxJ4T9.BackColor = Color.Yellow;
                                pcBoxJ4T9.Location = new Point(917, 618 - (51 * 4));
                                pcBoxJ4T9.Visible = true;
                                pcBoxJ4T9.BackColor = Color.Yellow;
                                pcBoxJ4T9.Location = new Point(917, 618 - (51 * 3));
                                pcBoxJ4T9.Visible = true;
                                pcBoxJ4T9.BackColor = Color.Yellow;
                                pcBoxJ4T9.Location = new Point(917, 618 - (51 * 2));
                                pcBoxJ4T9.Visible = true;
                                pcBoxJ4T9.BackColor = Color.Yellow;
                                pcBoxJ4T9.Location = new Point(917, 618 - (51));
                                pcBoxJ4T9.Visible = true;
                                pcBoxJ4T9.BackColor = Color.Yellow;
                                pcBoxJ4T9.Location = new Point(917, 618);
                            }
                            else
                            {
                                pcBoxJ4T9.Visible = true;
                                pcBoxJ4T9.BackColor = Color.Black;
                                pcBoxJ4T9.Location = new Point(917, 618 - (51 * 8));
                                pcBoxJ4T9.Visible = true;
                                pcBoxJ4T9.BackColor = Color.Black;
                                pcBoxJ4T9.Location = new Point(917, 618 - (51 * 7));
                                pcBoxJ4T9.Visible = true;
                                pcBoxJ4T9.BackColor = Color.Black;
                                pcBoxJ4T9.Location = new Point(917, 618 - (51 * 6));
                                pcBoxJ4T9.Visible = true;
                                pcBoxJ4T9.BackColor = Color.Black;
                                pcBoxJ4T9.Location = new Point(917, 618 - (51 * 5));
                                pcBoxJ4T9.Visible = true;
                                pcBoxJ4T9.BackColor = Color.Black;
                                pcBoxJ4T9.Location = new Point(917, 618 - (51 * 4));
                                pcBoxJ4T9.Visible = true;
                                pcBoxJ4T9.BackColor = Color.Black;
                                pcBoxJ4T9.Location = new Point(917, 618 - (51 * 3));
                                pcBoxJ4T9.Visible = true;
                                pcBoxJ4T9.BackColor = Color.Black;
                                pcBoxJ4T9.Location = new Point(917, 618 - (51 * 2));
                                pcBoxJ4T9.Visible = true;
                                pcBoxJ4T9.BackColor = Color.Black;
                                pcBoxJ4T9.Location = new Point(917, 618 - (51));
                                pcBoxJ4T9.Visible = true;
                                pcBoxJ4T9.BackColor = Color.Black;
                                pcBoxJ4T9.Location = new Point(917, 618);

                            }
                        }
                    }
                    //TRILHA 10
                    else if (statustabu.Trilha == 10)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T10.Visible = true;
                                pcBoxJ4T10.BackColor = Color.Yellow;
                                pcBoxJ4T10.Location = new Point(986, 572);
                            }
                            else
                            {
                                pcBoxJ4T10.Visible = true;
                                pcBoxJ4T10.BackColor = Color.Black;
                                pcBoxJ4T10.Location = new Point(986, 572);
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T10.Visible = true;
                                pcBoxJ4T10.BackColor = Color.Yellow;
                                pcBoxJ4T10.Location = new Point(986, 572 - 51);
                            }
                            else
                            {
                                pcBoxJ4T10.Visible = true;
                                pcBoxJ4T10.BackColor = Color.Black;
                                pcBoxJ4T10.Location = new Point(986, 572 - 51);
                            }
                        }
                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T10.Visible = true;
                                pcBoxJ4T10.BackColor = Color.Yellow;
                                pcBoxJ4T10.Location = new Point(986, 572 - (51 * 2));
                            }
                            else
                            {
                                pcBoxJ4T10.Visible = true;
                                pcBoxJ4T10.BackColor = Color.Black;
                                pcBoxJ4T10.Location = new Point(986, 572 - (51 * 2));
                            }
                        }
                        else if (statustabu.Posicao == 4)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T10.Visible = true;
                                pcBoxJ4T10.BackColor = Color.Yellow;
                                pcBoxJ4T10.Location = new Point(986, 572 - (51 * 3));
                            }
                            else
                            {
                                pcBoxJ4T10.Visible = true;
                                pcBoxJ4T10.BackColor = Color.Black;
                                pcBoxJ4T10.Location = new Point(986, 572 - (51 * 3));
                            }
                        }
                        else if (statustabu.Posicao == 5)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T10.Visible = true;
                                pcBoxJ4T10.BackColor = Color.Yellow;
                                pcBoxJ4T10.Location = new Point(986, 572 - (51 * 4));
                            }
                            else
                            {
                                pcBoxJ4T10.Visible = true;
                                pcBoxJ4T10.BackColor = Color.Black;
                                pcBoxJ4T10.Location = new Point(986, 572 - (51 * 4));
                            }
                        }
                        else if (statustabu.Posicao == 6)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T10.Visible = true;
                                pcBoxJ4T10.BackColor = Color.Yellow;
                                pcBoxJ4T10.Location = new Point(986, 572 - (51 * 5));
                            }
                            else
                            {
                                pcBoxJ4T10.Visible = true;
                                pcBoxJ4T10.BackColor = Color.Black;
                                pcBoxJ4T10.Location = new Point(986, 572 - (51 * 5));
                            }
                        }
                        else if (statustabu.Posicao == 7)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T10.Visible = true;
                                pcBoxJ4T10.BackColor = Color.Yellow;
                                pcBoxJ4T10.Location = new Point(986, 572 - (51 * 6));
                                pcBoxJ4T10.Visible = true;
                                pcBoxJ4T10.BackColor = Color.Yellow;
                                pcBoxJ4T10.Location = new Point(986, 572 - (51 * 5));
                                pcBoxJ4T10.Visible = true;
                                pcBoxJ4T10.BackColor = Color.Yellow;
                                pcBoxJ4T10.Location = new Point(986, 572 - (51 * 4));
                                pcBoxJ4T10.Visible = true;
                                pcBoxJ4T10.BackColor = Color.Yellow;
                                pcBoxJ4T10.Location = new Point(986, 572 - (51 * 3));
                                pcBoxJ4T10.Visible = true;
                                pcBoxJ4T10.BackColor = Color.Yellow;
                                pcBoxJ4T10.Location = new Point(986, 572 - (51 * 2));
                                pcBoxJ4T10.Visible = true;
                                pcBoxJ4T10.BackColor = Color.Yellow;
                                pcBoxJ4T10.Location = new Point(986, 572 - (51));
                                pcBoxJ4T10.Visible = true;
                                pcBoxJ4T10.BackColor = Color.Yellow;
                                pcBoxJ4T10.Location = new Point(986, 572);
                            }
                            else
                            {
                                pcBoxJ4T10.Visible = true;
                                pcBoxJ4T10.BackColor = Color.Black;
                                pcBoxJ4T10.Location = new Point(986, 572 - (51 * 6));
                                pcBoxJ4T10.Visible = true;
                                pcBoxJ4T10.BackColor = Color.Black;
                                pcBoxJ4T10.Location = new Point(986, 572 - (51 * 5));
                                pcBoxJ4T10.Visible = true;
                                pcBoxJ4T10.BackColor = Color.Black;
                                pcBoxJ4T10.Location = new Point(986, 572 - (51 * 4));
                                pcBoxJ4T10.Visible = true;
                                pcBoxJ4T10.BackColor = Color.Black;
                                pcBoxJ4T10.Location = new Point(986, 572 - (51 * 3));
                                pcBoxJ4T10.Visible = true;
                                pcBoxJ4T10.BackColor = Color.Black;
                                pcBoxJ4T10.Location = new Point(986, 572 - (51 * 2));
                                pcBoxJ4T10.Visible = true;
                                pcBoxJ4T10.BackColor = Color.Black;
                                pcBoxJ4T10.Location = new Point(986, 572 - (51));
                                pcBoxJ4T10.Visible = true;
                                pcBoxJ4T10.BackColor = Color.Black;
                                pcBoxJ4T10.Location = new Point(986, 572);
                     

                            }
                        }
                    }

                    //TRILHA 11
                    else if (statustabu.Trilha == 11)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T11.Visible = true;
                                pcBoxJ4T11.BackColor = Color.Yellow;
                                pcBoxJ4T11.Location = new Point(1056, 518);
                            }
                            else
                            {
                                pcBoxJ4T11.Visible = true;
                                pcBoxJ4T11.BackColor = Color.Black;
                                pcBoxJ4T11.Location = new Point(1056, 518);
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T11.Visible = true;
                                pcBoxJ4T11.BackColor = Color.Yellow;
                                pcBoxJ4T11.Location = new Point(1056, 518 - 51);
                            }
                            else
                            {
                                pcBoxJ4T11.Visible = true;
                                pcBoxJ4T11.BackColor = Color.Black;
                                pcBoxJ4T11.Location = new Point(1056, 518 - 51);
                            }
                        }
                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T11.Visible = true;
                                pcBoxJ4T11.BackColor = Color.Yellow;
                                pcBoxJ4T11.Location = new Point(1056, 518 - (51 * 2));
                            }
                            else
                            {
                                pcBoxJ4T11.Visible = true;
                                pcBoxJ4T11.BackColor = Color.Black;
                                pcBoxJ4T11.Location = new Point(1056, 518 - (51 * 2));
                            }
                        }
                        else if (statustabu.Posicao == 4)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T11.Visible = true;
                                pcBoxJ4T11.BackColor = Color.Yellow;
                                pcBoxJ4T11.Location = new Point(1056, 518 - (51 * 3));
                            }
                            else
                            {
                                pcBoxJ4T11.Visible = true;
                                pcBoxJ4T11.BackColor = Color.Black;
                                pcBoxJ4T11.Location = new Point(1056, 518 - (51 * 3));
                            }
                        }
                        else if (statustabu.Posicao == 5)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T11.Visible = true;
                                pcBoxJ4T11.BackColor = Color.Yellow;
                                pcBoxJ4T11.Location = new Point(1056, 518 - (51 * 4));
                                pcBoxJ4T11.Visible = true;
                                pcBoxJ4T11.BackColor = Color.Yellow;
                                pcBoxJ4T11.Location = new Point(1056, 518 - (51 * 3));
                                pcBoxJ4T11.Visible = true;
                                pcBoxJ4T11.BackColor = Color.Yellow;
                                pcBoxJ4T11.Location = new Point(1056, 518 - (51 * 2));
                                pcBoxJ4T11.Visible = true;
                                pcBoxJ4T11.BackColor = Color.Yellow;
                                pcBoxJ4T11.Location = new Point(1056, 518 - (51));
                                pcBoxJ4T11.Visible = true;
                                pcBoxJ4T11.BackColor = Color.Yellow;
                                pcBoxJ4T11.Location = new Point(1056, 518);
                            }
                            else
                            {
                                pcBoxJ4T11.Visible = true;
                                pcBoxJ4T11.BackColor = Color.Black;
                                pcBoxJ4T11.Location = new Point(1056, 518 - (51 * 4));
                                pcBoxJ4T11.Visible = true;
                                pcBoxJ4T11.BackColor = Color.Black;
                                pcBoxJ4T11.Location = new Point(1056, 518 - (51 * 3));
                                pcBoxJ4T11.Visible = true;
                                pcBoxJ4T11.BackColor = Color.Black;
                                pcBoxJ4T11.Location = new Point(1056, 518 - (51 * 2));
                                pcBoxJ4T11.Visible = true;
                                pcBoxJ4T11.BackColor = Color.Black;
                                pcBoxJ4T11.Location = new Point(1056, 518 - (51));
                                pcBoxJ4T11.Visible = true;
                                pcBoxJ4T11.BackColor = Color.Black;
                                pcBoxJ4T11.Location = new Point(1056, 518);

                            }
                        }
                    }

                    //TRILHA 12
                    else if (statustabu.Trilha == 12)
                    {
                        if (statustabu.Posicao == 1)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T12.Visible = true;
                                pcBoxJ4T12.BackColor = Color.Yellow;
                                pcBoxJ4T12.Location = new Point(1117, 470);
                            }
                            else
                            {
                                pcBoxJ4T12.Visible = true;
                                pcBoxJ4T12.BackColor = Color.Black;
                                pcBoxJ4T12.Location = new Point(1117, 470);
                            }
                        }
                        else if (statustabu.Posicao == 2)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T12.Visible = true;
                                pcBoxJ4T12.BackColor = Color.Yellow;
                                pcBoxJ4T12.Location = new Point(1117, 470 - 51);
                            }
                            else
                            {
                                pcBoxJ4T12.Visible = true;
                                pcBoxJ4T12.BackColor = Color.Black;
                                pcBoxJ4T12.Location = new Point(1117, 470 - 51);
                            }
                        }
                        else if (statustabu.Posicao == 3)
                        {
                            if (statustabu.Tipo == "B")
                            {
                                pcBoxJ4T12.Visible = true;
                                pcBoxJ4T12.BackColor = Color.Yellow;
                                pcBoxJ4T12.Location = new Point(1117, 470 - (51 * 2));
                                pcBoxJ4T12.Visible = true;
                                pcBoxJ4T12.BackColor = Color.Yellow;
                                pcBoxJ4T12.Location = new Point(1117, 470 - (51));
                                pcBoxJ4T12.Visible = true;
                                pcBoxJ4T12.BackColor = Color.Yellow;
                                pcBoxJ4T12.Location = new Point(1117, 470);
                            }
                            else
                            {
                                pcBoxJ4T12.Visible = true;
                                pcBoxJ4T12.BackColor = Color.Black;
                                pcBoxJ4T12.Location = new Point(1117, 470 - (51 * 2));
                                pcBoxJ4T12.Visible = true;
                                pcBoxJ4T12.BackColor = Color.Black;
                                pcBoxJ4T12.Location = new Point(1117, 470 - (51));
                                pcBoxJ4T12.Visible = true;
                                pcBoxJ4T12.BackColor = Color.Black;
                                pcBoxJ4T12.Location = new Point(1117, 470);
                            }
                        }
                    }

                }


                j++;


                }


        }

        public void Mover(int id, string senha, string ordem1, string trilha1)
        {

            string retorno = Jogo.Mover(id, senha, ordem1, trilha1); 
            ExibirHistorico(id);

        }

        public void parar(int id,string senha)
        {
            Jogador jog1 = new Jogador();
            jog1.IdJogador  = Convert.ToInt32(textBox6.Text);
            string senhajogador = textBox1.Text;
            Jogo.Parar(jog1.IdJogador, senhajogador);
            timer1.Stop();
            timer1.Enabled = false;
            ExibirHistorico(jog1.IdJogador);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //Jogador jog1 = new Jogador();
            //jog1.IdJogador = Convert.ToInt32(textBox6.Text);
            //string senhajogador = textBox1.Text;
            int idPartida = Convert.ToInt32(textBox5.Text);
            
            verificarVeiz();
            exibirTabuleiro(idPartida);
            ExibirHistorico(idPartida);
            //rolarDados(jog1.IdJogador, senhajogador);
            //Mover();

        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //  //  verificarVeiz(idPartida);
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Jogador jog1 = new Jogador();
        //    jog1.IdJogador = Convert.ToInt32(textBox6.Text);
        //    string senhajogador = textBox1.Text;
        //    rolarDados(jog1.IdJogador, senhajogador);
        //}

        //private void btnMover_Click(object sender, EventArgs e)
        //{
        //    Jogador jog1 = new Jogador();
        //    jog1.IdJogador = Convert.ToInt32(textBox6.Text);
        //    string senhajogador = textBox1.Text;
        //    Jogo.Mover(jog1.IdJogador, senhajogador, txtOrdem.Text, txtTrilha.Text);
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    exibirTabuleiro(idPartida);
        //}

        //private void btnParar_Click(object sender, EventArgs e)
        //{
        //    Jogador jog1 = new Jogador();
        //    jog1.IdJogador = Convert.ToInt32(textBox6.Text);
        //    string senhajogador = textBox1.Text;
        //    Jogo.Parar(jog1.IdJogador, senhajogador);
        //    timer1.Stop();
        //    timer1.Enabled = false;
        //    ExibirHistorico(jog1.IdJogador);
        //}

    
    }


 }

