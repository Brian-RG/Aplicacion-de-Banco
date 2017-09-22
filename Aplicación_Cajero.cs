using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicación_Cajero
{
    class Program
    {
        static void Main(string[] args)
        {
            string contraseña="", password = "123", password1, password2;
            string consulta;
            int retiros1 = 0, retiros = 0, monto, saldo = 9150;
            int cont_retiro = 0, deposito, deposito1 = 0;
            int cont_deposito = 0, cont_pagos = 0, intentos = 0;
            string usuario;
            string user = "admin";
            char respuesta = ' ';
            bool continuar;
            ConsoleKeyInfo letra;     
                           
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("::::::::::::::::::Bienvenido al cajero Bankrex::::::::::::::::");
                Console.WriteLine();
                Console.WriteLine();
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                contraseña = "";
                Console.WriteLine("::::::::::::::::::Bienvenido al cajero Bankrex::::::::::::::::");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Ingresa el usuario: ");
                usuario = Console.ReadLine();
                Console.Write("Ingresa tu contraseña: ");
                continuar = true;
                while (continuar)
                {
                    letra = Console.ReadKey(true);
                    if (letra.KeyChar != '\r')
                    {
                        contraseña+= letra.KeyChar;
                        Console.Write("*");
                    }
                    else
                        continuar = false;
                }
                Console.Write('\n');
                Console.WriteLine(contraseña);
                if (contraseña == password && usuario == user)
                {
                    do
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("¡Bienvenido!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Elige una operación");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("a) Retiros");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("b) Depósitos");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("c) Consulta de saldos y movimientos");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("d) Pago de servicios");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("e) Cambio de contraseña");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("f) Salir");
                        Console.ForegroundColor = ConsoleColor.Black;
                        respuesta = Convert.ToChar(Console.ReadLine());
                        Console.Clear();
                        switch (respuesta)
                        {
                            case 'a':
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.Clear();
                                if (retiros1 == 7000)
                                {
                                    Console.WriteLine("Haz alcanzado el monto máximo de retiros por hoy.");
                                    Console.ReadKey(false);
                                    break;
                                }
                                Console.WriteLine("****************** La cantidad máxima de retiro son $7000 ***********************");
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("Ingresa el monto a retirar");
                                monto = Convert.ToInt32(Console.ReadLine());
                                retiros1 += monto;
                                if (monto >= 0)
                                {
                                    if (retiros1 <= 7000)
                                    {
                                        Console.Clear();
                                        saldo = saldo - monto;
                                        Console.WriteLine("Tu saldo actual es de {0}", saldo);
                                        retiros = retiros1;
                                        ++cont_retiro;
                                        Console.ReadKey(false);
                                        break;
                                    }
                                    else if (retiros1 > 7000)
                                        Console.WriteLine("Error al realizar la operación: Monto excedido.");
                                }
                                else
                                    Console.WriteLine("Error. Cantidad incorrecta.");
                                retiros1 = retiros;
                                Console.ReadKey(false);
                                break;
                            case 'b':

                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.Clear();
                                if (deposito1 == 12000)
                                {
                                    Console.WriteLine("Haz alcanzado el máximo de depósito por hoy.");
                                    Console.ReadKey(false);
                                    break;
                                }
                                Console.WriteLine("****************** La cantidad máxima de deposito es $12000 ***********************");
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("Ingresa la cantidad del deposito:");
                                deposito = Convert.ToInt32(Console.ReadLine());
                                deposito1 += deposito;
                                if (deposito1 > 0)
                                {
                                    if (deposito1 <= 12000)
                                    {
                                        Console.Clear();
                                        saldo = saldo + deposito;
                                        Console.WriteLine("Tu saldo actual es de {0}", saldo);
                                        deposito = deposito1;
                                        ++cont_deposito;
                                        Console.ReadKey(false);
                                        break;
                                    }//if de depositos
                                    else
                                    {
                                        Console.WriteLine("Error al realizar la operación: Monto excedido.");
                                    }
                                }//if de validacion de depositos 
                                else
                                {
                                    Console.WriteLine("Error: Monto mal ingresado");
                                }//validacion de depositos
                                deposito1 = deposito;
                                Console.ReadKey(false);
                                break;
                            case 'c':
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.Clear();
                                Console.WriteLine("********************************");
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("Ingresa la opción:");
                                Console.WriteLine("saldo");
                                Console.WriteLine("movimientos");
                                consulta = Console.ReadLine();
                                switch (consulta)
                                {
                                    case "saldo":
                                        Console.Clear();
                                        Console.WriteLine("Tu saldo actual es de {0}", saldo);
                                        break;
                                    case "movimientos":
                                        Console.Clear();
                                        Console.WriteLine("El total de retiros fue de {0}", cont_retiro);
                                        Console.WriteLine("El total de depósitos fue de {0}", cont_deposito);
                                        Console.WriteLine("El total de pagos de servicios fue de {0}", cont_pagos);
                                        break;
                                }
                                break;


                            case 'd':
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.WriteLine("****************** Pago de servicios ***********************");
                                Console.WriteLine("Se raliza un cargo extra de $7 por pago de servicios");
                                Console.WriteLine("Elige el pago de servicio:");
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("1) Telefonia");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("2) Luz");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("3) Agua");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("4) Gas");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                break;
                            case 'e':
                                do
                                {
                                    Console.Write("Ingresa tu contraseña actual: ");
                                    contraseña = Console.ReadLine();
                                    if (contraseña == password)
                                        break;
                                    else
                                        Console.Write("Contraseña incorrecta.");
                                }
                                while (contraseña != password);
                                Console.Write("Ingresa la nueva contraseña: ");
                                password1 = Console.ReadLine();
                                Console.Write("Reingresa la nueva contraseña: ");
                                password2 = Console.ReadLine();
                                if (password1 == password2)
                                {
                                    Console.WriteLine("Cambio de contraseña exitoso");
                                    password = password1;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Las contraseñas no coinciden");
                                }
                                break;

                            case 'f':
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.Clear();
                                Console.WriteLine("*****************Gracias por usar Bankrex****************");
                                Console.ReadKey(true);
                                break;
                            default:
                                Console.WriteLine("Error, opción incorrecta.");
                                break;
                        }
                        if (respuesta == 'e')
                            break;
                    }
                    while (respuesta != 'f');
                }
                else
                {
                    Console.WriteLine("Error, usuario y/o contraseña incorrectos.");
                    ++intentos;
                    Console.ReadKey(false);
                }
                if (intentos > 3)
                {
                    Console.WriteLine("Numero de intentos excedidos");
                    Console.ReadKey(false);
                    break;
                }
                if (respuesta == 'f')
                    break;
            }
            while (respuesta=='e' || intentos <=3);
            Console.ReadKey(true);
        }
    }
}
