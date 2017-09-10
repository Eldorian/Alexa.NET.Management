﻿using Alexa.NET.Management.InteractionModel;

namespace Alexa.NET.Management
{
    public class SkillInteraction
    {
        public Language Language { get; set; }

        public Dialog Dialog { get; set; }

        public Prompt[] Prompts { get; set; }
    }
}
