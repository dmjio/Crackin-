/*implement a function void * reverse (char *); which reverses a null terminated string*/

#include <stdio.h>
#include <stdlib.h>

void rev_str(char * str){
  char temp;
  char * end = str;
  if (!str) return;
  while (*end){
    end++;
  }
  end--;
  while (str < end){
    temp = *str;
    *str = *end;
    *end = temp;
    end++;
    str--;
  }
}

int main(int argc, char *argv[])
{
  char * str;
  str = malloc(sizeof(40000));
  rev_str(str);
  printf("%s", str);
  return 0;
}