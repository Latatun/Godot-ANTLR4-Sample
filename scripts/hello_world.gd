extends Node

signal on_text_parsed(result: String)

@onready var example_script = load("res://scripts/ParserExample.cs")
var example

func _ready():
	example = example_script.new()

func _on_line_edit_text_submitted(new_text):
	var result = example.GetResult(new_text)
	on_text_parsed.emit(result)
