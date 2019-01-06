## Pattern matching

Pattern matching is ubiquitous in F#. It is used for:

binding values to expressions with let

---?code=code/match/pm_let.fsx&lang=fsharp

in function parameters

---?code=code/match/pm_function.fsx&lang=fsharp

branching using the match..with syntax

---?code=code/match/pm_match.fsx&lang=fsharp

---


## Fizzbuzz

Players take turns to count incrementally, replacing any number divisible by three with the word "Fizz", and any number divisible by five with the word "Buzz". Numbers divisible by both become "Fizz Buzz".

---


---?code=code/match/fizz.cs&lang=csharp

---

---?code=code/match/fizz.fsx&lang=fsharp

@[1-6](Test one)
@[10-15](Test two)

