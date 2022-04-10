It's my honor to have your viewing.
I did some optimizitions for improving code performance. 
First, the variable, bool is_sort, which used to judge whether the elements of the array are ordered. Each outer loop make the variable be false, and if the code arr[n]>arr[n+1] meets. is_Sort will be changed to true; Else Break; 
Second, for(int n = 0;n<arr.Length - 1 - m;n++) ; the m here, is used to reducing the numbers of Execution. There is no need to compare the one which you have done. 
That's all. Thank you.

Sincerely.
