﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using Modbus.Device;

namespace ModBus1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void buttonUpdatePorts_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBoxPorts.Text = "";
            comboBoxPorts.Items.Clear();
            //Если массив не пустой, тогда 
            //    Добавляем в comboboxPorts все элементы массива ports
            //    Сразу выбираем нулевой элем
            if (ports.Length != 0)
            {
                comboBoxPorts.Items.AddRange(ports);
                comboBoxPorts.SelectedIndex = 0;
            }
        }

        private void buttonConect_Click(object sender, EventArgs e)
        {
            if (buttonConect.Text == "Подключиться")
            {
                try
                {
                    MySerialPort.PortName = comboBoxPorts.Text; //выбираем порт
                    MySerialPort.Open();                        // открываем порт
                    comboBoxPorts.Enabled = false;
                    buttonConect.Text = "Отключиться";
                }
                catch
                {
                    MessageBox.Show("Ошибка подключения");
                }
            }
            else if (buttonConect.Text == "Отключиться")
            {
                MySerialPort.Close();
                comboBoxPorts.Enabled =true;
                buttonConect.Text = "Подключиться";

            }


            
        }

        private void comboBoxPorts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MySerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //SerialPort serialPort = new SerialPort(); //Create a new SerialPort object.
            //serialPort.PortName = "COM";
            //serialPort.BaudRate = 9600;
            //serialPort.DataBits = 8;
            //serialPort.Parity = Parity.None;
            //serialPort.StopBits = StopBits.One;
            //serialPort.Open();
            //ModbusSerialMaster master = ModbusSerialMaster.CreateRtu(MySerialPort);
            //byte slaveID = 1;
            //ushort startAdress = 0;
            //ushort numOfPoints = 1;
            //ushort[] holding_register = master.ReadHoldingRegisters(slaveID, startAdress, numOfPoints);

            //label1.Text = holding_register.ToString();
            ////MessageBox.Show(label1.Text);
            //serialPort.Close();
        }
    }
}
    