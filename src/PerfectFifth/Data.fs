namespace P5

module Data =

    open Fable.Core
    open P5.Core

    [<Emit("$0.nfc($1)")>]
    let nfc (p5: P5) (num: float) : string = jsNative

    [<Emit("$0.nfc($1, $2)")>]
    let nfcWithPrecision (p5: P5) (num: float) (precision: float) : string = jsNative

    [<Emit("$0.nfc($1)")>]
    let nfcMultiple (p5: P5) (nums: float array) : string = jsNative

    [<Emit("$0.nfc($1, $2)")>]
    let nfcMultipleWithPrecision (p5: P5) (nums: float array) (precision: float) : string = jsNative
