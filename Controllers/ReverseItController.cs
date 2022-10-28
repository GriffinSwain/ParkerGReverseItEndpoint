//Griffin Parker
//October 26, 2022
//Reverse It - Endpoint
//This program gives the user information on how to run the program, takes in a user's input through the URL and reverse the characters in their input
//Peer Review: Samuel Laguna: I ran the code it works good. I reverses how it is supposed to do. All the inputs work correctly. this code is all good.
//Instructions: https://localhost:xxxx/reverseit
//Full program: https://localhost:xxxx/reverseit/reverse/{input}

using Microsoft.AspNetCore.Mvc;
namespace ParkerGReverseItEndpoint.Controllers;

[ApiController]
[Route("[controller]")]

public class ReverseItController : ControllerBase
{
public string Instructions()
{
    return " To run this program, type \n\n https://localhost:xxxx/reverseit/reverse/{input} \n\n Be sure to change the 'xxxx' to where your system is hosting it locally, and change {input} to what you want to be reversed";
}

    [HttpGet]
    [Route("Reverse/{input}")]
    public string ReverseIt(string input)
    {
    string reverse = ""; 
    for(int i = input.Length - 1; i >= 0; i--) reverse = reverse + input[i];
    return $"{input} backwards is {reverse}";
    }
}
