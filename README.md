# Chess-Using-Vb.net > Demo 
This Software made For fun it's Between 500 to 600 Lines Easy and Simple 
Thanks for every one post some project and post Advice and Add New to People
I has been learnt Visual Basic From internet 
Chess Demo But Every Basic Rules Set

# Explain Code
 - Picture Name
    * D01 to D08  Black Team
    * D09 to D14  White Team
 - Resource image
    * 01.png to 08.png   White Team image
    *  1.png to  8.png   Black Team image
       # Programing
          - Event Click to 64 Picture >>>> 8 Row  Every Row +1(1A 1B 1C 1D 1E 1F 1G 1H)
            * Get name Of Clicked Picture >>>> Send it To Sub To detrmine Location 
              - Calling >>> Sub (Parts of Chess )

          - Sub (Parts of Chess ) vvv 
            * Set Group()={ A B C D E F G H } >>>to get number of Word in group
            * Get Number()= 1 2 3 4 5 6 7 8   >>>Set On Loop
            * After End Loop >>>> Set All Value ( Filed of Parts )
            * Calling def2( Group(1) + number )
      
          - def1(Picture name) Set to picture >
            * Compare Picture  With Cons Picture
            * Color of Picture Green or Red
          - def2(Name String) Calling def1 ^
            * Set Name string  to Picture def1(Picture)
          - Reset ()
            * Reset all image To Defult
          - ResetColor()
            * Reset All Color During Game
