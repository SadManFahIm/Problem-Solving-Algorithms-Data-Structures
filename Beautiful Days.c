#include <stdio.h>
#include <stdlib.h>

 int
reversed (int a) 
{
  
char c, *ptr_b, *ptr_e;
  
char buff[12];
  
int b;
  
 
    //Integer to string
    sprintf (buff, "%d", a);
  
 
    //Reversing string
    ptr_b = buff;
  
ptr_e = buff;
  
while (*ptr_e)
    {				//Moving ptr_e to point the last char in the string
      ++ptr_e;
    
}
  
--ptr_e;
  
while (ptr_b < ptr_e)
    {				//Reversing
      c = *ptr_b;
      
*ptr_b = *ptr_e;
      
*ptr_e = c;
      
++ptr_b;
      
--ptr_e;
    
}
  
 
    //String to integer
    sscanf (buff, "%d", &b);
  
 
return b;

}


 
 
int
main () 
{
  
int i, j, k, rev, diff, count = 0;
  
 
    //Input
    scanf ("%d %d %d", &i, &j, &k);
  
 
    //Counting
    for (int ii = i; ii <= j; ++ii)
    {
      
rev = reversed (ii);
      
diff = abs (ii - rev);
      
if (diff % k == 0)
	++count;
    
}
  
 
    //Output
    printf ("%d\n", count);
  
 
return 0;

}
