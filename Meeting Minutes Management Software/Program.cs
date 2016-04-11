using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Meeting_Minutes_Management_Software
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> teamMember = new Dictionary<string, string>();
            teamMember.Add("Dan Duddly", "Marketing");
            teamMember.Add("Barb Baker", "Marketing");
            teamMember.Add("Carl Cramp", "Marketing");
            teamMember.Add("Leslie LaDumf", "Administration");
            teamMember.Add("Pete Pouline", "Administration");
            teamMember.Add("John Johnson", "Administration");

            
            List<string> meetingType = new List<string>();
            meetingType.Add("1. Marketing Team");
            meetingType.Add("2. Administration Team");
            meetingType.Add("3. All Team");

            Console.WriteLine("Meeting Minutes Management Software");
            Console.WriteLine("*************************************");
            Console.WriteLine("1. Create Meeting\n2. View Team\n3. Exit");
            Console.WriteLine("*************************************");
            string userMenu = Console.ReadLine();
            switch (userMenu)
            {
                case "1":
                    Console.WriteLine("Create Meeting");
                    Console.WriteLine("Please enter the date of this meeting: MMDDYY");
                    int dateMeeting = int.Parse(Console.ReadLine());
                    StreamWriter writer = new StreamWriter("Minutes" + dateMeeting + ".txt");
                    using (writer)
                    {
                        writer.WriteLine("Julie's Company\r\n1012 Professor Road\r\nCleveland, Ohio 44124");
                        writer.WriteLine("*************************************");
                        Console.WriteLine("*************************************");
                        Console.WriteLine("Please enter name of team member recording minutes");
                        string nameMinutes = Console.ReadLine();
                        writer.WriteLine("Team member recording minutes: " + nameMinutes);
                        Console.WriteLine("Please enter name of team member leading the meeting");
                        string nameLeader = Console.ReadLine();
                        writer.WriteLine("Team member leading the meeting: " + nameLeader);
                        writer.WriteLine("*************************************");
                        Console.WriteLine("*************************************");
                        Console.WriteLine("What Department Meeting is this?");
                        foreach( string meetingList in meetingType)
                        {
                            Console.WriteLine(meetingList);
                        }
                        
                        string meetingChoice = Console.ReadLine();
                        switch (meetingChoice)
                        {
                            case "1":
                                writer.WriteLine("Marketing Team");
                                writer.WriteLine("*************************************");
                                Console.WriteLine("What is the topic of the meeting?");
                                string topic = Console.ReadLine();
                                writer.WriteLine("Meeting topic is: " + topic);
                                Console.WriteLine("Enter meeting notes here:");
                                string notes = Console.ReadLine();
                                writer.WriteLine("Notes Taken: " + notes);
                                string notes2 ="";
                                do
                                {
                                    Console.WriteLine("Would you like to add new notes on a new topic? Y/N");
                                    notes2 = Console.ReadLine();
                                    notes2 = notes2.ToUpper();

                                    if (notes2 == "Y")
                                    {
                                        Console.WriteLine("What is your new topic?");
                                        string newTopic = Console.ReadLine();
                                        writer.WriteLine("Added Topic: " + newTopic);
                                        Console.WriteLine("Enter meeting notes here:");
                                        string newNotes = Console.ReadLine();
                                        writer.WriteLine("Added Notes: " + newNotes);
                                    }
                                    
                                }
                                while (notes2 == "Y");

                                    Console.WriteLine("All text has been written to file");
                                 
                                  
                                break;

                            case "2":
                                writer.WriteLine("Administration Team");
                                writer.WriteLine("*************************************");
                                Console.WriteLine("What is the topic of the meeting?");
                                string adminTopic = Console.ReadLine();
                                writer.WriteLine("The Meeting Topic Is: " + adminTopic);
                                Console.WriteLine("Enter meeting notes here");
                                string AdminNotes = Console.ReadLine();
                                writer.WriteLine("Meeting Notes Taken: " + AdminNotes);

                                string adminNotes2 = "";
                                do
                                {
                                    Console.WriteLine("Would you like to add new notes on a new topic? Y/N");
                                    adminNotes2 = Console.ReadLine();
                                    adminNotes2 = adminNotes2.ToUpper();

                                    if (adminNotes2 == "Y")
                                    {
                                        Console.WriteLine("What is your new topic?");
                                        string newAdminTopic = Console.ReadLine();
                                        writer.WriteLine("Added Topic: " + newAdminTopic);
                                        Console.WriteLine("Please enter meeting notes here:");
                                        string newAdminNotes = Console.ReadLine();
                                        writer.WriteLine("Added Notes: " + newAdminNotes);
                                    }

                                }
                                while (adminNotes2 == "Y");
                                    Console.WriteLine("All text has been written to file");
                                
                                break;

                            case "3":
                                writer.WriteLine("All Team");
                                writer.WriteLine("*************************************");
                                Console.WriteLine("What is the topic of the meeting?");
                                string allTopic = Console.ReadLine();
                                writer.WriteLine("The meeting topic is: " + allTopic);
                                Console.WriteLine("Enter meeting notes here:");
                                string allNotes = Console.ReadLine();
                                writer.WriteLine("Meeting notes taken: " + allNotes);
                                string allNotes2 = "";
                                do
                                {
                                    Console.WriteLine("Would you like to add new notes on a new topic? Y/N");
                                    allNotes2 = Console.ReadLine();
                                    allNotes2 = allNotes2.ToUpper();
                                    if (allNotes2 == "Y")
                                    {
                                        Console.WriteLine("What is your new topic?");
                                        string newAllTopic = Console.ReadLine();
                                        writer.WriteLine("Added Topic: " + newAllTopic);
                                        Console.WriteLine("Please add notes here");
                                        string newAllNotes = Console.ReadLine();
                                        writer.WriteLine("Added Notes: " + newAllNotes);
                                    }
                                }
                                while (allNotes2 == "Y");

                                    Console.WriteLine("All text has been written to file");
                                
                                break;
                        }
                        break;
                    }
                case "2":
                    Console.WriteLine("View Team");
                    Console.WriteLine("Which team would you like to view?");
                    foreach(string teamList in meetingType)
                    {
                        Console.WriteLine(teamList);
                    }
                    string userTeamView = Console.ReadLine();
                    switch (userTeamView)
                    {
                        case "1":
  
                                foreach(KeyValuePair<string,string>printMarketing in teamMember)
                                {
                                    if (printMarketing.Value == "Marketing")
                                    {
                                    Console.WriteLine(printMarketing.Key);
                                    }                                   
                                }                          
                            break; 
                                               
                        case "2":
                            foreach (KeyValuePair<string, string> printAdmin in teamMember)
                            {
                                if (printAdmin.Value == "Administration")
                                {
                                    Console.WriteLine(printAdmin.Key);
                                }
                            }
                            break;

                        case "3":
                            foreach(KeyValuePair<string,string>printChoice in teamMember)
                            {
                                Console.WriteLine(printChoice.Key + " ("+ printChoice.Value+")");
                            }
                            break;
                    }
                    break;
                case "3":
                    Console.WriteLine("Goodbye");
                    break;
            
            }                    
                              
        }  
    }
}
