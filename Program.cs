using System;

MooseSays("Ask me a question.");

void MooseSays(string message)
{
    Console.Write($@"
                                           _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
");
}


string[] Responses = {
"As I see it, yes.",
"Ask again later.",
"Better not tell you now.",
"Cannot predict now.",
"Concentrate and ask again.",
"Don’t count on it.",
"It is certain.",
"It is decidedly so.",
"Most likely.",
"My reply is no.",
"My sources say no.",
"Outlook not so good.",
"Outlook good.",
"Reply hazy, try again.",
"Signs point to yes.",
"Very doubtful.",
"Without a doubt.",
"Yes.",
"Yes – definitely.",
"You may rely on it.",
};


getResponse();

void getResponse()
{
    string question = Console.ReadLine();
    if (question == null)
    {
        Console.Write("Come back again when you have more questions!");
    }
    else
    {
        int mooseResponse = new Random().Next(1, 19);
        MooseSays(Responses[mooseResponse]);
        getResponse();
    }
}

