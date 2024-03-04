using LinkedListLearning;


namespace LinkeListLearning
{
    class LinkeListLearning
    {
        public static void Main(string[] args)
        {
            string[] words = { "the", "fox", "jumps", "over", "the", "dog" };

            // Create LinkeListe
            LinkedList<string> Sentence = new LinkedList<string>(words);

            // Loop for take inpute from user.
            bool quit = false;
            while (!quit)
            {
                UserInputForOperation userInputForOperationobj = new UserInputForOperation();
                string UserInputModule = userInputForOperationobj.UserInput();
                
                switch (UserInputModule)
                {
                    case "show":
                        LinkeListLearningnew linkeListLearningnewobj = new LinkeListLearningnew();
                        linkeListLearningnewobj.Display(Sentence);

                        Console.WriteLine(Sentence.FindLast("the"));
                        break;
                    case "aeb":
                        // Add Word Beginning of LinkedList
                        AddWordBeginningLinkedList addWordBeginningLinkedListobj = new AddWordBeginningLinkedList();
                        addWordBeginningLinkedListobj.AddWordBeginning(Sentence);
                        break;
                    case "reb":
                        // Remove Word Beginning of LinkedList
                        RemoveWordBeginningLinkedList removeWordBeginningLinkedListobj = new RemoveWordBeginningLinkedList();
                        removeWordBeginningLinkedListobj.RemoveWordBeginning(Sentence);
                        break;
                    case "ael":
                        // Add Word Last of LinkedList
                        AddWordLastLinkedList addWordLAstLinkedListobj = new AddWordLastLinkedList();
                        addWordLAstLinkedListobj.AddWordLast(Sentence);
                        break;
                    case "rel":
                        // Remove Word Last of LinkedList
                        RemoveWordLastLinkedList removeWordLastLinkedListobj = new RemoveWordLastLinkedList();
                        removeWordLastLinkedListobj.RemoveWordLast(Sentence);
                        break;
                    case "mfl":
                        // Move the first node to be the last node.
                        MoveFirstNodeToLastNode moveFirstNodeToLastNodeobj = new MoveFirstNodeToLastNode();
                        moveFirstNodeToLastNodeobj.MoveFirstToLast(Sentence);
                        break;
                    case "mlf":
                        MoveLastNodeToFirstNode moveLastNodeToFirstNodeobj = new MoveLastNodeToFirstNode();
                        moveLastNodeToFirstNodeobj.MoveLastToFirst(Sentence);
                        break;
                    case "quit":
                        quit = true;
                        break;
                    // Invalid Inpute.
                    default:
                        Console.WriteLine("Enter Valid Inpute");
                        break;
                }
            }            
        }
    }
}