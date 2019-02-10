
## Combine features

Combine Records, Pattern matching, Discriminated unions into program.

### Scenario

You have £1000 to put into a bank account to get the most at the end of 10 years. 

There are different bank accounts, with different APR rates. Some of the accounts give a free amounts as a joining gift.

Want to calculate the best deal...

---?code=code/uom/bank.fsx&lang=fs

@[1-10](Define units of measure)
@[13-23](Bank info and record)
@[25-37](Function to parse csv line or None)
@[29-30,37](Matches to array with 3 parts)
@[26-27,31-32,36](Matches to successful float and int parsing)
@[22-23,33-35](Bank info record)
@[39-42](Parse csv to bank infos)
@[44-50](Function to compound interest, takes rate and years as args)
@[52-55](Function to calculate amount after years)
@[57-68](Calculate amounts for bank infos)

---

@quote[and now for something completely different.]