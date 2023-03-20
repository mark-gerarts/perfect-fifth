module P5Reference.Color.Background4

open P5.Core
open P5.Color

let draw p5 =
    // three-digit hexadecimal RGB notation
    background p5 (Name "#fae")

let run node = display node draw
