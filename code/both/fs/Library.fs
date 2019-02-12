namespace fs.Shared

type Address = { Line1: string; Line2: string; PostCode: string }

type Email = Email of string
type Phone = Phone of string
type Contact = 
    | JustEmail of Email
    | JustPhone of Phone
    | EmailAndPhone of Email * Phone