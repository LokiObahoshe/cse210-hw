using System;

class Suggestion
{
    private List<string> _suggestions = new List<string>()
    {
        "I have told you these things, so that in me you may have peace. In this world you will have trouble. But take heart! I have overcome the world. [John 16:33]",
        "One thing I ask from the Lord, this only do I seek: that I may dwell in the house of the Lord all the days of my life, to gaze on the beauty of the Lord and to seek him in his temple. [Psalm 27:4]",
        "I thank and praise you, God of my ancestors: You have given me wisdom and power, you have made known to me what we asked of you, you have made known to us the dream of the king. [Daniel 2:23]",
        "When he comes, he will prove the world to be in the wrong about sin and righteousness and judgment. [John 16:8]",
        "Now this is eternal life: that they know you, the only true God, and Jesus Christ, whom you have sent. [John 17:3]",
        "If your brother or sister sins, go and point out their fault, just between the two of you. If they listen to you, you have won them over. [Matthew 18:15]",
        "Great peace have those who love your law, and nothing can make them stumble. [Psalm 119:165]",
        "A good man brings good things out of the good stored up in his heart, and an evil man brings evil things out of the evil stored up in his heart. For the mouth speaks what the heart is full of. [Luke 6:45]",
        "The Lord is not slow in keeping his promise, as some understand slowness. Instead he is patient with you, not wanting anyone to perish, but everyone to come to repentance. [2 Peter 3:9]"
    };

    Random random = new Random();
    public void DisplaySuggestion()
    {
        int index = random.Next(_suggestions.Count);
        Console.WriteLine("\n--------------------\n");
        Console.WriteLine($"Thank you for using the Scripture Memorizer. Here's another scripture quote to study if wished: \n\n\"{_suggestions[index]}\"\n");
    }
}