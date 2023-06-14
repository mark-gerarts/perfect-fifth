module P5Reference.DOM.P5MediaElementVolume1

open P5.Core
open P5.Color
open P5.Environment
open P5.DOM
open P5.Typography

type Counter =
    | One
    | Two
    | Three

let mutable audio: P5MediaElement option = None

let loaded () =
    match audio with
    | Some audio -> audio.play ()
    | None -> ()

let setup p5 =
    audio <- Some <| createAudioWithCallback p5 "assets/lucky_dragons.mp3" loaded
    setTextAlign p5 centerTextAlign

    One

let draw p5 counter =
    let (color, textContent) =
        match counter with
        | One -> RGB(0, 255, 0), "volume(0.9)"
        | Two -> RGB(255, 255, 0), "volume(0.5)"
        | Three -> RGB(255, 0, 0), "volume(0.1)"

    background p5 color
    text p5 textContent (width p5 / 2 |> float) (height p5 / 2 |> float)

let mousePressed _ _ counter =
    match audio, counter with
    | Some audio, One ->
        audio.setVolume 0.9
        Two
    | Some audio, Two ->
        audio.setVolume 0.5
        Three
    | Some audio, Three ->
        audio.setVolume 0.1
        One
    | _, _ -> counter


let run node =
    play node setup noUpdate draw [ OnMousePressed(Update mousePressed) ]
