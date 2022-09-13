# Lab1

## How the Program Works
This exercise will take an input of type string a print, all substrings that begin and ends with the same digit. It shall start at index 0 in the input string, find the next index of the matching digit and create a substring of the start and end index. The substring is only valid if it only contains numbers and not letter nor special characters.
The valid substrings get printed to the screen, where a solution is marked in the color green, and the rest of the input string is colored white.

All the substring that is valid will be added up to a sum and het printed out to the screen.

``` cs
const string input = "29535123p48723487597645723645";
```

<img width="164" alt="hitta numret" src="https://user-images.githubusercontent.com/50596493/188883384-34653117-ef20-4666-8bfd-11663b8b0f45.PNG">

``` 
The sum is: 5836428677242
```
## Unit Test
In the folder ... is a xUnit project that test all the functions in ... . the xUnit project test if the functions return the expected values, and terminate if a null or empty parameters are passed in.
