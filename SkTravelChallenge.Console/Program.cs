using Microsoft.SemanticKernel;

// Create kernel
var builder = Kernel.CreateBuilder();
builder.AddAzureOpenAIChatCompletion(
    deploymentName: "<deployment-name>", // Azure OpenAI deployment name
    endpoint: "<aoai-endpoint-url>", // Azure OpenAI endpoint
    apiKey: "<aoai-key>", // Azure OpenAI API key
    modelId: "gpt-35-turbo-16k" // Azure OpenAI model ID
);

var kernel = builder.Build();

var result = await kernel.InvokePromptAsync(
        "Give me a list of breakfast foods with eggs and cheese");
Console.WriteLine(result);


