using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            File.ReadAllLines(args[0]);
        }
    }
}


public class given_an_input_pipe
{
    protected readonly InputPipe sut;

    [Fact]
    public void when_reading_from_well_formed_file_then_enumerate()
    {
        var reader = new StringReader("2,30");
        reader.ReadLineAsync();
        foreach (var item in InputPipe.FromReader(reader)) ;
    }
}

