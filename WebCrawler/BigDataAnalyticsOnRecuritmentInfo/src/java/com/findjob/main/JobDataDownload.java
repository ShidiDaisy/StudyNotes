package com.findjob.main;

import com.findjob.util.GetHtmlResource;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.nio.charset.StandardCharsets;
import java.util.List;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;

/**
 *
 * @Description: Scrape Requirement Keywords
 * @date 19/6/21 11:46 PM
 *
 */
public class JobDataDownload {
    public static void main(String[] args) throws IOException {
        //multi-threads to scrape data
        // initial thread pool
        ExecutorService executorService = Executors.newFixedThreadPool(8);
        final StringBuilder sb = new StringBuilder();

        FileOutputStream out = new FileOutputStream(new File("/Users/shidiyang/Documents/workspace/BigDataAnalyticsOnRecuritmentInfo/job/keywords.txt"));

        for (int i = 0; i < 10; i++){
            String url = "https://m.liepin.com/zhaopin/pn"+i+"/?keyword=%E5%A4%A7%E6%95%B0%E6%8D%AE";
            final List<String> jobUrlList = GetHtmlResource.getJobUrl(url);
            executorService.execute(new Runnable() {
                @Override
                public void run() {
                    for(String joburl:jobUrlList){
                        List<String> keywords = GetHtmlResource.getKeywords(joburl);
                        for(String key: keywords){
                            sb.append(key).append("\t");
                            System.out.println(key);
                        }
                    }
                }
            });
        }

        byte[] bytes = sb.toString().getBytes();
        out.write(bytes);
        out.flush();;
        out.close();
    }
}
