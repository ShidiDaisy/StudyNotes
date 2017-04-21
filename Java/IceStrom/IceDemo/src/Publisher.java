// **********************************************************************
//
// Copyright (c) 2003-2013 ZeroC, Inc. All rights reserved.
//
// This copy of Ice is licensed to you under the terms described in the
// ICE_LICENSE file included in this distribution.
//
// **********************************************************************

import Demo.*;

public class Publisher extends Ice.Application
{
    public int
    run(String[] args)
    {
        
        String topicName = "time";

        IceStorm.TopicManagerPrx manager = IceStorm.TopicManagerPrxHelper.checkedCast(
            communicator().propertyToProxy("TopicManager.Proxy"));
        if(manager == null)
        {
            System.err.println("invalid proxy");
            return 1;
        }

        //
        // Retrieve the topic.
        //
        IceStorm.TopicPrx topic;
        try
        {
            topic = manager.retrieve(topicName);
        }
        catch(IceStorm.NoSuchTopic e)
        {
            try
            {
                topic = manager.create(topicName);
            }
            catch(IceStorm.TopicExists ex)
            {
                System.err.println(appName() + ": temporary failure, try again.");
                return 1;
            }
        }

        //
        // Get the topic's publisher object, and create a Clock proxy with
        // the mode specified as an argument of this application.
        //
        Ice.ObjectPrx publisher = topic.getPublisher();
       
        publisher = publisher.ice_twoway();
        
        ClockPrx clock = ClockPrxHelper.uncheckedCast(publisher);

        System.out.println("publishing tick events. Press ^C to terminate the application.");
        try
        {
            java.text.SimpleDateFormat date = new java.text.SimpleDateFormat("MM/dd/yy HH:mm:ss:SSS");
            while(true)
            {
                
                clock.tick(date.format(new java.util.Date()));

                try
                {
                    Thread.currentThread().sleep(1000);
                }
                catch(java.lang.InterruptedException e)
                {
                }
            }
        }
        catch(Ice.CommunicatorDestroyedException ex)
        {
            // Ignore
        }

        return 0;
    }

    public static void
    main(String[] args)
    {
        Publisher app = new Publisher();
        int status = app.main("Publisher", args, "config.pub");
        System.exit(status);
    }
}
