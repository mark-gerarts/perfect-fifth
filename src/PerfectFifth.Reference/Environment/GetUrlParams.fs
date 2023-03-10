module P5Reference.Environment.GetUrlParams

open P5.Core
open P5.Typography
open P5.Environment
open Fable.Core.JsInterop

let draw p5 =
    // Try appending ?day=04&month=05&year=2023 to the URL.
    let urlParams = getURLParams p5

    // The `obj?paramName` syntax is made available through Fable.Core.JsInterop.
    text p5 urlParams?day 10 20
    text p5 urlParams?month 10 40
    text p5 urlParams?year 10 60

let run node = display node draw
