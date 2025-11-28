using System;
using System.Collections.Generic;

/*
v1.0.2

PROGRAM MAIN

WRITTEN BY ASHAR 
*/
public class Program{
	
    public static void Main(){
        Console.WriteLine("Welcome to Cipher Libray");
        Console.WriteLine("Enter a string to encode (type 'stop' to exit):");
        String v1 = Console.ReadLine();
        while (string.IsNullOrEmpty(v1)){
            Console.WriteLine("Input cannot be empty. Please enter a valid string:");
            v1 = Console.ReadLine();
        }
        while(v1 != "stop"){
            EncodeAll(v1);
            Console.WriteLine("Enter another string to encode or type 'stop' to exit:");
            v1 = Console.ReadLine();
        }

        // Example usage of NumberCipher
        Console.WriteLine("\nNumber Cipher Examples:");
        int number = 2006;
        string roman = NumberCipher.Roman_Encode(number);
        Console.WriteLine($"Roman Encode of {number}: {roman}");
        int decodedNumber = NumberCipher.Roman_Decode(roman);
        Console.WriteLine($"Roman Decode of {roman}: {decodedNumber}");

    }

    /// Encode all Ciphers
    public static void EncodeAll(string text){
        Console.WriteLine("A1Z26: " + Cipher.A1Z26_Encode(text));
        Console.WriteLine("ATBASH: " + Cipher.Atbash(text));
        Console.WriteLine("BINARY: " + Cipher.Binary_Encode(text));
        Console.WriteLine("BRAILLE: " + Cipher.Braille_Encode(text));
        Console.WriteLine("CAESAR (shift 3): " + Cipher.Caesar_Encode(text, 3));
        Console.WriteLine("COLUMNAR (key reverses): " + Cipher.Columnar_Encode(text, "EDCBA"));
        Console.WriteLine("MORSE: " + Cipher.Morse_Encode(text));
        Console.WriteLine("PHONE: " + Cipher.Phone_Encode(text));
    }
    

}
