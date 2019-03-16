﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVotingSystem
{
    public class Permissions
    {
        // Lookup for types of admin 
        public readonly static Dictionary<string, Permissions> ADMIN_TYPE = new Dictionary<string, Permissions>()
        {
            {"Super",  new Permissions(true, true, true, true, true) },
            {"OnSite", new Permissions(false, true, true, true, true)},
            {"Auditor",new Permissions(true,false, false, false, false)},
            {"None",new Permissions(false,false, false, false, false)},
        };

        // Auditor permissions
        public readonly bool seeResults;

        // onsite permissions
        public readonly bool seeLocals;
        public readonly bool resetAuthAttempts;
        public readonly bool seeEligabilty;
        public readonly bool setEligabilty;

        // The list of bools is bad - how would we do better?
        private Permissions(bool seeResults, bool seeLocals, bool resetAuthAttempts, bool seeEligabilty, bool setEligabilty)
        {
            this.seeResults = seeResults;
            this.seeLocals = seeLocals;
            this.resetAuthAttempts = resetAuthAttempts;
            this.seeEligabilty = seeEligabilty;
            this.setEligabilty = setEligabilty;
        }


    }

}
