# **Exercise 1 (3110):**

You are given a string 's'. The **score** of a string is defined as the sum of the absolute difference between the **ASCII** values of adjacent characters.

Return the **score** of 's'.

  Input: s = "hello"
  
  Output: 13
  
  Explanation:
  
  The ASCII values of the characters in s are: 'h' = 104, 'e' = 101, 'l' = 108, 'o' = 111. So, the score of s would be |104 - 101| + |101 - 108| + |108 - 108| + |108 - 111| = 3 + 7 + 0 + 3 = 13.

## **A little about the program:**

It took about 10 minutes to solve the problem. The program converts the string into an ASCII byte array, storing each character as its corresponding ASCII code. It then goes through each byte and calculates the absolute value of the difference between the current and previous bytes. The resulting difference values are displayed on the screen and also summed to give an overall row score.

# **Exercise 2 (21):**

You are given the heads of two sorted linked lists list1 and list2.

Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.

Input: list1 = [1,2,4], list2 = [1,3,4]

Output: [1,1,2,3,4,4]

Return the head of the merged linked list.

---

<p align="center">I would be grateful if you write your opinion about the project! ☺️</p>
