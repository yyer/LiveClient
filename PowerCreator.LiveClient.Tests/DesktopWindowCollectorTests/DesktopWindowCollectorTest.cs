﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PowerCreator.LiveClient.Core.AudioDevice;
using PowerCreator.LiveClient.Core.AudioEncoder;
using PowerCreator.LiveClient.Core.EnumWindows;
using PowerCreator.LiveClient.Core.Record;
using PowerCreator.LiveClient.Core.VideoDevice;
using PowerCreator.LiveClient.Core.VideoEncoder;
using PowerCreator.LiveClient.Infrastructure.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PowerCreator.LiveClient.Tests.DesktopWindowCollectorTests
{
    [TestClass]
    public class DesktopWindowCollectorTest : TestBaseWithLocalIocManager
    {
        private readonly IVideoEncoder videoEncoder;
        private readonly IVideoDeviceManager videoDeviceManager;
        private readonly IAacEncoder aacEncoder;
        private readonly IAudioDeviceManager audioDeviceManager;
        public DesktopWindowCollectorTest()
        {
            videoEncoder = Resolve<IVideoEncoder>();
            aacEncoder = Resolve<IAacEncoder>();
            audioDeviceManager = Resolve<IAudioDeviceManager>();
        }
        [TestMethod]
        public void CollectWindowImageAndRecordTest()
        {
            IWindowEnumerator windowEnumerator = new WindowEnumerator();
            var windowList = windowEnumerator.GetWindowList();

             IVideoDevice videoDevice = new DesktopWindowCollector(9999,"桌面采集器测试", windowList.First().HWD);
            videoEncoder.SetVideoSource(videoDevice);

            var audioDevice = audioDeviceManager.GetAudioDeviceById(1);
            aacEncoder.SetAudioDataSource(audioDevice);

            Record record = new Record(videoEncoder, aacEncoder);
            record.StartRecord(@"windowcollecttest.mp4");
            Thread.Sleep(3000);
            record.StopRecord();
        }
    }
}