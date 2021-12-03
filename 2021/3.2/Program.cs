﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var oxygenGeneratorRating = inputs.AsEnumerable();
            var co2ScrubberRating = inputs.AsEnumerable();

            for (int i = 11; i >= 0; i--)
            {
                if (oxygenGeneratorRating.Count() > 1)
                    oxygenGeneratorRating = oxygenGeneratorRating.FindByBitCommonality(true, i);
                if (co2ScrubberRating.Count() > 1)
                    co2ScrubberRating = co2ScrubberRating.FindByBitCommonality(false, i);
            }

            var lifeSupportRating = oxygenGeneratorRating.First() * co2ScrubberRating.First();

            Console.WriteLine($"{oxygenGeneratorRating.First()} (oxy) * {co2ScrubberRating.First()} (co2) = {lifeSupportRating} (life)");
        }

        static readonly int[] inputs = {
            0b111110110111, 0b100111000111, 0b11101111101, 0b11011010010, 0b1010001010, 0b111101001001, 0b10001110011, 
            0b100001001111, 0b110101010000, 0b100001100010, 0b11000100, 0b111101000101, 0b100100100110, 0b100000011111, 
            0b101101111101, 0b100000011110, 0b1110101111, 0b101011101011, 0b110011000001, 0b10100011110, 0b100011000011, 
            0b1000101001, 0b101110010110, 0b101110010100, 0b110000001101, 0b10001010101, 0b110000010010, 0b111011101100, 
            0b101111011100, 0b101000010111, 0b11000011001, 0b110011110010, 0b110100011010, 0b110110010011, 0b1110001100, 
            0b11011001100, 0b11101111, 0b111010101001, 0b101001000, 0b10111111, 0b110100100111, 0b11000101000, 0b101011001101, 
            0b110110110, 0b10101001111, 0b10011010110, 0b101111100001, 0b111101100, 0b101110, 0b101110001111, 0b10000001101, 
            0b11111010011, 0b101100011111, 0b11011000000, 0b110000010111, 0b1011010010, 0b101111100000, 0b101010000010, 0b11101101010, 
            0b110010000111, 0b11110011111, 0b110000010110, 0b11110101000, 0b111001011000, 0b111010011100, 0b11111000101, 0b11111110100, 
            0b111101101010, 0b111101101001, 0b11011110011, 0b100110100010, 0b100000110000, 0b10001010011, 0b100110111000, 0b101010110100, 
            0b11011011010, 0b10100100000, 0b11110011100, 0b110101000001, 0b1010111101, 0b11110011000, 0b1101101001, 0b10011001110, 
            0b100000100111, 0b100101011, 0b110000000010, 0b100011101011, 0b100101010010, 0b1010100111, 0b1111011100, 0b10111100101, 
            0b111000000, 0b10001011101, 0b100111001001, 0b111100010101, 0b110011000, 0b10101001, 0b110001110101, 0b11101000110, 0b11101111011, 
            0b110100011101, 0b11001100010, 0b11011010100, 0b1110111101, 0b100110001, 0b100100000000, 0b10001110010, 0b110010010100, 
            0b10100111011, 0b111010010100, 0b10010111010, 0b11001100000, 0b110101110111, 0b1111100101, 0b1011100000, 0b10011001000, 
            0b10011011100, 0b111001, 0b10101110000, 0b1100011100, 0b10110011, 0b111000101010, 0b100000010010, 0b1001011101, 0b11100100001, 
            0b110111101000, 0b101110001001, 0b1011000110, 0b100110011010, 0b101010000111, 0b110110000110, 0b1100101101, 0b1011, 0b110001110011, 
            0b10001100111, 0b10100011111, 0b10001, 0b1100110011, 0b11010011110, 0b101100111101, 0b111000110, 0b101000111010, 0b11011001011, 
            0b11111000000, 0b111011010110, 0b11001111, 0b101100100000, 0b100111010000, 0b10000001010, 0b1010001011, 0b11000010, 0b111001110100, 
            0b11000011, 0b1101001, 0b10010, 0b100100010001, 0b11010010111, 0b110111011010, 0b101101001110, 0b1110010110, 0b10100110001, 
            0b101101010100, 0b111100, 0b110011111110, 0b10100101, 0b100111010111, 0b110111101111, 0b111010011000, 0b110000111100, 0b101001011100, 
            0b101000100101, 0b100010001110, 0b101111001100, 0b101100111000, 0b100000110, 0b1100100100, 0b101011011011, 0b111010010101, 
            0b100011100101, 0b1100000111, 0b100111000001, 0b10001011010, 0b101101110100, 0b100011011110, 0b110001110000, 0b111100101000, 
            0b100111111011, 0b110000101010, 0b101100110100, 0b1001000001, 0b110100011100, 0b10111110001, 0b110111101010, 0b100001110010, 
            0b100000000011, 0b111100001, 0b111010011011, 0b10101011110, 0b1000001101, 0b10111010101, 0b100100011000, 0b111000110010, 
            0b110001110100, 0b111001101000, 0b110000111110, 0b10111001100, 0b11101110011, 0b101001101011, 0b11011110000, 0b111010010, 
            0b110101010111, 0b11101000101, 0b100100101, 0b11100011101, 0b10000100100, 0b101111011, 0b110111010010, 0b110111100010, 0b110111100, 
            0b11011010011, 0b111111111011, 0b1111000101, 0b111110010110, 0b10000011011, 0b111110011101, 0b100111101100, 0b1000100011, 
            0b111010000010, 0b1001001100, 0b10000010111, 0b101010100011, 0b111110010000, 0b110100100001, 0b1111000010, 0b110010000000, 
            0b111110110001, 0b100001101110, 0b101011010101, 0b111100100011, 0b1111000000, 0b101111111011, 0b1001010101, 0b1110111000, 
            0b101010001001, 0b110111000000, 0b10101110011, 0b1110101110, 0b11010101, 0b110111011, 0b10001000, 0b100000100011, 0b1001001001, 
            0b11101111111, 0b100101100101, 0b10011101110, 0b101000101100, 0b110011000101, 0b1101111000, 0b1011000, 0b10100100110, 
            0b111011001000, 0b110110010111, 0b1000001011, 0b111000101001, 0b11010011100, 0b111011010011, 0b11001101111, 0b11000111111, 
            0b10100000000, 0b111010101, 0b101111011010, 0b100011111, 0b11000000100, 0b101111110010, 0b111110001100, 0b101111111000, 
            0b111000001101, 0b100000001101, 0b100011110001, 0b100111110100, 0b10100000111, 0b10000, 0b10110011001, 0b111001100001, 
            0b110001011011, 0b10101100011, 0b110011011010, 0b110001011000, 0b110111010011, 0b101000011110, 0b111100011111, 0b101011000111, 
            0b101000011001, 0b100000000, 0b10111000011, 0b110001000100, 0b1010011010, 0b10010011000, 0b110100001000, 0b10000101010, 
            0b111110000001, 0b110101000000, 0b1110101, 0b10101101, 0b10100001111, 0b10110100010, 0b11111110111, 0b111000001000, 0b110001010, 
            0b10100011, 0b11110101001, 0b101000100, 0b100101110011, 0b111110011100, 0b11101001010, 0b1001001110, 0b110101111111, 0b101011100, 
            0b1100110111, 0b10010000010, 0b111010111, 0b111100001110, 0b11110110011, 0b110110000010, 0b101110011111, 0b100101011001, 
            0b111001111111, 0b111010110110, 0b110110011000, 0b110110111010, 0b100100111010, 0b1010101011, 0b100011001000, 0b101011101010, 
            0b111100111110, 0b100010101000, 0b11011111001, 0b10111111110, 0b111111011010, 0b100111110000, 0b100100100011, 0b11101011100, 
            0b11101011011, 0b10001000110, 0b11100010100, 0b110111110000, 0b110110101101, 0b110001001001, 0b110101011011, 0b101101100011, 
            0b101101010000, 0b111011001111, 0b100111100100, 0b100110000000, 0b100011011010, 0b10100000001, 0b1100011101, 0b10011100011, 
            0b101011111, 0b111010011, 0b1100110101, 0b11011001110, 0b101111000100, 0b111110111101, 0b111111000100, 0b1101111101, 
            0b1111111111, 0b110101001101, 0b11111110001, 0b111001010001, 0b1000110001, 0b10010110111, 0b111111111, 0b1011010, 0b100101101110, 
            0b100001111100, 0b110110010000, 0b110110101100, 0b10110101011, 0b11111101010, 0b1110101010, 0b1111001101, 0b1101010, 0b100111100, 
            0b101111100100, 0b10011110, 0b100110010100, 0b111101101110, 0b100011111101, 0b100111100001, 0b11110100101, 0b111101100110, 
            0b101001111010, 0b101001001010, 0b1000101111, 0b1111001011, 0b101000100011, 0b110100100110, 0b110010101111, 0b1000001, 
            0b1011010111, 0b111101011011, 0b100000101, 0b111001001101, 0b110001101001, 0b10111000001, 0b101110101110, 0b110100010011, 
            0b1011110000, 0b101000001011, 0b11110111101, 0b1010011111, 0b1101110101, 0b100001110110, 0b111111111111, 0b10011011011, 
            0b111101000, 0b11011011000, 0b1101, 0b101111100101, 0b101101010, 0b10111001000, 0b11110110100, 0b110100110010, 0b110011110, 
            0b1011110100, 0b1111101010, 0b110100111101, 0b10101011011, 0b10101101011, 0b101011100011, 0b11110011010, 0b111111001111, 
            0b1100110010, 0b101111101111, 0b110010001001, 0b101101100101, 0b111000101, 0b101010001, 0b11100111110, 0b1000001001, 
            0b101100100010, 0b1110010000, 0b111110000010, 0b110110001010, 0b10001010110, 0b1101010011, 0b100011010111, 0b100011000001, 
            0b1111011011, 0b1100001110, 0b110001100, 0b1101000, 0b111101010111, 0b10011100101, 0b10010111001, 0b11100111001, 0b1000000111, 
            0b10001000100, 0b110010000, 0b100011110, 0b110110101111, 0b100111111110, 0b11111110101, 0b100101100000, 0b110101100011, 
            0b10100100100, 0b110011110100, 0b1001101010, 0b111110100111, 0b10101000, 0b1010011001, 0b101111100011, 0b10110100001, 
            0b100101001111, 0b1010010010, 0b101010101110, 0b101101101010, 0b11100010011, 0b100001001101, 0b1010011100, 0b10111101, 
            0b1110100011, 0b101000110000, 0b111011001101, 0b100100001010, 0b111011111000, 0b1100111111, 0b10001111000, 0b1010101111, 
            0b101001110001, 0b10111111101, 0b10000011101, 0b11101010, 0b1100111100, 0b100110001110, 0b1101001010, 0b1100001, 0b11001001111, 
            0b101011000011, 0b110111101101, 0b111101101100, 0b1010110001, 0b110101000110, 0b10111010110, 0b110100111010, 0b101010011101, 
            0b1000101110, 0b111111011101, 0b111100011100, 0b10101110101, 0b11100011011, 0b111101100000, 0b11100101111, 0b110110100001, 
            0b101010010111, 0b100101101111, 0b1001000, 0b111001000110, 0b1101110001, 0b100001000101, 0b110110011100, 0b100101110100, 
            0b111010101110, 0b100111110101, 0b10101011, 0b11100110110, 0b111110100110, 0b111100000111, 0b101111010111, 0b100001000011, 
            0b1011000000, 0b100010010101, 0b111000101101, 0b101010100010, 0b111110111000, 0b101000001, 0b101001110110, 0b110001101010, 
            0b100011100111, 0b100111001101, 0b1100001001, 0b10111110011, 0b11111101, 0b10011100100, 0b110101110011, 0b101110101100, 
            0b111100111000, 0b101100011000, 0b10101010000, 0b1110000000, 0b1100, 0b10011111010, 0b100101010100, 0b10011110000, 0b100011110000, 
            0b110011101, 0b111111110010, 0b100111100000, 0b100001011110, 0b111011000110, 0b111001011011, 0b110110100111, 0b100101110001, 
            0b111010100001, 0b101101011000, 0b100000100000, 0b11000100110, 0b100000100010, 0b100010011100, 0b1000011100, 0b111111010010, 
            0b11011101, 0b11001011110, 0b101100010, 0b100010000, 0b110100111100, 0b111011011001, 0b100011010101, 0b110010000100, 0b1101100101, 
            0b1001110100, 0b101011011111, 0b10000111000, 0b111011100101, 0b10000100, 0b10011110100, 0b111000010101, 0b11111010, 0b111100000001, 
            0b11110010010, 0b101111101100, 0b101011001, 0b100110101100, 0b111110011, 0b101110000011, 0b11000101100, 0b10001101011, 
            0b111101000100, 0b1010000110, 0b111101111100, 0b101000110001, 0b10011010011, 0b11111100111, 0b110001011010, 0b111110110011, 
            0b110001011100, 0b110010001011, 0b110101101100, 0b1001011110, 0b110000010101, 0b1100000010, 0b111001010111, 0b101001010010, 
            0b101011101100, 0b110101011, 0b101101101011, 0b111100111011, 0b111111000001, 0b110100101010, 0b10010110101, 0b111101010101, 
            0b11100011, 0b111000100100, 0b101001100, 0b111100001100, 0b110010001111, 0b110010011001, 0b110011111011, 0b100101110010, 
            0b100010010110, 0b111001001000, 0b10010010110, 0b1000000110, 0b111110011010, 0b10100001100, 0b111011011000, 0b111011001110, 
            0b100111010001, 0b100110101000, 0b10100001, 0b101111101001, 0b100001100100, 0b100000100100, 0b10000100000, 0b11111111000, 
            0b111011111101, 0b1011001, 0b1011101, 0b11000011111, 0b111101111000, 0b110000011110, 0b11100110001, 0b101001000001, 0b111000111110, 
            0b110111111101, 0b101010001011, 0b110101011001, 0b1111100000, 0b100100110000, 0b100111000101, 0b111011101111, 0b10000010011, 
            0b100101100111, 0b100000110111, 0b10101011000, 0b111110110101, 0b10000101111, 0b110011001100, 0b11010011011, 0b1100100, 
            0b101110110110, 0b10000101011, 0b110101100001, 0b1011100, 0b100011101, 0b100001000100, 0b11110100001, 0b10111001010, 0b11000110111, 
            0b11010001000, 0b11000111001, 0b10000010000, 0b10001101100, 0b10110111010, 0b10110, 0b101101111001, 0b110000111111, 0b111110010100, 
            0b110110100010, 0b101100001001, 0b1000010011, 0b11101101001, 0b10111011010, 0b1110110001, 0b11110110111, 0b111101100100, 
            0b101011010111, 0b11111011101, 0b10000010101, 0b111101001011, 0b110001000, 0b10110101110, 0b101001100100, 0b101010010010, 
            0b110010010000, 0b101101001011, 0b100110111001, 0b10000000001, 0b111001011, 0b11011101000, 0b110110010100, 0b110011111001, 
            0b101110111010, 0b111010001010, 0b10110010, 0b11000111, 0b101000100111, 0b101000000100, 0b111110100000, 0b110100110011, 
            0b11100010000, 0b100000001010, 0b100000111101, 0b111011010000, 0b1110001, 0b111011000000, 0b110100100100, 0b10001001101, 
            0b11100100100, 0b11000101001, 0b101011010110, 0b1011001101, 0b110100001101, 0b11110001101, 0b1010101110, 0b11001000100, 
            0b11111000, 0b111100001011, 0b1111011001, 0b10100000110, 0b111001101110, 0b1100011000, 0b100001101001, 0b101000101111, 
            0b101100111011, 0b100011111111, 0b11100000100, 0b1000, 0b100100100010, 0b111000110001, 0b1100111110, 0b1110011100, 0b100010010111, 
            0b100001000010, 0b111110100, 0b10001010010, 0b110111001011, 0b10111110101, 0b10110000010, 0b110100010111, 0b11000001110, 
            0b11011011100, 0b110010011010, 0b101010101101, 0b100111011111, 0b111111101101, 0b10001001, 0b110001, 0b100111011, 0b111100110101, 
            0b1011000100, 0b111111110100, 0b11001010111, 0, 0b11100000011, 0b1000100, 0b101000011100, 0b101010011001, 0b101011111000, 
            0b11111001010, 0b111110010101, 0b1010110110, 0b1011110110, 0b110110110001, 0b110100111111, 0b100110000, 0b101000100001, 
            0b1101000011, 0b111110011110, 0b101101100, 0b11111011, 0b100101100110, 0b11101010111, 0b101101000100, 0b110000101110, 
            0b110111111000, 0b101111001011, 0b111001101010, 0b10000110, 0b1011011001, 0b11010110010, 0b10001110100, 0b1011010000, 
            0b101101000011, 0b111111010100, 0b11001110101, 0b11011111000, 0b10101010100, 0b1000101100, 0b111000000010, 0b100000111011, 
            0b100000000100, 0b110, 0b100100111110, 0b11110000110, 0b100111001100, 0b111010111000, 0b1011010011, 0b101100001101, 0b110000001010, 
            0b110101111100, 0b101010111011, 0b1100111101, 0b101100111010, 0b101010000011, 0b11111001100, 0b100011111110, 0b10010011110, 
            0b110001110110, 0b10011011000, 0b1001010100, 0b101110001011, 0b101110101, 0b101000000011, 0b1011011110, 0b101010000100, 
            0b111111111001, 0b101111001010, 0b11010100101, 0b11001001011, 0b110110110101, 0b10000111011, 0b100001010011, 0b10111100000, 
            0b11000010100, 0b1010011110, 0b100101011101, 0b1010000011, 0b111011010010, 0b101111001, 0b11011001000, 0b101000010011, 0b111111001, 
            0b110111010111, 0b1100001011, 0b1111001010, 0b1110100110, 0b101010011100, 0b1100010110, 0b101110111100, 0b10110000011, 0b100101001, 
            0b111111000010, 0b10110110, 0b1111000110, 0b10001011110, 0b101001010, 0b11001100110, 0b101010100000, 0b10110110111, 0b100010110010, 
            0b101100001100, 0b110010000001, 0b101111101011, 0b11100011001, 0b10101000000, 0b101010111010, 0b110101110010, 0b111101100001, 
            0b111000100110, 0b110101001001, 0b110100110100, 0b1110100010, 0b1011011011, 0b111011100110, 0b10100111000, 0b100100100111, 
            0b11000000111, 0b101110111000, 0b11110000011, 0b10011101011, 0b101000001001, 0b11101100100, 0b110110000, 0b10100001010, 
            0b11110010011, 0b101010100110, 0b101100110000, 0b11110000100, 0b111000010111, 0b100100001000, 0b110001001, 0b10000101100, 
            0b10111101100, 0b110101100100, 0b100000111001, 0b10101101001, 0b101000001100, 0b10100110011, 0b100101000111, 0b101001111111, 
            0b110011100, 0b101000110, 0b1101000000, 0b10101011101, 0b110111011100, 0b111010010110, 0b111111000101, 0b100111000110, 
            0b100011001100, 0b11000110100, 0b11011011001, 0b1000010111, 0b100011101110, 0b110011101111, 0b1000110010, 0b110010101110, 
            0b1110011110, 0b10110110100, 0b10011000, 0b11111101000, 0b100000001110, 0b110100101110, 0b1110110111, 0b100110111010, 
            0b101110101011, 0b110000001, 0b10111110100, 0b11111111011, 0b110001100011, 0b101100100, 0b100110011110, 0b11000101010, 
            0b11111100001, 0b111110, 0b10010110110, 0b110101111110, 0b101110011011, 0b101001011000, 0b101010011, 0b11110100000, 0b1100010100, 
            0b11010010, 0b1110100111, 0b11010000000, 0b1011100010, 0b111100011000, 0b100100100001, 0b101010110101, 0b100101010111, 
            0b100010010100, 0b111011011110, 0b100001010101, 0b11111111110, 0b1011001001, 0b100111010101, 0b1000011010, 0b100110111101, 
            0b1111011110, 0b101011100010, 0b10110001111, 0b100000101110, 0b1000000011, 0b111101100010, 0b100110110011, 0b100011001011, 
            0b10101110110, 0b111111000, 0b11110111111, 0b100000010001, 0b11001101101, 0b100111001011, 0b10000111, 0b110000101011, 
            0b10000110101, 0b101010111111, 0b111110001110, 0b111101110001, 0b100100100000, 0b1110110, 0b1101010000, 0b111011100010, 
            0b110001111110, 0b100011001110, 0b1001100001, 0b111111100, 0b100100000, 0b101001, 0b101011000001
        };
    }

    public static class Extensions
    {
        public static IEnumerable<int> FindByBitCommonality(this IEnumerable<int> source, bool byMostCommon, int bit)
        {
            var mask = 0b1 << bit;

            var highBits = source.Where(x => (x & mask) > 0);
            var lowBits = source.Where(x => (x & mask) == 0);
            var highBitCount = highBits.Count();
            var lowBitCount = lowBits.Count();

            if (byMostCommon)
                return (highBitCount >= lowBitCount) ? highBits : lowBits;

            return (highBitCount >= lowBitCount) ? lowBits : highBits;
        }
    }
}
