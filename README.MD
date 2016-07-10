ActionInsideIEnumerator.unity shows Action to be assigned inside IEnumerator, and it yeilds unexpected answer.
The weird one having all local variable temp reference to the last created variable temp.
The final accumulated Action print out with temp 2,2,2;
In further inspection, "Action a" having all local variables temp references to the last created temp in each for loop.(So it has temp 1 and 1 in the second for loop; temp having 2, 2 and 2 in the third for loop.)


ActionOutsideIEnumerator.unity yields the correct that the variables in the "for loop" actually store and reference each parameter temp. 
Action a having all local references correctly.(so you see 0 in the first for loop; 0, 1 in the second for loop; 0, 1, 2 in the third for loop.)
The final accumulated Action print out with temp 0, 1 and 2, which is correct and exptected.

The only difference between ActionOutsideIEnumerator and ActionInsideIEnumerator is just moving content of IEnumerator class to another function.
