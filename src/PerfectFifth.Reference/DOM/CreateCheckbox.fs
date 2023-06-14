module P5Reference.DOM.CreateCheckbox

open P5.Core
open P5.DOM

let draw p5 =
    let checkbox = createCheckboxWithLabelAndValue p5 "label" false

    let myCheckedEvent _ =
        let msg = if checkbox.isChecked () then "Checking!" else "Unchecking!"
        console.log msg

    checkbox.changed myCheckedEvent

let run node = display node draw
