# Thundra Lambda Logging (C#)

This is a Lambda template with Thundra Logs enabled.

The template will provide the basic configuration and dependencies needed to monitor the Lambda function with Thundra Logs.

These instructions are written presuming that you have already installed Thundra templates to your dotnet CLI.

### Using Thundra Logging Template:

#### 1 - Create Template

When using the comamnd below, please refer to the Options below to see what variables you could pass.

```bash
dotnet new thundra.log
```

#### 2 - Configure

Make the following configurations in the `src/ThundraLoggingExample` directory, to the 'aws-lambda-tools-defaults.json' file

- Add Api Key
  To the `environment-variables` tag.

- Add your region
  Add your preferred AWS region to the `region` tag.

- Add an IAM role
  To create an IAM role:
  1. Sign in to the AWS Management Console and open the IAM console at https://console.aws.amazon.com/iam/.
  2. Follow the steps in IAM Roles in the IAM User Guide to create an IAM role (execution role). As you follow the steps to create a role, note the following:
     _ In Select Role Type, choose AWS Service Roles, and then choose AWS Lambda.
     _ In Attach Policy, choose the AWSLambdaBasicExecutionRole policy.
     After creating your role, add it to the `profile` tag.

#### 3 - Write Your Handler Code

From the Handler method `DoHandleRequest`, it can be seen that the logger is already created. You may visit the [Log Support](https://docs.thundra.io/v1.0.0/docs/dotnet-log-support) section of Thundra's .NET agent documentation to learn more regarding using Logs.
You may write your handler code accordingly within the `DoHandleRequest` method.

### Options:

-k|--key The Thundra API Key which you can procure from the Thundra Console.  
 string - Optional  
 Default: your_API_Key

-p|--profile The AWS credentials profile set in aws-lambda-tools-defaults.json and used as the default profile when interacting with AWS.
string - Optional  
 Default: default

-r|--region The AWS region set in aws-lambda-tools-defaults.json and used as the default region when interacting with AWS.  
 string - Optional  
 Default: eu-west-2

To insert your handler code into the template, add it within the `DoHandleRequest` method.

_Please visit the [Installation and Configuration](https://docs.thundra.io/v1.0.0/docs/dotnet-installation-and-configuration) section of Thundra's .NET agent docs to know more_
