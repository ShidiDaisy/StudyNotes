package com.findjob.util;

import org.jsoup.Jsoup;
import org.jsoup.nodes.Document;
import org.jsoup.nodes.Element;
import org.jsoup.select.Elements;

import java.io.*;
import java.net.URL;
import java.net.URLConnection;
import java.util.ArrayList;
import java.util.List;
import java.util.Locale;

public class GetHtmlResource {
    public static String getHtmlResourceByUrl(String url){
        StringBuilder buffer = new StringBuilder();
        InputStreamReader isr = null;
        try{
            URL urlObj = new URL(url);
            URLConnection uc = urlObj.openConnection();
            isr = new InputStreamReader(uc.getInputStream(), "utf-8");
            BufferedReader reader = new BufferedReader(isr);
            String line;
            while ((line=reader.readLine()) != null){
                buffer.append(line).append("\n");
            }
        }catch (Exception e){
            e.printStackTrace();
        }finally {
            try {
                if(isr!=null)isr.close();
            }catch (IOException e){
                e.printStackTrace();
            }
        }
        return buffer.toString();
    }

    public static List<String> getJobUrl(String url){
        List<String> listUrl = new ArrayList<>();
        //Get webpage source code
        String html = getHtmlResourceByUrl(url);

        //Convert String to Document Object
        Document document = Jsoup.parse(html);
        Elements jobList = document.getElementsByClass("job-card");
        for(Element job:jobList){
            String jobUrl = job.attr("href");
            listUrl.add(jobUrl);
        }
        return listUrl;
    }

    public static List<String> getKeywords(String url){
        String html = getHtmlResourceByUrl(url);
        Document document = Jsoup.parse(html);
        String content = document.getElementsByClass("content-word").text();

        //提取字符串中的英文
        String[] arr = content.split("[^a-zA-z]+");
        List<String> stringList = new ArrayList<>();
        for (String s:arr){
            stringList.add(s.toLowerCase());
        }
        return stringList;
    }

    public static void main(String[] args) {
        List<String> jobUrl = getJobUrl("https://m.liepin.com/zhaopin/?dqs=000&keyword=%E5%A4%A7%E6%95%B0%E6%8D%AE");
        getKeywords("https://www.liepin.com/job/1938788739.shtml");
    }
}
