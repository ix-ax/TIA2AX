# TIA2AX
Provides tool to transfer HW configuration from TIA portal to AX's data structures

TIA2AX is a CLI tool exporting the IO image of all connected devices to each PLC inside the TiaPortal project.
It takes two arguments:
- ` -x, --tia-source-project` - Absolut path to the TiaPortal project (to the *.ap18 file).
- `-o, --output-folder` - Absolut path to the output directory, where the result will be placed.

As this tool is just the temporary solution until the HWC will be done, it supports only TiaPortal project of version V18.0.
If neccessary there could be released a new version for newer version of TiaPortal, but for the simpliness as a separate tool.

### Example of using TIA2AX for version V18.0
    preconditions:  TiaPortal V18.0 including TiaOpeness installed
                    TiaPortal project that is going to be processed is compiled and saved (does not has to be closed).
         

- run command line prompt 
- navigate to the folder where the .exe file of the tool is located
- for the current version V18.0 of the TiaPortal (at the time of creating this documentation) run the command as in this example
- V18_0_tia2ax.exe -x "D:\_tmp\S7_1516_example\S7_1516_example.ap18" -o "D:\_tmp\Export"
- In case that you are prompted to grant the access, click `Yes to all`.
-    ![Alt text](image.png)




