using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveManagementSystem
{
    class Queen
    {
        //Declare Fields

        public static Worker[] workers { get; set; }
        private static int shiftNumber { get; set; }

        //Setup Object Constructor 

        public Queen(Worker[] Workers)
        {
            workers = Workers; 
        }

        //Declare Methods

        public bool AssignWork(string job, int numberOfShifts)
        {

            foreach (Worker bee in workers)
            {
                if (String.IsNullOrEmpty(bee.CurrentJob))
                {
                    bool doableJob = bee.DoThisJob(job, numberOfShifts);
                    if(doableJob == true)
                         return true;

                }

            }
            return false;
        }

// Hooks into the forms "work the next shift button". Tells each worker object to work one shift
// and then checks the status so that it can add a line to the shift report. 
      
        public static string WorkTheNextShift()
        {
 
            shiftNumber++;
             string report;

            report = String.Format("Report for shift# {0} \r\n " , shiftNumber);
            foreach (Worker bee in workers)
            {
                int index = Array.IndexOf(workers, bee);
                bee.DidYouFinish(bee);
                if (bee.DidYouFinish(bee) == false)
                {
                    // update status report that bee is still working
                    // and how many shifts are left. Include which bee
                    // it is we are referencing
                   
                   report += String.Format("Worker# {0} will be done with {1} after {2} shifts \r\n ", index, bee.CurrentJob, bee.ShiftsLeft);
                 
                }
                if(bee.DidYouFinish(bee) == true)
                {
                    // update status report that bee# is finished jobname
                    // and is ready for next job.
                    report += String.Format("Worker#{0} is finished the job \r\n " +
                        "Worker#{0} is not working \r\n ", index);
                    
                   // string noJob = String.Format("Worker#{0} is not working", index);
                }
            }
            return report;
        }
        //Remember typical naming convention for private field is _private 
    }

   public class Worker
     {
         //Declare Backing Fields
         private string currentJob;
         private int shiftsLeft;
         private int shiftsToWork;
         private int shiftsWorked;
         private string[] jobsICanDo;

        //Declare Public Properties    
         public string CurrentJob { get { return currentJob; } }
         
        public int ShiftsLeft { get {return shiftsLeft; } }

        public int ShiftsToWork { get { return shiftsToWork; }}

        public int ShiftsWorked { get; set; }
       
      //Setup Object Constructor

        public Worker(string[] JobsICanDo)
        {
            this.jobsICanDo = JobsICanDo;
        }

      //Declare Methods

       // The Queen uses this method to assign a new job to the workers
       // if the worker is already doing the job it returns false. If
       // the worker is not doing the job, it checks to see if it is a 
       // job the worker can do. If it is, it breaks the for loop and 
       // sets the shiftsToWork field to the value passed to the 
       // numberOfShifts parameter. Then it sets the currentJob field 
       // to the value of the job parameter. It resets shiftsWorked to 
       // zero. Then it returns true.


        public bool DoThisJob(string job, int numberOfShifts)
        {
            if (job != currentJob) //Alternative if(!job.Equals(currentJob), checks if current job is already being done.
            {
                for (int x = 0; x <= jobsICanDo.Length - 1; x++)
                    if (job == jobsICanDo[x]) 
                        break; 
                    {
                        this.shiftsToWork = numberOfShifts; //remember to use this keyword for props
                        currentJob = job;
                        shiftsWorked = 0;
                     return true;   
                    }
            }
                return false; 
            }

       // Worker works a shift and then checks to see if it has any shifts
       // left to work. If it does not, it sets currentJob to null so it 
       // can accept the next job. Otherwise it returns false so it can 
       // continue working.

        public bool DidYouFinish(Worker workers)
        {
            shiftsToWork--;
            if (shiftsToWork == 0)
            {
                currentJob = null;
                return true;
            }
            else
                return false;
        } 
        }
       
    }     
  


