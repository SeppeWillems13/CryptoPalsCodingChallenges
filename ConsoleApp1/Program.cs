// See https://aka.ms/new-console-template for more information

using ConsoleApp1;

const string hexString = "49276d206b696c6c696e6720796f757220627261696e206c696b65206120706f69736f6e6f7573206d757368726f6f6d";
const string expectedOutcome = "SSdtIGtpbGxpbmcgeW91ciBicmFpbiBsaWtlIGEgcG9pc29ub3VzIG11c2hyb29t";

var result = HexToBase64.ConvertToHex(hexString);
Console.WriteLine(result == expectedOutcome ? "Success!" : "Failure!");