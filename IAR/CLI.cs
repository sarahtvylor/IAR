using System;

namespace IAR
{
    public class CLI
    {
    
        private string[] args;

        public CLI(string[] args)
        {
            this.args = args;
        }

        public int Run()
        {
            Operation command = null;

            // If user inputs 0 arguments, program usage help should be printed.
            if (args.Length < 1)
            {
                var p = new Program();
                p.readREADME();
                return 1;
            }

            // If user provides validate-json command and one more argument, program should attempt
            // validation against default schema.
            if (args[0].Equals("validate-json") && args.Length == 2)
            {
                command = new ValidateJSON(args[1]);
                return 2;
            }

            // If user provides validate-json command and --input-schema option, program should attempt
            // to validate filepath at args[1] against Schema filepath at args[3]. 
            else if (args[0].Equals("validate-json") && args[2].Equals("--input-schema"))
            {
                try 
                {
                    command = new ValidateJSON(args[1], args[3]);
                    return 3;
                }

                // If user does not provide Schema file path (args[3]), program should handle the 
                // ArrayIndexOutOfBounds exception and provide useful error message to user.
                catch (System.IndexOutOfRangeException e) 
                {
                    throw new System.ArgumentOutOfRangeException("Please provide a file path for the JSON Schema desired.", e);
                }
            }

            // If user provides validate-json command and invalid option, program should indicate to user
            // that the option provided is not recognised.
            else if (args[0].Equals("validate-json") && args[2] != "--input-schema") 
            {
                Console.WriteLine("Unrecognised option: " + args[2]);
                return 4;
            }


            // If user provides and invalid command, program should indicate to user that command is not
            // recgonised.
            else if (command == null)
            {
                Console.WriteLine("Unrecognised command: " + args[0]);
                return 5;
            }

            else
            {
                return command.Execute();
            }
        }
    }
}