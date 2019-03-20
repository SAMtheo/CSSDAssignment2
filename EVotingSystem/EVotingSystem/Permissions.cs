using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVotingSystem
{
    public class Permissions
    {
        /// <summary>
        /// Expose types of Admin 
        /// Not being able to create variable admins will keep powers undercheck
        /// </summary>
        public readonly static Dictionary<string, Permissions> ADMIN_TYPE = new Dictionary<string, Permissions>()
        {
            {"Super",  new Permissions(true, true, true, true, true) },
            {"OnSite", new Permissions(false, true, true, true, true)},
            {"AuthReseter", new Permissions(false,true,true,false,false) },
            {"Auditor",new Permissions(true,false, false, false, false)},
            {"None",new Permissions(false,false, false, false, false)},
            {"Test", new Permissions(false,true,false,false, false)}
        };

        // Auditor permissions
        public readonly bool seeResults;

        // onsite permissions
        public readonly bool seeLocals;
        public readonly bool resetAuthAttempts;
        public readonly bool seeEligabilty;
        public readonly bool setEligabilty;

        /// <summary>
        /// Private constructor
        /// 
        /// </summary>
        /// <param name="seeResults"></param>
        /// <param name="seeLocals"></param>
        /// <param name="resetAuthAttempts"></param>
        /// <param name="seeEligabilty"></param>
        /// <param name="setEligabilty"></param>
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
