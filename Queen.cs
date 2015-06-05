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

        private Worker[] workers;
        private int shiftNumber = 0;

        //Setup Object Constructor 

        public Queen(Worker[] workers)
        {
            this.workers = workers; 
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
      
        public string WorkTheNextShift()
        {
 
            shiftNumber++;
             string report;

            report = String.Format("Report for shift# {0} \r\n " , shiftNumber);
            foreach (Worker bee in workers)
            {
                int index = Array.IndexOf(workers, bee);
              //  bee.DidYouFinish(bee); This line is unnecessary. Everytime bee.DidYouFinish(bee) 
              //  checked the method is run. Putting it here increments the shiftsWorked field twice
                
                if(bee.DidYouFinish(bee))
                {
                    // update status report that bee# is finished jobname
                    // and is ready for next job.
                    report += String.Format("Worker#{0} is finished the job \r\n " , index);
                    
                   // string noJob = String.Format("Worker#{0} is not working", index);
                }
                    if (String.IsNullOrEmpty(bee.CurrentJob))
                    {
                        report += String.Format("Worker#{0} is not working \r\n ", index);
                    }
                else
                    if(bee.ShiftsLeft > 0)
                    {
                        report += String.Format("Worker#{0} is doing {1} for {2} more shifts \r\n", index, bee.CurrentJob, bee.ShiftsLeft);
                    }
                        else
                    {
                        report += String.Format("Worker #{0} will be done with {1} after this shift \r\n", index, bee.CurrentJob);
                    }
            }
            return report;
        }
        //Remember typical naming convention for private field is _private 
    }

   public class Worker
     {
         //Declare Backing Fields
       private string currentJob = "";
       //  private int shiftsLeft; No backing field for this property
         private int shiftsToWork;
         private int shiftsWorked;
         private string[] jobsICanDo;

        //Declare Public Properties    
         public string CurrentJob { get { return currentJob; } }

         public int ShiftsLeft { get { return shiftsToWork - shiftsWorked; } }

        public int ShiftsToWork { get { return shiftsToWork; }}

       
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



        public bool DidYouFinish(Worker workers)
        {
            if (string.IsNullOrEmpty(currentJob))
                return false;
                shiftsWorked++;
            
            if (shiftsWorked > shiftsToWork)
            {
                shiftsToWork = 0;
                shiftsWorked = 0;
                currentJob = null;
                return true;
            }
            else
            return false;
        }

        }
       
    }     
  


