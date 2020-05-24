﻿using System;
using System.Collections.Generic;
using PokerCardsShared.Models;

namespace PokerCardsShared.Services
{
    public interface IVotingService
    {
        public string StoryName { get; set; }
        public List<SizeVote> StorySizeVotes { get; }
        public bool ShowVotes { get; }
        public event Action OnChange;
        public void AddStorySizeVotes(SizeVote vote);
        public void ClearStorySizeVotes();
        public void UpdateStoryName(string name);
        public void RevealVotes();
    }
}