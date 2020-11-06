using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gentry_linkedListSearch_X1
{
    class LinkedList
    {
        private Node HeadNode;
        private Node TailNode;
        private Node MiddNode;
        private Node CurrentNode;
        private int TotalNodeCount;
        private int TotalMale;
        private int TotalFemale;
        private Node PopularFemale;
        private Node PopularMale;

        public LinkedList()
        {
            HeadNode = null;
            TailNode = null;
        }

        private void AddAtStart(MetaData input)
        {
            if (HeadNode == null)
            {
                Node temp = new Node(input);
                HeadNode = temp;
                TailNode = temp;
                if (temp.GetGender().ToLower() == "m")
                {
                    AddToCount();
                    AddMale();
                    PopularMale = temp;
                }
                else if (temp.GetGender().ToLower() == "f")
                {
                    AddToCount();
                    AddFemale();
                    PopularFemale = temp;
                }
                else
                {
                    AddToCount();
                }
            }
            else if (input.GetName().ToLower().CompareTo(HeadNode.GetName().ToLower()) == -1)
            {
                Node temp = new Node(input);
                temp.Next = HeadNode;
                HeadNode.Previos = temp;
                HeadNode = temp;
                if (input.GetGender().ToLower() == "m")
                {
                    AddToCount();
                    AddMale();
                    SetMidd();
                    if (PopularMale == null) { PopularMale = temp; }
                    else if (PopularMale.GetPopularity() < temp.GetPopularity()) { PopularMale = temp; }
                }
                else if (input.GetGender().ToLower() == "f")
                {
                    AddToCount();
                    AddFemale();
                    SetMidd();
                    if (PopularFemale == null) { PopularFemale = temp; }
                    else if (PopularFemale.GetPopularity() < temp.GetPopularity()) { PopularFemale = temp; }
                }
                else
                {
                    AddToCount();
                    SetMidd();
                }
            }
            //case two where the new node is to be the new tailnode
            else if (input.GetName().ToLower().CompareTo(TailNode.GetName().ToLower()) == 1)
            {
                Node temp = new Node(input);
                temp.Previos = TailNode;
                TailNode.Next = temp;
                TailNode = temp;
                if (input.GetGender().ToLower() == "m")
                {
                    AddToCount();
                    AddMale();
                    SetMidd();
                    SetTail();
                    if (PopularMale == null) { PopularMale = temp; }
                    else if (PopularMale.GetPopularity() < temp.GetPopularity()) { PopularMale = temp; }
                }
                else if (input.GetGender().ToLower() == "f")
                {
                    AddToCount();
                    AddFemale();
                    SetMidd();
                    SetTail();
                    if (PopularFemale == null) { PopularFemale = temp; }
                    else if (PopularFemale.GetPopularity() < temp.GetPopularity()) { PopularFemale = temp; }
                }
                else
                {
                    AddToCount();
                    SetMidd();
                    SetTail();
                }
            }
            else
            {
                CurrentNode = HeadNode;
                while (CurrentNode.GetName().ToLower().CompareTo(input.GetName().ToLower()) != 1)
                {
                    CurrentNode = CurrentNode.Next;
                }
                Node temp = new Node(input);
                //step 1
                temp.Next = CurrentNode;
                //step 2
                CurrentNode = CurrentNode.Previos;
                //step 3
                temp.Previos = CurrentNode;
                //step 4
                CurrentNode.Next = temp;
                // step 5
                CurrentNode = temp.Next;
                //step 6
                CurrentNode.Previos = temp;

                if (input.GetGender().ToLower() == "m")
                {
                    AddToCount();
                    AddMale();
                    SetMidd();
                    SetTail();
                    if (PopularMale == null) { PopularMale = temp; }
                    else if (PopularMale.GetPopularity() < temp.GetPopularity()) { PopularMale = temp; }
                }
                else if (input.GetGender().ToLower() == "f")
                {
                    AddToCount();
                    AddFemale();
                    SetMidd();
                    SetTail();
                    if (PopularFemale == null) { PopularFemale = temp; }
                    else if (PopularFemale.GetPopularity() < temp.GetPopularity()) { PopularFemale = temp; }
                }
                else
                {
                    AddToCount();
                    SetMidd();
                    SetTail();
                }
            }
        }
        //add function for after the data start
        private string AddToList(MetaData input)
        {
            //case one where the new node is to be the new head node
            if (input.GetName().ToLower().CompareTo(HeadNode.GetName().ToLower()) == -1)
            {
                Node temp = new Node(input);
                temp.Next = HeadNode;
                HeadNode.Previos = temp;
                HeadNode = temp;
                if (input.GetGender().ToLower() == "m")
                {
                    AddToCount();
                    AddMale();
                    SetMidd();
                    if (PopularMale.GetPopularity() < temp.GetPopularity()) { PopularMale = temp; }
                    return "Done";
                }
                else if (input.GetGender().ToLower() == "f")
                {
                    AddToCount();
                    AddFemale();
                    SetMidd();
                    if (PopularFemale.GetPopularity() < temp.GetPopularity()) { PopularFemale = temp; }
                    return "Done";
                }
                else
                {
                    AddToCount();
                    SetMidd();
                    return "Done";
                }
            }
            //case two where the new node is to be the new tailnode
            else if (input.GetName().ToLower().CompareTo(TailNode.GetName().ToLower()) == 1)
            {
                Node temp = new Node(input);
                temp.Previos = TailNode;
                TailNode.Next = temp;
                TailNode = temp;
                if (input.GetGender().ToLower() == "m")
                {
                    AddToCount();
                    AddMale();
                    SetMidd();
                    SetTail();
                    if (PopularMale.GetPopularity() < temp.GetPopularity()) { PopularMale = temp; }
                    return "Done";
                }
                else if (input.GetGender().ToLower() == "f")
                {
                    AddToCount();
                    AddFemale();
                    SetMidd();
                    SetTail();
                    if (PopularFemale.GetPopularity() < temp.GetPopularity()) { PopularFemale = temp; }
                    return "Done";
                }
                else
                {
                    AddToCount();
                    SetMidd();
                    SetTail();
                    return "Done";
                }
            }
            //case three check to see if the node already exists
            else
            {
                Node Check = Search(input.GetName());
                if (Check != null)
                {
                    if (Check.GetGender().ToLower() == input.GetGender().ToLower()) { return "error"; }
                    else if (Check.Previos.GetGender().ToLower() == input.GetGender().ToLower() || Check.Next.GetGender().ToLower() == input.GetGender().ToLower()) { return "error"; }
                    //case four to add in the middle of the list in a sorted manner
                    else
                    {
                        CurrentNode = HeadNode;
                        while (CurrentNode.GetName().ToLower().CompareTo(input.GetName().ToLower()) != 1)
                        {
                            CurrentNode = CurrentNode.Next;
                        }
                        Node temp = new Node(input);
                        //step 1
                        temp.Next = CurrentNode;
                        //step 2
                        CurrentNode = CurrentNode.Previos;
                        //step 3
                        temp.Previos = CurrentNode;
                        //step 4
                        CurrentNode.Next = temp;
                        // step 5
                        CurrentNode = temp.Next;
                        //step 6
                        CurrentNode.Previos = temp;

                        if (input.GetGender().ToLower() == "m")
                        {
                            AddToCount();
                            AddMale();
                            SetMidd();
                            SetTail();
                            if (PopularMale.GetPopularity() < temp.GetPopularity()) { PopularMale = temp; }
                            return "Done";
                        }
                        else if (input.GetGender().ToLower() == "f")
                        {
                            AddToCount();
                            AddFemale();
                            SetMidd();
                            SetTail();
                            if (PopularFemale.GetPopularity() < temp.GetPopularity()) { PopularFemale = temp; }
                            return "Done";
                        }
                        else
                        {
                            AddToCount();
                            SetMidd();
                            SetTail();
                            return "Done";
                        }
                    }
                }
                else
                {
                    CurrentNode = HeadNode;
                    while (CurrentNode.GetName().ToLower().CompareTo(input.GetName().ToLower()) != 1)
                    {
                        CurrentNode = CurrentNode.Next;
                    }
                    Node temp = new Node(input);
                    //step 1
                    temp.Next = CurrentNode;
                    //step 2
                    CurrentNode = CurrentNode.Previos;
                    //step 3
                    temp.Previos = CurrentNode;
                    //step 4
                    CurrentNode.Next = temp;
                    // step 5
                    CurrentNode = temp.Next;
                    //step 6
                    CurrentNode.Previos = temp;

                    if (input.GetGender().ToLower() == "m")
                    {
                        AddToCount();
                        AddMale();
                        SetMidd();
                        SetTail();
                        if (PopularMale.GetPopularity() < temp.GetPopularity()) { PopularMale = temp; }
                        return "Done";
                    }
                    else if (input.GetGender().ToLower() == "f")
                    {
                        AddToCount();
                        AddFemale();
                        SetMidd();
                        SetTail();
                        if (PopularFemale.GetPopularity() < temp.GetPopularity()) { PopularFemale = temp; }
                        return "Done";
                    }
                    else
                    {
                        AddToCount();
                        SetMidd();
                        SetTail();
                        return "Done";
                    }
                }
            }
        }

        //search is private so we can minipulat it in the class before sending the results to the UI
        //assume that the mid and tail node have been set and that we have a list due to the fact that we inport the list
        private Node Search(string input)
        {
            string SearchTerm = input.ToLower();
            //first check to see if the value is within the realm of the list
            if (SearchTerm.CompareTo(HeadNode.GetName().ToLower()) == -1 || SearchTerm.CompareTo(TailNode.GetName().ToLower()) == 1) { return null; }
            //next check the MiddNode
            if (SearchTerm.CompareTo(MiddNode.GetName().ToLower()) == 0) { return MiddNode; }
            //see if the search is less then MiddNode to search the top half of the list
            else if (SearchTerm.CompareTo(MiddNode.GetName().ToLower()) == -1)
            {
                CurrentNode = HeadNode;
                while (CurrentNode.GetName().ToLower().CompareTo(SearchTerm) != 1)
                {
                    for (int i = 0; i <= 10; i++)
                    {
                        CurrentNode = CurrentNode.Next;
                    }
                }
                for (int i = 0; i <= 10; i++)
                {
                    if (CurrentNode.GetName().ToLower().CompareTo(SearchTerm) == 0) { return CurrentNode; }
                    else { CurrentNode = CurrentNode.Previos; }
                }
                return null;
            }
            //search the bottome half of the list
            else
            {
                CurrentNode = TailNode;
                while (CurrentNode.GetName().ToLower().CompareTo(SearchTerm) != -1)
                {
                    for (int i = 0; i <= 10; i++)
                    {
                        CurrentNode = CurrentNode.Previos;
                    }
                }
                for (int i = 0; i <= 10; i++)
                {
                    if (CurrentNode.GetName().ToLower().CompareTo(SearchTerm) == 0) { return CurrentNode; }
                    else { CurrentNode = CurrentNode.Next; }
                }
                return null;
            }
        }

        //setters for midd and tail
        private void SetMidd()
        {
            CurrentNode = HeadNode;
            for (int i = (TotalNodeCount / 2); i >= 0; i--)
            {
                CurrentNode = CurrentNode.Next;
            }
            MiddNode = CurrentNode;
            CurrentNode = HeadNode;
        }
        private void SetTail()
        {
            CurrentNode = HeadNode;
            while (CurrentNode.Next != null)
            {
                CurrentNode = CurrentNode.Next;
            }
            TailNode = CurrentNode;
            CurrentNode = HeadNode;
        }

        //methods to help keep count of the total and the male and female counts
        private void AddToCount()
        {
            TotalNodeCount++;
        }
        private void AddFemale()
        {
            TotalFemale++;
        }
        private void AddMale()
        {
            TotalMale++;
        }

        //methods to return the needed data to the UI
        public string getTotal()
        {
            return TotalNodeCount.ToString();
        }
        public string getMale()
        {
            return TotalMale.ToString();
        }
        public string getFemale()
        {
            return TotalFemale.ToString();
        }
        public string getPopulerMale()
        {
            return "Name: " + PopularMale.GetName() + " Gender: " + PopularMale.GetGender() + " Populality: " + PopularMale.GetPopularity().ToString() + ".";
        }
        public string getPopulerFemale()
        {
            return "Name: " + PopularFemale.GetName() + " Gender: " + PopularFemale.GetGender() + " Populality: " + PopularFemale.GetPopularity().ToString() + ".";
        }
        public string SearchList(string input)
        {
            Node results = Search(input);
            if (results == null)
            {
                return "No results found for that name.";
            }
            else
            {
                return "Name: " + results.GetName() + " Gender: " + results.GetGender() + " Populality: " + results.GetPopularity().ToString() + ".";
            }
        }
        public string AddToList(string Name, String Gender, int popularity)
        {
            MetaData input = new MetaData(Name, Gender, popularity);
            return AddToList(input);
        }
        public void Start()
        {
            string line;
            //not sure if it will transfer but the data is in the data folder and I think i linked it
            System.IO.StreamReader file = new System.IO.StreamReader(@"Data.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] elements = line.Split(',');
                MetaData temp = new MetaData(elements[0], elements[1], int.Parse(elements[2]));
                AddAtStart(temp);
            }
        }
    }
}
