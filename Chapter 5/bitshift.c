#include <stdio.h>


//check how many bits it takes to convert one integer into another


int convert(int a, int b){
  int k,count;
  count = 0;
  for (k = a ^ b; k != 0; k = k >> 1){
    count += k & 1;
  }
  return count;
}


int main(int argc, char *argv[])
{
  printf("%d", convert(31,14));
  return 0;
}

