module P5Reference.DOM.P5MediaElementOnEnded

open P5.Core
open P5.DOM

let sayDone (elt: P5MediaElement) =
    console.log (sprintf "Done playing %s" elt.src)

let draw p5 =
    let audioEl = createAudio p5 "assets/beat.mp3"
    audioEl.showControls ()
    audioEl.onEnded (sayDone)

let run node = display node draw
