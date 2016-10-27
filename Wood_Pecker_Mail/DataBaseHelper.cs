using System;
using Microsoft.AspNet.Identity;


namespace Wood_Pecker_Mail
{
    public class DataBaseHelper
    {
        private static int counter = 0;

        public static MessagesDB[] getInbox()
        {
            MessagesDB[] wholeInbox = new MessagesDB[4];

            //Magic Happenes Here with the Database
            //-Side Note as I just came back from a car accident down the street
            //No one was hurt but I help direct traffic for an half an hour waiting 
            //the a cop.  I was not in the accident I just heard the crash and ran over
            int[] id = { 1, 46, 48, 999 };
            string[] from = {"Pablo","Leonardo da Vinci", "Frida Kahlo", "Edward Hopper" };
            string[] subject = { "Spanish Paintings", "Renaissance Man", "Dear Diego", "French and Russian Culture" };
            string[] body = {"Spanish paintings have lots of bulls hitting people","Math and art will rule the World", "Truth is, so great, that I wouldn’t like to speak, or sleep, or listen, or love. To feel myself trapped, with no fear of blood, outside time and magic, within your own fear, and your great anguish, and within the very beating of your heart. All this madness, if I asked it of you, I know, in your silence, there would be only confusion. I ask you for violence, in the nonsense, and you, you give me grace, your light and your warmth. I’d like to paint you, but there are no colors, because there are so many, in my confusion, the tangible form of my great love.", " The French and Russian don't get along ever since Napoleon invaded Mother Russia" };
            int[] time = { 1000195200, 707299200 , 1478592000 , 499161600 };
            bool[] hasRead = {true, false,true, false };
            for(int i = 0 ; i < wholeInbox.Length ; i++)
            {

                wholeInbox[i] = populate(id[i],from[i],subject[i],body[i],time[i],hasRead[i]);
            }

            return wholeInbox;
        }

        private static MessagesDB populate(int id, string fromUser, string subjectLine, string bodyOfMessage, int timeStamp, bool read)
        {
            //(int id, int toUserId, string fromUser, string subjectLine, string bodyOfMessage, int timeStamp, bool Read)
            return new MessagesDB(id, fromUser, subjectLine, bodyOfMessage, timeStamp, read);
        }

    }

    public class MessagesDB
    {
        private int id;//Primary Key for the messages
        private string fromUser;//foreign key to user database
        private string subjectLine;
        private string bodyOfMessage;
        private int timeStamp;//Unix time stamp of when the message was sent
        private bool Read;//was the message read yet?

        public MessagesDB(int id, string fromUser, string subjectLine, string bodyOfMessage, int timeStamp, bool Read)
        {
            this.id = id;
            this.fromUser = fromUser;
            this.subjectLine = subjectLine;
            this.bodyOfMessage = bodyOfMessage;
            this.timeStamp = timeStamp;
            this.Read = Read;
        }

        public int getId()
        {
            return this.id;
        }

        public string getfromUser()
        {
            return this.fromUser;
        }
        public string getSubjectLine()
        {
            return this.subjectLine;
        }
        public string getBodyOfMessage()
        {
            return this.bodyOfMessage;
        }
        public int getTimeStamp()
        {
            return this.timeStamp;
        }
        public bool isRead()
        {
            return this.Read;
        }
    }
}

