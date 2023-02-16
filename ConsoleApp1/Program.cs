// See https://aka.ms/new-console-template for more information

using ConsoleApp1;
using ConsoleApp1.Set_1.Challenge_2;

//Set 1 - Challenge 1 - Convert hex to base64
const string hexString = "49276d206b696c6c696e6720796f757220627261696e206c696b65206120706f69736f6e6f7573206d757368726f6f6d";
const string expectedOutcome = "SSdtIGtpbGxpbmcgeW91ciBicmFpbiBsaWtlIGEgcG9pc29ub3VzIG11c2hyb29t";

var result = HexToBase64.ConvertToHex(hexString);
Console.Write("Set 1 - Challenge 1 - Convert hex to base64: ");
Console.WriteLine(result == expectedOutcome ? "Success!" : "Failure!");

//Set 1 - Challenge 2 - Write a function that takes two equal-length buffers and produces their XOR combination.
const string feederString = "1c0111001f010100061a024b53535009181c";
const string xorString = "686974207468652062756c6c277320657965";
const string expectedXorOutcome = "746865206b696420646f6e277420706c6179";

var xorResult = FixedXor.Xor(feederString, xorString).ToLower();

Console.Write("Set 1 - Challenge 2 - Convert hex to base64: ");
Console.WriteLine(xorResult == expectedXorOutcome ? "Success!" : "Failure!");
