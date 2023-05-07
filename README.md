# CRUZ, ALJON N. - Assignment Solutions

These are the solutions for a technical exam.

### 01. Clock

```
Please write console app. User should be able to input hours and minutes of the
analogue clock. Program must calculate lesser angle in degrees between hours
arrow and minutes arrow and provide output in the console window.
```

### 02. Hierarchy

```
          o
        /   \
      o       o
      |     / | \
      o   o   o   o
         /   / \
        o   o   o
            |
            o


After creating this object, we can add new Branch type objects into branches
variable. Doing so we increase object depth by one. Into created objects we can
add again new branches etc. In the figure below we have similar structure. This
structure depth is 5.
```

```
public class Branch
{
    public List<Branch> branches;
}
```

```
Please write a program, where you would create similar structure. Pass this
structure into your own created method and calculate the depth of provided
structure. Main requirement to complete this task: use recursion.
```