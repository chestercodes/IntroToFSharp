## Discriminated unions

---?code=code/du/comms.cs&lang=cs

@[1-9](Class to contain email address)
@[11-19](Class to contain phone number)
@[21-35](Contact information)
@[27-31](Throws if neither email or phone)
@[41-51](Instantiation of different contact objects)
@[50-51](Possible runtime error)


---?code=code/du/comms.fsx&lang=fs

@[1-4](Discriminated union to hold email)
@[6-9](Discriminated union to hold phone)
@[11-14](Contact type)
@[12](Just Email)
@[13](Just Phone)
@[14](Email and phone)
@[11-14](No compilable way to have neither phone or email)
@[16-21](Creation of different named contacts)

