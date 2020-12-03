// Learn more about F# at http://fsharp.org

open System
open System.IO

let inputs = File.ReadAllLines("Day1Input.txt")
let inputList = Seq.toList inputs |> Seq.map Int32.Parse

for x in inputList do
    for y in inputList do
        if x + y = 2020 then 
            let answer = x * y |> string
            printfn "%A" answer