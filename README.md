# CSC-260-Project
This is for my CSC-260 Object Oriented Design project


This project proved to be more difficult than I anticipated, largely due to the obscurity of the game I designed this calculator around, Dark Souls III. Some equations, like the one for HP for instance, are not openly available on the internet, so I hade to use some data to find them with excel (I put the excel documents in a folder labeled "equations"). They are pretty accurate but are not perfect. A lot of the data I was able to gather on the internet proved to be slightly incorrect, I think mostly having to do with slight changes to the game being made between when data was released and now. The equations I use in my calculations (that I did not engineer with excell) are correct and proven and tested by not only me but those in the community that found it and posted it for me to use. The spreadsheets and data I used to work on this project are all linked down below, both the original versions and the ones I made to concatinate strings. I wanted to have almost every weapon in the calculator, but as I mentioned before a lot of the data I've been able to easily obtain on the internet about the base damage of about 1/5 of weapons is just false. I commented out most of the weapons that I initially included because it would take many hours of work to go into the game and figure out exactly how much base attack each weapon has and then enter it by hand into the system. So instead I verified somewhere around 20 different weapons for you to test if you want. Again, I am sure that my equations are correct, but if the base attack value that gets entered into the equation is off by even a couple digits, it can drastically change the calculations made. Please feel free to check my equations, or look up the base attack for one of the weapons commented out and try it out (only physical damage is within the scope of the project, and the calculator assumes weapons are max upgraded). Ok anyway, thank you for reading this, I worked very hard on this project and I hope you enjoy it :)

This article details how final weapon attack is calculated, I used it to design my calculator:
https://blog.mugenmonkey.com/2016/07/22/how-to-calculate-ar.html

That article links to a spreadsheet that is necessary for the attak equation:
https://docs.google.com/spreadsheets/d/1nGXbJ5DEaWCtXHhj46Wws4HM0KkV85nyczJemqmtDF8/edit

I used this to get weapon minimum stats and base attack (not all values are correct and this does affect the calculator):
https://docs.google.com/spreadsheets/d/1-sm_mSATMS0XFBG-dH3HhQcfM3dxh6hbLNR8Qe_1vaI/edit 

and this is the two weapon spreadsheets edited by me so that they would create my objects (too bad I didn't get to use them all):
https://docs.google.com/spreadsheets/d/1xpJ-6f-5SIif3HYiCMNBj-TVFhGri-NHjQcyqBT65N8/edit?usp=sharing

This is where I got all of the armour data (again not all of it is correct):
https://docs.google.com/spreadsheets/d/1fJlQHuubCGK9B4H1d80FEFPCfbVcFm4e_InsB_M9uHI/edit?pref=2&pli=1#gid=784590881

This is the object maker I created after referencing the above spreadsheet:
https://docs.google.com/spreadsheets/d/18QCas1DhOM8Y0gEDPaWudO4ojt6oan_r3cGXkKD41Y8/edit?usp=sharing

I ended up entering all of the ring data by hand so no links for that, and spells I made a spreadsheet from data I copied and pasted from the Dark Souls III wiki:
https://docs.google.com/spreadsheets/d/1CTNhOkLU_d0K8lP0SRfTJbiIn_P5tBKIF855a_5pcto/edit?usp=sharing
