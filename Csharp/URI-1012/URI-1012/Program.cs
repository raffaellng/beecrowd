﻿/* Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
 * a) a área do triângulo retângulo que tem A por base e C por altura.
 * b) a área do círculo de raio C. (pi = 3.14159)
 * c) a área do trapézio que tem A e B por bases e C por altura.
 * d) a área do quadrado que tem lado B.
 * e) a área do retângulo que tem lados A e B.
 * 
 * Entrada
 * O arquivo de entrada contém três valores com um dígito após o ponto decimal.
 * Saída
 * O arquivo de saída deverá conter 5 linhas de dados. Cada linha corresponde a uma das áreas descritas acima, sempre com mensagem
 * correspondente e um espaço entre os dois pontos e o valor. O valor calculado deve ser apresentado com 3 dígitos após o ponto decimal.
 * 
 * Exemplo:
 * ==================================================================
 * Entrada                                          Saída
 * ==================================================================
 * 3.0 4.0 5.2                                      TRIANGULO: 7.800
 *                                                  CIRCULO: 84.949
 *                                                  TRAPEZIO: 18.200
 *                                                  QUADRADO: 16.000
 *                                                  RETANGULO: 12.000
 * ==================================================================
 * 12.7 10.4 15.2                                   TRIANGULO: 96.520
 *                                                  CIRCULO: 725.833
 *                                                  TRAPEZIO: 175.560
 *                                                  QUADRADO: 108.160
 *                                                  RETANGULO: 132.080
 */


using System;
using System.Globalization;

namespace URI_1012 {
    class Program {
        static void Main(string[] args) {

            string[] vetor = Console.ReadLine().Split(' ');

            double a = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            double c = double.Parse(vetor[2], CultureInfo.InvariantCulture);
            double pi = 3.14159;

            double areaTriangulo = a * c / 2.0;
            double areaCirculo = pi * Math.Pow(c, 2.0);
            double areaTrapezio = (a + b) * c / 2.0;
            double areaQuadrado = Math.Pow(b, 2.0);
            double areaRetangulo = a * b;

            Console.WriteLine("TRIANGULO: " + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}