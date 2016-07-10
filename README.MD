ActionInsideIEnumerator.unity shows Action to be assigned inside IEnumerator, and it yeild unexpected answer.
The weird one having all local variable temp reference to the last created variable temp .

ActionOutsideIEnumerator.unity yields the correct that the variables in the "for loop" actually store and reference each parameter temp.

The only difference between ActionOutsideIEnumerator and ActionInsideIEnumerator is just moving content of IEnumerator class to another function.
