﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primitives
{
    public class Json_To_Class
    {

        public string jsonstr { get; set; }

        public Json_To_Class()
        {
            jsonstr  = "{\"main\": {\"name\":\"Nordic - Giant Project\",\"description\":\"I am a web development engineer and I use react and python to develop pages.This project is a resume template that can be used as the project home page or resume page\",\"image\":\"profilepic.jpg\",\"bio\":\"Use this bio section as your way of describing yourself and saying what you do, what technologies you like to use or feel most comfortable with, describing your personality, or whatever else you feel like throwing in.\",\"contactmessage\":\"Here is where you should write your message to readers to have them get in contact with you.\",\"email\": \"youremailhere @gmail.com\",\"phone\": \"555 - 555 - 5555\",\"github\":\"https://github.com/nordicgiant2/react-nice-resume\",\"project\":\"https://github.com/nordicgiant2/react-nice-resume\",\"address\":{\"street\":\"(Your Street)\",\"city\":\"(Your City)\",\"state\":\"(Your State)\",\"zip\": \"(Your Zip/Postal Code)\"},\"website\": \"http://www.timbakerdev.com\",\"resumedownload\":\"http://timbakerdev.com\",\"social\":[{\"name\":\"facebook\",\"url\":\"https://github.com/nordicgiant2/react-nice-resume\",\"className\":\"fa fa-facebook\"},{\"name\":\"twitter\",\"url\":\"http://twitter.com\",\"className\":\"fa fa-twitter\"},{\"name\":\"linkedin\",\"url\":\"https://www.linkedin.com/in/tim-baker-8420009a/\",\"className\":\"fa fa-linkedin\"},{\"name\":\"instagram\",\"url\":\"http://instagram.com/tbaker_x\",\"className\":\"fa fa-instagram\"},{\"name\":\"github\",\"url\":\"https://github.com/nordicgiant2/react-nice-resume\",\"className\":\"fa fa-github\"}]},\"resume\":{\"skillmessage\":\"Here you can create a short write-up of your skills to show off to employers\",\"education\":[{\"school\":\"University?\",\"degree\":\"Masters in Beer tasting\",\"graduated\":\"April 2007\",\"description\":\"Describe your experience at school, what you learned, what useful skills you have acquired etc.\"},{\"school\":\"School #1 Maybe College?\",\"degree\":\"What did you study 101\",\"graduated\":\"March 2003\",\"description\":\"Describe your experience at school, what you learned, what useful skills you have acquired etc.\"}],\"work\":[{\"company\":\"Awesome Design Studio\",\"title\":\"Senior UX God \",\"years\":\"March 2010 - Present\",\"description\":\"Describe work, special projects, notable achievements, what technologies you have been working with, and anything else that would be useful for an employer to know.\"},{\"company\":\"Super Cool Studio\",\"title\":\"Junior bug fixer\",\"years\":\"March 2007 - February 2010\",\"description\":\"Describe work, special projects, notable achievements, what technologies you have been working with, and anything else that would be useful for an employer to know.\"}],\"skills\":[{\"name\":\"Python\",\"level\":\"60%\"},{\"name\":\"VueJs\",\"level\":\"55%\"},{\"name\":\"ReactJs\",\"level\":\"50%\"},{\"name\":\"CSS\",\"level\":\"90%\"},{\"name\":\"PHP\",\"level\":\"80%\"},{\"name\":\"Swift\",\"level\":\"50%\"},{\"name\":\"JAVA\",\"level\":\"80%\"}]},\"portfolio\":{\"projects\": [{\"title\":\"Canadian Wanderlust\",\"category\":\"My Travel Blog for my post-university travels\",\"image\":\"canadian-wanderlust.jpg\",\"url\":\"https://www.canadianwanderlust.com\"},{\"title\":\"Fury Fighting Gear\",\"category\":\"(offline now) A fighting gear company I started\",\"image\":\"fury-fighting-gear.jpg\",\"url\":\"http://www.timbakerdev.com\"},{\"title\":\"Original Thai Food\",\"category\":\"Website I built for a restaurant I like in Thailand\",\"image\":\"original-thai-food.jpg\",\"url\":\"http://www.timbakerdev.com/originalthaifood.github.io\"},{\"title\":\"Resume Website\",\"category\":\"A React based resume website template\",\"image\":\"resume-website.jpg\",\"url\":\"http://www.timbakerdev.com\"},{\"title\":\"Smirkspace\",\"category\":\"(MVP Only) A React and Meteor based chat University project.\",\"image\":\"smirkspace.jpg\",\"url\":\"http://www.smirkspace.com\"}]}}";


        }

        public string get() 
        {
            return jsonstr;
        }

        public string get2()
        {
            jsonstr = "{\"main\": {\"name\":\"Nordic - Giant Project\",\"description\":\"I am a web development engineer and I use react and python to develop pages.This project is a resume template that can be used as the project home page or resume page\",\"image\":\"profilepic.jpg\",\"bio\":\"Use this bio section as your way of describing yourself and saying what you do, what technologies you like to use or feel most comfortable with, describing your personality, or whatever else you feel like throwing in.\",\"contactmessage\":\"Here is where you should write your message to readers to have them get in contact with you.\",\"email\": \"youremailhere @gmail.com\",\"phone\": \"555 - 555 - 5555\",\"github\":\"https://github.com/nordicgiant2/react-nice-resume\",\"project\":\"https://github.com/nordicgiant2/react-nice-resume\",\"address\":{\"street\":\"(Your Street)\",\"city\":\"(Your City)\",\"state\":\"(Your State)\",\"zip\": \"(Your Zip/Postal Code)\"},\"website\": \"http://www.timbakerdev.com\",\"resumedownload\":\"http://timbakerdev.com\",\"social\":[{\"name\":\"facebook\",\"url\":\"https://github.com/nordicgiant2/react-nice-resume\",\"className\":\"fa fa-facebook\"},{\"name\":\"twitter\",\"url\":\"http://twitter.com\",\"className\":\"fa fa-twitter\"},{\"name\":\"linkedin\",\"url\":\"https://www.linkedin.com/in/tim-baker-8420009a/\",\"className\":\"fa fa-linkedin\"},{\"name\":\"instagram\",\"url\":\"http://instagram.com/tbaker_x\",\"className\":\"fa fa-instagram\"},{\"name\":\"github\",\"url\":\"https://github.com/nordicgiant2/react-nice-resume\",\"className\":\"fa fa-github\"}]},\"resumes\":{\"skillmessage\":\"Here you can create a short write-up of your skills to show off to employers\",\"education\":[{\"school\":\"University?\",\"degree\":\"Masters in Beer tasting\",\"graduated\":\"April 2007\",\"description\":\"Describe your experience at school, what you learned, what useful skills you have acquired etc.\"},{\"school\":\"School #1 Maybe College?\",\"degree\":\"What did you study 101\",\"graduated\":\"March 2003\",\"description\":\"Describe your experience at school, what you learned, what useful skills you have acquired etc.\"}],\"work\":[{\"company\":\"Awesome Design Studio\",\"title\":\"Senior UX God \",\"years\":\"March 2010 - Present\",\"description\":\"Describe work, special projects, notable achievements, what technologies you have been working with, and anything else that would be useful for an employer to know.\"},{\"company\":\"Super Cool Studio\",\"title\":\"Junior bug fixer\",\"years\":\"March 2007 - February 2010\",\"description\":\"Describe work, special projects, notable achievements, what technologies you have been working with, and anything else that would be useful for an employer to know.\"}],\"skills\":[{\"name\":\"Python\",\"level\":\"60%\"},{\"name\":\"VueJs\",\"level\":\"55%\"},{\"name\":\"ReactJs\",\"level\":\"50%\"},{\"name\":\"CSS\",\"level\":\"90%\"},{\"name\":\"PHP\",\"level\":\"80%\"},{\"name\":\"Swift\",\"level\":\"50%\"},{\"name\":\"JAVA\",\"level\":\"80%\"}]},\"portfolio\":{\"projects\": [{\"title\":\"Canadian Wanderlust\",\"category\":\"My Travel Blog for my post-university travels\",\"image\":\"canadian-wanderlust.jpg\",\"url\":\"https://www.canadianwanderlust.com\"},{\"title\":\"Fury Fighting Gear\",\"category\":\"(offline now) A fighting gear company I started\",\"image\":\"fury-fighting-gear.jpg\",\"url\":\"http://www.timbakerdev.com\"},{\"title\":\"Original Thai Food\",\"category\":\"Website I built for a restaurant I like in Thailand\",\"image\":\"original-thai-food.jpg\",\"url\":\"http://www.timbakerdev.com/originalthaifood.github.io\"},{\"title\":\"Resume Website\",\"category\":\"A React based resume website template\",\"image\":\"resume-website.jpg\",\"url\":\"http://www.timbakerdev.com\"},{\"title\":\"Smirkspace\",\"category\":\"(MVP Only) A React and Meteor based chat University project.\",\"image\":\"smirkspace.jpg\",\"url\":\"http://www.smirkspace.com\"}]}}";

            return jsonstr;
        }


    }


    public class Address
    {
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
    }

    public class Social
    {
        public string name { get; set; }
        public string url { get; set; }
        public string className { get; set; }
    }

    public class Main
    {
        public string name { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public string bio { get; set; }
        public string contactmessage { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string github { get; set; }
        public string project { get; set; }
        public Address address { get; set; }
        public string website { get; set; }
        public string resumedownload { get; set; }
        public List<Social> social { get; set; }
    }

    public class Education
    {
        public string school { get; set; }
        public string degree { get; set; }
        public string graduated { get; set; }
        public string description { get; set; }
    }

    public class Work
    {
        public string company { get; set; }
        public string title { get; set; }
        public string years { get; set; }
        public string description { get; set; }
    }

    public class Skill
    {
        public string name { get; set; }
        public string level { get; set; }
    }

    public class Resume
    {
        public string skillmessage { get; set; }
        public List<Education> education { get; set; }
        public List<Work> work { get; set; }
        public List<Skill> skills { get; set; }
    }

    public class Project
    {
        public string title { get; set; }
        public string category { get; set; }
        public string image { get; set; }
        public string url { get; set; }
    }

    public class Portfolio
    {
        public List<Project> projects { get; set; }
    }

    public class Root
    {
        public Main main { get; set; }
        public Resume resume { get; set; }
        public Portfolio portfolio { get; set; }
    }
}
