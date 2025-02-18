from genanki import Model, Note, Deck, Package

# Define a model for the Anki deck
model_id = 1607392319
model = Model(
    model_id,
    'Physics Note Model',
    fields=[
        {'name': 'Question'},
        {'name': 'Answer'},
    ],
    templates=[
        {
            'name': 'Card Template',
            'qfmt': '{{Question}}',
            'afmt': '{{FrontSide}}<hr id="answer">{{Answer}}',
        },
    ],
)

# Create the deck
deck_id = 2059400110
deck = Deck(deck_id, 'Physics Notes')

# Add notes to the deck
import pandas as pd
physics_notes = pd.read_csv('Cleaned_Physics_Notes_For_Anki.csv')
for _, row in physics_notes.iterrows():
    question = row['Question'] if isinstance(row['Question'], str) else ''
    answer = row['Answer'] if isinstance(row['Answer'], str) else ''
    if question and answer:
        note = Note(model=model, fields=[question, answer])
        deck.add_note(note)

# Write to APKG
Package(deck).write_to_file('Physics_Notes.apkg')
print("APKG file created: Physics_Notes.apkg")